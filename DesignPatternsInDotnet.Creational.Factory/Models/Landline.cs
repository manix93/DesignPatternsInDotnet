namespace DesignPatternsInDotnet.Creational.Factory.Models;

public class Landline(string brand) : Phone(brand)
{
    public override void Show()
    {
        Console.WriteLine($"{Brand} landline phone.");
    }
}