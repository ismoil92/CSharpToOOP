using CSharpToOOP.Model;
using CSharpToOOP.Service;

namespace CSharpToOOP.Controller;

public class BuildingController
{
    IDataService dataService = new DataService();

    public void SaveFile(Building building)
    {
        dataService.SaveBuildingToFile(building);
    }

    public String ReadFile()
    {
        String result = dataService.ReadBuildingFromFile();
        return result;
    }
}