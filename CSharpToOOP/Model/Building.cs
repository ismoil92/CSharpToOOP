namespace CSharpToOOP.Model;

public class Building
{
    public double Height { get; set; }
    public int NumberOfStoreys { get; set; }
    public int NumberOfFlats { get; set; }
    public int Entrances { get; set; }

    public override string ToString() => $"Height:{this.Height},    " +
        $" NumberOfStoreys:{this.NumberOfStoreys},  NumberOfFlats:{this.NumberOfFlats},   " +
        $" Entrances:{this.Entrances}\n";
}