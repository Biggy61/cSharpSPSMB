namespace InterfacesExample;

public class CarRepository : IRespository<CarModel>
{
    public List<CarModel> Cars = new List<CarModel>();
    public CarModel? Get(Guid Id)
    {
        throw new NotImplementedException();
    }

    public List<CarModel> Get()
    {
        throw new NotImplementedException();
    }

    public void Insert(CarModel model)
    {
        if (model != null) { Cars.Add(model); }
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
        return Cars.Count();
    }
}