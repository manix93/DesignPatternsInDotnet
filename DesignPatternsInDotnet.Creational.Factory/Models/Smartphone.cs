namespace DesignPatternsInDotnet.Creational.Factory.Models;

public class Smartphone(string brand) : Phone(brand)
{
    public override void Show()
    {
        Console.WriteLine($"{Brand} smartphone.");
    }
}