using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Decorators;

public class SalamiPizzaDecorator : PizzaDecorator
{
    private const string Salami = nameof(Salami);
    
    private const decimal SalamiPrice = 4;
    
    public SalamiPizzaDecorator(IPizza pizza) : base(pizza)
    {
        pizza.Ingredients.Add(Salami);
    }
    
    public override decimal CalculatePrice()
    {
        return base.CalculatePrice() + SalamiPrice;
    }
}