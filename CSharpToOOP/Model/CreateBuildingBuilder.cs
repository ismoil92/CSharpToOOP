namespace CSharpToOOP.Model;

public class CreateBuildingBuilder
{
    private static int id = 0;
    private static CreateBuildingBuilder builder=null!;
    private Building building = null!;

    public static CreateBuildingBuilder GetInstance()
    {
        if(builder == null)
            builder = new CreateBuildingBuilder();
        builder.building = new Building();
        id++;
        return builder;
    }

    public CreateBuildingBuilder SetHeight(double height)
    {
        builder.building.Height = height;
        return this;
    }

    public CreateBuildingBuilder SetNumberOfStoreys(int numberOfStoreys)
    {
        builder.building.NumberOfStoreys = numberOfStoreys;
        return this;
    }

    public CreateBuildingBuilder SetNumberOfFlats(int numberOfFlats)
    {
        builder.building.NumberOfFlats = numberOfFlats;
        return this;
    }

    public CreateBuildingBuilder SetEntrances(int entrances)
    {
        builder.building.Entrances = entrances;
        return this;
    }

    public Building Build() => this.building;

    public override string ToString() => $"ID:{id}, Building:{this.building.ToString}";
}