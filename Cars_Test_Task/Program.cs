using Cars_Test_Task.Entities;

#region Легковой автомобиль

// Легковой автомобиль (ср. расход топлива, объём бака, скорость, кол-во пассажиров)
var lightCar = new LightCar(5, 50, 50, 4);

// Расстояние по кол-ву топлива
Console.WriteLine(lightCar.GetDistanceByFuel());

// Расстояние с учётом пассажиров 
Console.WriteLine(lightCar.GetDistanceByCarFeature());

// Время в часах по расстоянию
Console.WriteLine(lightCar.GetTimeByDistanceAndFuel(111));

#endregion

#region Грузовой автомобиль

// Грузовой автомобиль (ср. расход топлива, объём бака, скорость, кол-во груза)
var truckCar = new TruckCar(5, 50, 50, 4000);

// Расстояние по кол-ву топлива
Console.WriteLine(truckCar.GetDistanceByFuel());

// Расстояние с учётом груза 
Console.WriteLine(truckCar.GetDistanceByCarFeature());

// Время в часах по расстоянию
Console.WriteLine(truckCar.GetTimeByDistanceAndFuel(111));

#endregion

