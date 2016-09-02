using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace TestCar
{
    class Car
    {
        /// <summary>
        /// Список доп. опций
        /// </summary>
        public List<Option> Options = new List<Option>();

        /// <summary>
        /// Значение ТребуетсяТО
        /// </summary>
        public int CriticalValue;
        public delegate void MethodContainer();
        public event MethodContainer RequiredTO;

        /// <summary>
        /// Поле стоимости автомобиля
        /// </summary>
        private double _price;

        /// <summary>
        /// Свойство стоимости автомобиля
        /// </summary>
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        /// <summary>
        /// Поле пробега автомобиля
        /// </summary>
        private int _machineRunning;

        /// <summary>
        /// Свойство пробега автомобиля
        /// </summary>
        public int MachineRunning
        {
            get { return _machineRunning; }
            set
            {
                _machineRunning = value;
                if (_machineRunning == CriticalValue)
                {
                    if (RequiredTO != null)
                        RequiredTO();
                }
            }
        }

        /// <summary>
        /// Неизменное поле VIN
        /// </summary>
        public readonly string VIN;
         
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="vin"></param>
        public Car(string vin)
        {
            VIN = vin;
            RequiredTO += TO;
        }

        /// <summary>
        /// Метод вывода информации о ТО. Так как в задание не совсем понятно как конкретно должно вызываться исключение,
        /// я просто вывожу MessageBox в другом потоке, чтобы не стопорить основной
        /// </summary>
        public void TO()
        {
            ThreadPool.QueueUserWorkItem(o =>{ Mess(); });
        }

        public virtual void Mess()
        {
            MessageBox.Show("Требуется ТО!", VIN, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// Метод имитации поездки
        /// </summary>
        public void Run()
        {
            MachineRunning++;
        }

        /// <summary>
        /// Метод получения общей стоимости
        /// </summary>
        /// <returns></returns>
        public double GetAmount()
        {
            double amount = Price;
            foreach(var item in Options)
            {
                amount += item.Price;
            }
            return amount;
        }
    }

    class Option
    {
        /// <summary>
        /// Название опции
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Цена
        /// </summary>
        public readonly double Price;

        public Option(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
    }
}
