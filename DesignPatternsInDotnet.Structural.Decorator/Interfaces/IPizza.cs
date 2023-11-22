namespace DesignPatternsInDotnet.Structural.Decorator.Interfaces;

public interface IPizza
{
    string Size { get; init; }
    
    ICollection<string> Ingredients { get; init; }
    
    decimal CalculatePrice();
}