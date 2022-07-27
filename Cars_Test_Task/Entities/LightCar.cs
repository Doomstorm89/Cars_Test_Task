namespace Cars_Test_Task.Entities
{
    /// <summary>
    /// Легковой автомобиль
    /// </summary>
    public class LightCar : BaseCar
    {
        // Максимальное кол-во пассажиров
        private const int MaxPassengers = 4;
        // Снижение запаса хода на одного пассажира
        private const double DecreasePercent = 0.06;

        private CarType carType = CarType.Light;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="avgFuelConsumption">Средний расход топлива</param>
        /// <param name="fuelTankVolume">Объём топливного бака</param>
        /// <param name="speed">Скорость</param>
        /// <param name="carFeatureCount">Кол-во пассажиров (по умолчанию = 0)</param>
        public LightCar(double avgFuelConsumption, double fuelTankVolume, double speed, int carFeatureCount = 0) : base(avgFuelConsumption, fuelTankVolume, speed, carFeatureCount)
        { }

        public override double GetDistanceByCarFeature()
        {
            return CarFeatureCount > MaxPassengers
                ? throw new ArgumentException($"Превышено максимальное кол-во пассажиров: {MaxPassengers}")
                : GetDistanceByFuel() - (GetDistanceByFuel() * (CarFeatureCount * DecreasePercent));
        }
    }
}
