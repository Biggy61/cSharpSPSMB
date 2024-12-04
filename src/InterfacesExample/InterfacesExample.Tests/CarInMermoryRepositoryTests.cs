namespace InterfacesExample.Tests;

public class CarInMermoryRepositoryTests
{
    [Fact]
    public void InsertingNewModel_ShouldIncreaseRecordCount()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        int Before = carInMermoryRepository.RecordCount();
        //Act
        carInMermoryRepository.Insert(car1);
        carInMermoryRepository.Insert(car2);
        int After = carInMermoryRepository.RecordCount();    

        //Asert
        Assert.True(After > Before);
    }

    [Fact]
    public void InsertingNull_ShouldSustainRecordCount()
    {
        //Arrange
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        //Act
        int Before = carInMermoryRepository.RecordCount();    
        carInMermoryRepository.Insert(null);
        int After = carInMermoryRepository.RecordCount();    

        //Asert
        Assert.True(After == Before);
    }

    [Fact]
    public void GettingAllRecords_WithTwoRecords_ShouldReturnListOfTwoRecords()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        //Act
        carInMermoryRepository.Insert(car1);
        carInMermoryRepository.Insert(car2);
        
        //Asert
        Assert.True(carInMermoryRepository.Get().Count == 2);
    }

    [Fact]
    public void GettingInsertedRecordWithId_WithTwoRecords_ShouldReturnInsertedRecord()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        //Act
        carInMermoryRepository.Insert(car1);
        
        //Asert
        Assert.NotNull(carInMermoryRepository.Get(car1.Id));
    }

    [Fact]
    public void GettingNotInsertedRecordWithId_WithTwoRecords_ShouldReturnNull()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarModel car2 = new CarModel("Blud", "Bludbrand");
        CarModel blud = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        //Act
        carInMermoryRepository.Insert(car1);
        carInMermoryRepository.Insert(car2);
        
        //Asert
        Assert.Null(carInMermoryRepository.Get(blud.Id)); 
    }

    [Fact]

    public void UpdateRecordWithId_ShouldReturnRecord()
    {
        //Arrange
        string updateName = "UpdateBlud";
        string updateBrand = "UpdateBlud";
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        carInMermoryRepository.Insert(car1);
        //Act
        CarModel updated = carInMermoryRepository.Get(car1.Id);
        updated.Name = updateName;
        updated.Brand = updateBrand;
        carInMermoryRepository.Update(updated);

        //Asert
        Assert.Equal(updateName, carInMermoryRepository.Get(car1.Id).Name);
        Assert.Equal(updateBrand, carInMermoryRepository.Get(car1.Id).Brand);
    }

    [Fact]

    public void DeleteRecordWithId_ShouldDeleteRecord()
    {
        //Arrange
        CarModel car1 = new CarModel("Blud", "Bludbrand");
        CarInMermoryRepository carInMermoryRepository = new CarInMermoryRepository();
        carInMermoryRepository.Insert(car1);
        //Act
        int carLenghtBefore = carInMermoryRepository.RecordCount();
        carInMermoryRepository.Delete(car1.Id);
        int carLenghtAfter = carInMermoryRepository.RecordCount();

        //Asert
        Assert.True(carLenghtAfter < carLenghtBefore);
    }
 
}