using Models;

namespace Order{
public class BuildOrder{


    public List<Projects> CheckBuildOrder(){
    
    //add each project to the list of projects
    
    CreateProjects createProjects = new CreateProjects();
    List<Projects> projects = new List<Projects>();
    projects = createProjects.CreateListOfProjects();
    
    

    //add each dependency to the list of project dependencies

    CreateDependencies createDependencies = new CreateDependencies();
    List<Dependencies> dependencies = new List<Dependencies>();
    dependencies = createDependencies.CreateListOfDependencies();

    
    

//my build order

    
    List<String> buildOrder = new List<String>();
    List<Projects> tempProjectsList = new List<Projects>();
    List<Dependencies> tempListOfDependencies = new List<Dependencies>();
    Boolean isOrdering = true;
    Boolean isError = false; //DON'T QUESTION IT...
    int index = 0;


    //next, add the projects that have dependencies
    try
    {
        int projectCount = projects.Count(); 
        while(isOrdering)
        {
            //first, check and add all the projects that have no dependencies
            foreach(Projects project in projects)
            {
                var found = dependencies.Find(p => p.projectName == project.projectName);
                if(found == null)
                {
                    buildOrder.Add(project.projectName);
                }
                else
                {
                    tempProjectsList.Add(project);
                }
            }
            //set projects to the list with removed values
            projects = tempProjectsList;
            tempProjectsList = new List<Projects>();

            foreach(Dependencies dependency in dependencies)
            {
                var removed = projects.Find(p => p.projectName == dependency.projectDependency);
                if(removed != null)
                {
                    tempListOfDependencies.Add(dependency);
                }
            }
            dependencies = tempListOfDependencies;
            tempListOfDependencies = new List<Dependencies>();
            
            //add to our index
            index = index + 1;

            //if there are no more projects you have gotten the final build path!
            if(projects.Count == 0)
            {
                isOrdering = false;
            }

            //break out if it cannot find a proper build path (while loop should not run more times than there are projects)
            if(index > projectCount)
            {
                isError = true;
                isOrdering = false;
            }
            

        }

    }
    catch(System.InvalidOperationException e)
    {
        Console.WriteLine(e);
    }

    if(!isError) 
    {
        foreach(string name in buildOrder)
        {
            Console.WriteLine(name);
        }
    }
    else
    {
        Console.WriteLine("Error! Could not find a build path for these projects and dependencies! Exiting Program...");
    }

    return projects;
    }

}

}