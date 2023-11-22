using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Decorators;

public class PineapplePizzaDecorator : PizzaDecorator
{
    private const string Pineapple = nameof(Pineapple);
    
    private const decimal PineapplePrice = 2;
    
    public PineapplePizzaDecorator(IPizza pizza) : base(pizza)
    {
        pizza.Ingredients.Add(Pineapple);
    }
    
    public override decimal CalculatePrice()
    {
        return base.CalculatePrice() + PineapplePrice;
    }
}