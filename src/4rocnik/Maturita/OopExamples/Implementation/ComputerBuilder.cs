using OopExamples.Interfaces;

namespace OopExamples.Implementation;

public class ComputerBuilder : IComputerBuilder
{
    private IComputerConfiguration _config;
    public IComputer BuildFromConfiguration(IComputerConfiguration configuration)
    {
        throw new NotImplementedException();
    }

    public IComputerBuilder AddMotherBoard(IMotherBoard motherBoard)
    {
        _config.MotherBoard =  motherBoard;
        return this;
    }

    public IComputerBuilder AddCPU(ICPU cpu)
    {
        _config.Cpu =  cpu;
        return this;
    }

    public IComputerBuilder AddGPU(IGPU gpu)
    {
        _config.Gpu =  gpu;
        return this;
    }

    public IComputerBuilder AddRam(IRAM ram)
    {
        _config.Ram =  ram;
        return this;
    }

    public IComputerBuilder AddPowerSupply(IPowerSupply powerSupply)
    {
        _config.PowerSupply =  powerSupply;
        return this;
    }

    public IComputerBuilder AddCase(ICase pcCase)
    {
        _config.Case =  pcCase;
        return this;
    }

    public IComputer Build()
    {
        return new Computer(_config.MotherBoard, _config.Cpu, _config.Gpu, _config.Ram, _config.PowerSupply, _config.Case);
    }
}