using System.Text;
using DesignPatternsInDotnet.Creational.Builder.Builders;

Console.WriteLine("Computer builder");

var computerBuilder = new ComputerBuilder();

var computer = computerBuilder
    .SetMotherboard("Asus Z999")
    .SetCPU("Intel i9 19990k")
    .SetGraphicCard("GeForce RTX 9090 SUPER TI")
    .SetMemory("GoodRam DDR9 9999MHz CL9 4x96GB")
    .SetStorage("Samsung NVMe 999 PRO 999TB")
    .SetCase("Lian Li O99")
    .SetPSU("Seasonic 9000W Platinum++")
    .Build();

DisplayComputer();
return;
    
void DisplayComputer()
{
    var computerDetails = new StringBuilder()
        .AppendLine("Built computer:")
        .AppendLine($"CPU: {computer.CPU}")
        .AppendLine($"Graphic Card: {computer.GraphicCard}")
        .AppendLine($"Memory: {computer.Memory}")
        .AppendLine($"Storage: {computer.Storage}")
        .AppendLine($"Case: {computer.Case}")
        .AppendLine($"PSU: {computer.PSU}")
        .ToString();
    
    Console.WriteLine(computerDetails);
}