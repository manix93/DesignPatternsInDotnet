using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Models;

public class SmallPizza : IPizza
{
    public string Size { get; init; } = "Small";

    public ICollection<string> Ingredients { get; init; } = new List<string>();

    public decimal CalculatePrice()
    {
        return 25;
    }
}