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
        
    }

    [Fact]
    public void GettingInsertedRecordWithId_WithTwoRecords_ShouldReturnInsertedRecord()
    {
        
    }

    [Fact]
    public void GettingNotInsertedRecordWithId_WithTwoRecords_ShouldReturnNull()
    {
        
    }
}