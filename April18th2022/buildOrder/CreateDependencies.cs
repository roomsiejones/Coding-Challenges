using Models;

namespace Order

{
    
    public class CreateDependencies{

    public List<Dependencies> CreateListOfDependencies()
    {
        List<Dependencies> dependencies = new List<Dependencies>();
        Dependencies dependencies1 = new Dependencies();
        dependencies1.projectName = "d";
        dependencies1.projectDependency = "a";
        dependencies.Add(dependencies1);

        Dependencies dependencies2 = new Dependencies();
        dependencies2.projectName = "b";
        dependencies2.projectDependency = "f";
        dependencies.Add(dependencies2);

        Dependencies dependencies3 = new Dependencies();
        dependencies3.projectName = "d";
        dependencies3.projectDependency = "b";
        dependencies.Add(dependencies3);

        Dependencies dependencies4 = new Dependencies();
        dependencies4.projectName = "a";
        dependencies4.projectDependency = "f";
        dependencies.Add(dependencies4);

        Dependencies dependencies5 = new Dependencies();
        dependencies5.projectName = "c";
        dependencies5.projectDependency = "d";
        dependencies.Add(dependencies5);

        //** Uncomment this code below to test the error with a circular dependency
        // Dependencies dependencies6 = new Dependencies();
        // dependencies6.projectName = "a";
        // dependencies6.projectDependency = "d";
        // dependencies.Add(dependencies6);

        return dependencies;

    }
    }


}