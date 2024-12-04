using System.Text;

namespace InterfacesExample;

public class CarCsvFileRepository : ICarRepository
{
    public CarModel Get(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<CarModel> Get()
    {
        string path = @"data.csv";
        string[] cars = new string[5];
        List<CarModel> Cars = new List<CarModel>();
            var lines = File.ReadLines(path);

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                line.Split(",");
                
            }

        return Cars;
    }

    public void Insert(CarModel model)
    {
        string myInputLine = model.ToString();
        string fileSpecification = "data.csv";
        using (StreamWriter filewriter = new StreamWriter(fileSpecification, true, System.Text.Encoding.UTF8))
        {
            filewriter.WriteLine(myInputLine);
        }
    }

    public void Update(CarModel model)
    {
        throw new NotImplementedException();
    }

    public void Delete(Guid Id)
    {
        throw new NotImplementedException();
    }

    public int RecordCount()
    {
        throw new NotImplementedException();
    }
}