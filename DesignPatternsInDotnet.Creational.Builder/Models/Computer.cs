namespace DesignPatternsInDotnet.Creational.Builder.Models;

public class Computer
{
    public Guid Id { get; private set; } = Guid.NewGuid();

    public string Motherboard { get; set; }

    public string CPU { get; set; }

    public string GraphicCard { get; set; }
    
    public string Memory { get; set; }

    public string Storage { get; set; }
    
    public string Case { get; set; }
    
    public string PSU { get; set; }
}