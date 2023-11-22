using DesignPatternsInDotnet.Creational.Factory.Enums;
using DesignPatternsInDotnet.Creational.Factory.Models;

namespace DesignPatternsInDotnet.Creational.Factory.Factories;

public class PhoneFactory
{
    public Phone CratePhone(PhoneType type, string brand)
    {
        return type switch
        {
            PhoneType.Smartphone => new Smartphone(brand),
            PhoneType.Landline => new Landline(brand),
            _ => throw new Exception($"Not handled '{type}' phone type.")
        };
    }
        
}