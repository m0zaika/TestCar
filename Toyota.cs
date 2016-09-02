using System.Windows.Forms;

namespace TestCar
{
    class Toyota : Car
    {
        /// <summary>
        /// Конструктор для автомобилей марки Toyota, согласно пункту 3 задания добавлена возможность сразу указать критическое значение пройденного пути
        /// </summary>
        /// <param name="vin"></param>
        /// <param name="critVal"></param>
        public Toyota(string vin, int critVal) : base(vin)
        {
            CriticalValue = critVal;
        }

        /// <summary>
        /// Задание №4
        /// </summary>
        public override void Mess()
        {
            MessageBox.Show("Ошибка АМ", VIN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public override string ToString()
        {
            return $@"TOYOTA VIN:{VIN}";
        }
    }
}
