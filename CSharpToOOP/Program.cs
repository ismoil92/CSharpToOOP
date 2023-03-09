using CSharpToOOP.Controller;
using CSharpToOOP.Model;

BuildingController buildingController = new BuildingController();

buildingController.SaveFile(CreateBuildingBuilder.GetInstance().SetHeight(12.3).SetNumberOfStoreys(2).
    SetNumberOfFlats(3).SetEntrances(4).Build());

Console.WriteLine(buildingController.ReadFile());
