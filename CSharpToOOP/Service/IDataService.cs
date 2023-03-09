using CSharpToOOP.Model;

namespace CSharpToOOP.Service;

public interface IDataService
{
    void SaveBuildingToFile(Building building);
    string ReadBuildingFromFile();
}