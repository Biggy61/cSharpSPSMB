using InterfacesExample;

// IModel model;

// model = new CarModel("superb", "skoda");
// model = new RocketModel("superb", 161);

CarModel car1 = new CarModel("Blud", "Bludbrand");
CarModel car2 = new CarModel("Blud", "Bludbrand");
CarCsvFileRepository carCsvFileRepository = new CarCsvFileRepository();
carCsvFileRepository.Insert(car1);
carCsvFileRepository.Insert(car2);
carCsvFileRepository.Get();

// RocketModel myRocket;
// myRocket = model as RocketModel;
// myRocket = (RocketModel) model;
// // Identicke oprace
//
//
// // Console.WriteLine(model.Describe());
//
//
// if (model is CarModel car)
// {
//     Console.WriteLine(car.Brand);
//     Console.WriteLine("Model is a car!");
// }
// else if (model is RocketModel rocket)
// {
//     Console.WriteLine(rocket.Power);
//     Console.WriteLine("Model is a rocket!");
// }
