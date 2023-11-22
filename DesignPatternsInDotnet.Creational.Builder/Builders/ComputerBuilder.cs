using DesignPatternsInDotnet.Creational.Builder.Models;

namespace DesignPatternsInDotnet.Creational.Builder.Builders;

public class ComputerBuilder
{
    private readonly Computer _computer = new();

    public Computer Build()
    {
        return _computer;
    }

    public ComputerBuilder SetMotherboard(string motherboard)
    {
        _computer.Motherboard = motherboard;
        return this;
    }

    public ComputerBuilder SetCPU(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }

    public ComputerBuilder SetGraphicCard(string graphicCard)
    {
        _computer.GraphicCard = graphicCard;
        return this;
    }

    public ComputerBuilder SetMemory(string memory)
    {
        _computer.Memory = memory;
        return this;
    }

    public ComputerBuilder SetStorage(string storage)
    {
        _computer.Storage = storage;
        return this;
    }

    public ComputerBuilder SetCase(string computerCase)
    {
        _computer.Case = computerCase;
        return this;
    }

    public ComputerBuilder SetPSU(string psu)
    {
        _computer.PSU = psu;
        return this;
    }
}