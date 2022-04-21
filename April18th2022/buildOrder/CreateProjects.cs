using Models;

namespace Order

{
    
    public class CreateProjects{

    public List<Projects> CreateListOfProjects()
    {
    List<Projects> projects = new List<Projects>();
    Projects projectA = new Projects();
    projectA.projectName = "a";
    projects.Add(projectA);

    Projects projectB = new Projects();
    projectB.projectName = "b";
    projects.Add(projectB);

    Projects projectC = new Projects();
    projectC.projectName = "c";
    projects.Add(projectC);

    Projects projectD = new Projects();
    projectD.projectName = "d";
    projects.Add(projectD);

    Projects projectE = new Projects();
    projectE.projectName = "e";
    projects.Add(projectE);

    Projects projectF = new Projects();
    projectF.projectName = "f";
    projects.Add(projectF);

    return projects;

    }
    }


}