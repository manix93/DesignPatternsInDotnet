using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Decorators;

public abstract class PizzaDecorator : IPizza
{
    private readonly IPizza _pizza;
    
    protected PizzaDecorator(IPizza pizza)
    {
        _pizza = pizza;
        Size = _pizza.Size;
        Ingredients = _pizza.Ingredients;
    }

    public string Size { get; init; }
    
    public ICollection<string> Ingredients { get; init; }

    public virtual decimal CalculatePrice()
    {
        return _pizza.CalculatePrice();
    }
}