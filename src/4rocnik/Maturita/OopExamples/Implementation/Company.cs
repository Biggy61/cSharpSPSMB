using OopExamples.Interfaces;

namespace OopExamples.Implementation;

public class Company : ICompany
{
    public IPerson Owner { get; set; }
    public string Name { get; set; }
}