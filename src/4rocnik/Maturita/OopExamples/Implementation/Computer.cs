using OopExamples.Interfaces;
using System.Data;


namespace OopExamples.Implementation;

public class Computer : IComputer
{
    public IEntity Owner { get; init; }
    public IMotherBoard MotherBoard { get; init; }
    public ICPU Cpu { get; init; }
    public IGPU Gpu { get; init; }
    public IRAM Ram { get; init; }
    public IPowerSupply PowerSupply { get; init; }
    public ICase Case { get; init; }
    public IMonitor[] Monitors { get; init; }
    public bool IsOn { get; }
    public bool IsPersonalPC { get; }
    public bool IsCompanyPC { get; }
    public void PowerUp()
    {
        Console.WriteLine("Powering up");
    }

    public void ShutDown()
    {
        Console.WriteLine("Shutting down");
    }

    public void PressPowerButton()
    {
        Console.WriteLine("Power button pressed");
    }

    public void Print(string text)
    {
        Console.WriteLine(text);
    }

    public float Compute(string equation)
    {
        try
        {
            var table = new DataTable();
            var result = table.Compute(equation, string.Empty);
            return (float)Convert.ToDouble(result.ToString());
        }
        catch (Exception ex)
        {
            throw new ArgumentException("Invalid equation format.", ex);
        }
    }

    public IComputer BuildNewComputer(IComputerConfiguration configuration)
    {
        throw new NotImplementedException();
    }
}