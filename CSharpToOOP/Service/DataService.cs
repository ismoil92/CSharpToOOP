using CSharpToOOP.Model;

namespace CSharpToOOP.Service;

public class DataService : IDataService
{
    public  string ReadBuildingFromFile()
    {
       using(StreamReader reader = new StreamReader("building.txt"))
        {
            string result =  reader.ReadToEnd();
            return result;
        }
    }

    public async void SaveBuildingToFile(Building building)
    {
        using(StreamWriter writer = new StreamWriter("building.txt", false))
            await writer.WriteLineAsync(building.ToString());
    }
}