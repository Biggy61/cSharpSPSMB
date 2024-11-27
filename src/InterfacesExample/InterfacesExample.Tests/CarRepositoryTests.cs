namespace InterfacesExample.Tests;

public class CarRepositoryTests
{
    [Fact]
    public void InsertingNewModel_ShouldIncreaseRecordCount()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarRepository carRepository = new CarRepository();
        int Before = carRepository.RecordCount();
        //Act
        carRepository.Insert(car1);
        carRepository.Insert(car2);
        int After = carRepository.RecordCount();    

        //Asert
        Assert.True(After > Before);
    }

    [Fact]
    public void InsertingNull_ShouldSustainRecordCount()
    {
        //Arrange
        CarRepository carRepository = new CarRepository();
        //Act
        int Before = carRepository.RecordCount();    
        carRepository.Insert(null);
        int After = carRepository.RecordCount();    

        //Asert
        Assert.True(After == Before);
    }

    [Fact]
    public void GettingAllRecords_WithTwoRecords_ShouldReturnListOfTwoRecords()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarRepository carRepository = new CarRepository();
        //Act
        carRepository.Insert(car1);
        carRepository.Insert(car2);
        
        //Asert
        Assert.True(carRepository.Get().Count == 2);
    }

    [Fact]
    public void GettingInsertedRecordWithId_WithTwoRecords_ShouldReturnInsertedRecord()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarRepository carRepository = new CarRepository();
        //Act
        carRepository.Insert(car1);
        
        //Asert
        Assert.NotNull(carRepository.Get(car1.Id));
    }

    [Fact]
    public void GettingNotInsertedRecordWithId_WithTwoRecords_ShouldReturnNull()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarModel blud = new CarModel("Blud", "Bludbrand");
        CarRepository carRepository = new CarRepository();
        //Act
        carRepository.Insert(car1);
        carRepository.Insert(car2);
        
        //Asert
        Assert.Null(carRepository.Get(blud.Id)); 
    }

    [Fact]

    public void UpdateRecordWithId_ShouldReturnRecord()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarRepository carRepository = new CarRepository();
        //Act
        carRepository.Insert(car1);
        carRepository.Update(car1);
        //Asert
       Assert
    }

    [Fact]

    public void DeleteRecordWithId_ShouldDeleteRecord()
    {
        
    }
 
}