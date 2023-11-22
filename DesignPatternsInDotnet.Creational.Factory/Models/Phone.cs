namespace DesignPatternsInDotnet.Creational.Factory.Models;

public abstract class Phone(string brand)
{
    protected string Brand { get; } = brand;
    
    public abstract void Show();
}