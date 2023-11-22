using DesignPatternsInDotnet.Creational.Factory.Enums;
using DesignPatternsInDotnet.Creational.Factory.Factories;

Console.WriteLine("Phone Factory");

var phoneFactory = new PhoneFactory();

var iPhone = phoneFactory.CratePhone(PhoneType.Smartphone, "Apple");
var samsung = phoneFactory.CratePhone(PhoneType.Smartphone, "Samsung");
var sony = phoneFactory.CratePhone(PhoneType.Landline, "Sony");

iPhone.Show();
samsung.Show();
sony.Show();