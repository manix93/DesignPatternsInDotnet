using DesignPatternsInDotnet.Structural.Decorator.Decorators;
using DesignPatternsInDotnet.Structural.Decorator.Interfaces;
using DesignPatternsInDotnet.Structural.Decorator.Models;

Console.WriteLine("Pizza decorator");

var largePizza = new LargePizza();

var pizzaWithMozzarella = new MozzarellaPizzaDecorator(largePizza);
var pizzaWithDoubleMozzarella = new MozzarellaPizzaDecorator(pizzaWithMozzarella);
DisplayPizza(pizzaWithDoubleMozzarella);

var pizzaWithDoubleMozzarellaAndSalami = new SalamiPizzaDecorator(pizzaWithDoubleMozzarella);
DisplayPizza(pizzaWithDoubleMozzarellaAndSalami);

return;
    
void DisplayPizza(IPizza pizza)
{
    var size = pizza.Size;
    var ingredients = string.Join(", ", pizza.Ingredients);
    var price = pizza.CalculatePrice();
    
    Console.WriteLine($"{size} pizza with {ingredients} costs {price}.");
}


