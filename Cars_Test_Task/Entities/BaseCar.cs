using Cars_Test_Task.Interfaces;

namespace Cars_Test_Task.Entities
{
    public abstract class BaseCar
    {
        /// <summary>
        /// Типы автомобилей
        /// </summary>
        public enum CarType
        {
            /// <summary>
            /// Легковой
            /// </summary>
            Light,

            /// <summary>
            /// Грузовой
            /// </summary>
            Truck,

            /// <summary>
            /// Спортивный
            /// </summary>
            Sport
        }

        /// <summary>
        /// Тип автомобиля
        /// </summary>
        public CarType Type { get; }

        /// <summary>
        /// Средний расход топлива
        /// </summary>
        public double AvgFuelConsumption { get; set; }

        /// <summary>
        /// Объём топливного бака
        /// </summary>
        public double FuelTankVolume { get; set; }

        /// <summary>
        /// Скорость, км/ч
        /// </summary>
        public double Speed { get; set; }

        /// <summary>
        /// Особенность автомобиля, кол-во
        /// </summary>
        public int CarFeatureCount { get; set; }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public BaseCar() { }

        /// <summary>
        /// Конструктор с параметрами
        /// </summary>
        /// <param name="avgFuelConsumption">Средний расход топлива</param>
        /// <param name="fuelTankVolume">Объём топливного бака</param>
        /// <param name="speed">Скорость</param>
        /// <param name="carFeatureCount">Особенность автомобиля, кол-во (по умолчанию = 0)</param>
        public BaseCar(double avgFuelConsumption, double fuelTankVolume, double speed, int carFeatureCount = 0)
        {
            AvgFuelConsumption = avgFuelConsumption;
            FuelTankVolume = fuelTankVolume;
            Speed = speed;
            CarFeatureCount = carFeatureCount;
        }

        /// <summary>
        /// Тип автомобиля
        /// </summary>
        /// <returns>Тип</returns>
        public string GetCarType()
        {
            return Type switch
            {
                CarType.Light => Constants.CarTypes.LightCarType,
                CarType.Truck => Constants.CarTypes.TruckCarType,
                CarType.Sport => Constants.CarTypes.SportCarType,
                _ => "Неизвестный"
            };
        }

        /// <summary>
        /// Сколько км автомобиль может проехать на текущем кол-ве топлива
        /// </summary>
        /// <returns>Расстояние в километрах</returns>
        public virtual double GetDistanceByFuel()
        {
            return FuelTankVolume * AvgFuelConsumption;
        }

        /// <summary>
        /// Сколько км автомобиль может проехать при его текущих особенностях
        /// </summary>
        /// <returns>Расстояние в километрах</returns>
        public abstract double GetDistanceByCarFeature();

        /// <summary>
        /// За какое время (в часах) автомобиль преодолеет указанное расстояние при текущем топливе
        /// </summary>
        /// <returns>Время в часах</returns>
        public virtual TimeSpan GetTimeByDistanceAndFuel(double distanceInKilometers)
        {
            var distanceByFuel = GetDistanceByFuel();
            return distanceByFuel < distanceInKilometers
                ? TimeSpan.Zero
                : TimeSpan.FromHours(distanceInKilometers / Speed);
        }
    }
}
