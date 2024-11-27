namespace InterfacesExample;

public class CarRepository : ICarRepository
{
    public List<CarModel> Cars = new List<CarModel>();
    public CarModel? Get(Guid Id)
    {
        foreach (var c in Cars)
        {
            if (c.Id == Id)
            {
                return c;
            }
            
        } 
        //var car = Cars.Single(car => car.Id == Id);
        return null;
    }

    public List<CarModel> Get()
    {
        return Cars;
    }

    public void Insert(CarModel model)
    {
        if (model != null) { Cars.Add(model); }
    }

    public void Update(CarModel model)
    {
        var car = Cars.Single(car => car.Id == model.Id);
        car.Name = model.Name;
        car.Brand = model.Brand;
    }

    public void Delete(Guid Id)
    {
        Cars.Remove(Get(Id));
    }

    public int RecordCount()
    {
        return Cars.Count();
    }
}