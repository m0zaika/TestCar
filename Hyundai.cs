namespace TestCar
{
    class Hyundai : Car
    {
        /// <summary>
        /// Конструктор для автомобилей марки Hyundai
        /// </summary>
        /// <param name="vin"></param>
        /// <param name="critVal"></param>
        public Hyundai(string vin, int critVal) : base(vin)
        {
            CriticalValue = critVal;
        }

        public override string ToString()
        {
            return $@"HYUNDAI VIN:{VIN}";
        }
    }
}
