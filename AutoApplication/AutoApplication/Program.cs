using AutoApplication.Models;

List<Car> cars = new List<Car>()
{
    new Car()
    {
        Developer = "Toyota",
        EngineVolume = 2.5,
        Id = 1,
        Model = "Funcargo",
        Year = 2012
    },
    new Car()
    {
        Developer = "Toyota2",
        EngineVolume = 2.5,
        Id = 1,
        Model = "Funcargo2",
        Year = 2012
    },
    new Car()
    {
        Developer = "Mazda",
        EngineVolume = 1.7,
        Id = 2,
        Model = "Demio",
        Year = 2012
    },
    new Car()
    {
        Developer = "Mercedes-Benz",
        EngineVolume = 2.8,
        Id = 3,
        Model = "G-Class",
        Year = 2019
    },
    new Car()
    {
        Developer = "Toyota",
        EngineVolume = 3.5,
        Id = 4,
        Model = "Camry",
        Year = 2017
    },
    new Car()
    {
        Developer = "Nissan",
        EngineVolume = 1.4,
        Id = 5,
        Model = "Note",
        Year = 2015
    },
    new Car()
    {
        Developer = "Honda",
        EngineVolume = 1.5,
        Id = 6,
        Model = "Fit",
        Year = 2020
    }
};
List<CarDriver> carDrivers =new List<CarDriver>()
{
    new CarDriver()
    {
        Age = 27,
        FullName = "Oleg",
        CarIds = new List<int>(){ 1,3}
    },
    new CarDriver()
    {
        Age = 50,
        FullName = "Misha",
        CarIds = new List<int>(){ 2,4, 1}
    },
    new CarDriver()
    {
        Age = 27,
        FullName = "Andrew",
        CarIds = new List<int>(){ 3, 6 }
    },
    new CarDriver()
    {
        Age = 27,
        FullName = "Maria",
        CarIds = new List<int>(){ 1,2, 3}
    },
};
//carDrivers.Clear();
//carDrivers.Add(new CarDriver()
//{
//    Age = 27,
//    FullName = "Maria",
//    CarIds = new List<int>() { 22, 12, 33 }
//});
PrintTable(cars, carDrivers);

static void PrintTable(List<Car> cars, List<CarDriver> carDrivers)
{
    var peopleNCarGrouping = (from driver in carDrivers
                              from cardId in driver.CarIds
                              join car in cars on cardId equals car.Id into carNDriver
                              select new
                              {
                                  Fullname = driver.FullName,
                                  Cars = carNDriver.Select(x => $"{x.Model} =-= {x.Developer} =-= {x.Year} =-= {x.EngineVolume}")
                              }).ToList();


    var peopleNCarGrouping2 = (from driver in carDrivers
                              from cardId in driver.CarIds
                              join car in cars on cardId equals car.Id
                              select new
                              {
                                  Fullname = driver.FullName,
                                  Car = car
                              }).ToList();

    var som = from driver in carDrivers.SelectMany(x=>x.CarIds)
              select driver;

    var rep = (from driver in carDrivers
               from cardId in driver.CarIds
               join car in cars on cardId equals car.Id
               select new
               {
                   Driver = driver.FullName,
                   CarId = car.Id,
                   CarName = car.Model,
                   Year = car.Year,
                   EngineVolume = car.EngineVolume,
                   Car = $"{car.Model} =-= {car.Developer} =-= {car.Year} =-= {car.EngineVolume}"
               }).GroupBy(x => x.Driver);

    foreach (var personAndCars in rep)
    {
        Console.WriteLine(personAndCars.Key);
        foreach (var item in personAndCars)
        {
            Console.WriteLine(item.Car);
        }
        Console.WriteLine();
    }
}


