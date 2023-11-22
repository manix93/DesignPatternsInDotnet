using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Models;

public class MediumPizza : IPizza
{
    public string Size { get; init; } = "Medium";

    public ICollection<string> Ingredients { get; init; } = new List<string>();

    public decimal CalculatePrice()
    {
        return 35;
    }
}