using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Decorators;

public class HamPizzaDecorator : PizzaDecorator
{
    private const string Ham = nameof(Ham);
    
    private const decimal HamPrice = 3;
    
    public HamPizzaDecorator(IPizza pizza) : base(pizza)
    {
        pizza.Ingredients.Add(Ham);
    }
    
    public override decimal CalculatePrice()
    {
        return base.CalculatePrice() + HamPrice;
    }
}