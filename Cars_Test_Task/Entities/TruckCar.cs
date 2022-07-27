namespace Cars_Test_Task.Entities
{
    /// <summary>
    /// Грузовой автомобиль
    /// </summary>
    public class TruckCar : BaseCar
    {
        // Максимальная грузоподъёмность
        private const int MaxWeight = 4000;
        // Уменьшение запаса хода на каждые килограммы груза
        private const double DecreasePercent = 0.04;
        // Кол-во килограммов, который снижают запас хода
        private const int DecreasePerKg = 200;

        CarType carType = CarType.Truck;

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="avgFuelConsumption">Средний расход топлива</param>
        /// <param name="fuelTankVolume">Объём топливного бака</param>
        /// <param name="speed">Скорость</param>
        /// <param name="carFeatureCount">Грузоподъёмность (по умолчанию = 0)</param>
        public TruckCar(double avgFuelConsumption, double fuelTankVolume, double speed, int carFeatureCount = 0) : base(avgFuelConsumption, fuelTankVolume, speed, carFeatureCount)
        { }

        public override double GetDistanceByCarFeature()
        {
            return CarFeatureCount > MaxWeight
                ? throw new ArgumentException($"Превышена максимальная грузоподъёмность: {MaxWeight} кг.")
                : GetDistanceByFuel() - (GetDistanceByFuel() * (CarFeatureCount / DecreasePerKg * DecreasePercent));
        }
    }
}
