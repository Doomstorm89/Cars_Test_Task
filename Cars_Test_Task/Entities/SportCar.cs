namespace Cars_Test_Task.Entities
{
    /// <summary>
    /// Спортивный автомобиль
    /// </summary>
    public class SportCar : BaseCar
    {
        CarType carType = CarType.Sport;

        // TODO: реализовать логику особенности спортивного автомобиля
        public override double GetDistanceByCarFeature()
        {
            throw new NotImplementedException();
        }
    }
}
