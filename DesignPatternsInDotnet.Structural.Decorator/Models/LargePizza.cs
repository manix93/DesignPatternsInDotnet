using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Models;

public class LargePizza : IPizza
{
    public string Size { get; init; } = "Large";

    public ICollection<string> Ingredients { get; init; } = new List<string>();

    public decimal CalculatePrice()
    {
        return 45;
    }
}