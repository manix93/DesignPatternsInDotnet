using DesignPatternsInDotnet.Structural.Decorator.Interfaces;

namespace DesignPatternsInDotnet.Structural.Decorator.Decorators;

public class MozzarellaPizzaDecorator : PizzaDecorator
{
    private const string Mozzarella = nameof(Mozzarella);
    
    private const decimal MozzarellaPrice = 5;
    
    public MozzarellaPizzaDecorator(IPizza pizza) : base(pizza)
    {
        pizza.Ingredients.Add(Mozzarella);
    }
    
    public override decimal CalculatePrice()
    {
        return base.CalculatePrice() + MozzarellaPrice;
    }
}