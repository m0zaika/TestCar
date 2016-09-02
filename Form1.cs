using System;
using System.Text;
using System.Windows.Forms;

namespace TestCar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //создание небольшого списка машин разных марок
            Car car = new Toyota("1234", 900); 
            car.Price = 2000;
            lbCars.Items.Add(car);
            car = new Toyota("4321", 900);
            car.Price = 3000;
            lbCars.Items.Add(car);
            car = new Hyundai("3412", 1100);
            car.Price = 1500;
            lbCars.Items.Add(car);
        }

        /// <summary>
        /// Добавление опций
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOption_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedItem != null && !string.IsNullOrEmpty(tbOptionName.Text))
            {
                var pr = Convert.ToDouble(numOptionPrice.Value);
                var tempCar = (Car)lbCars.SelectedItem;
                tempCar.Options.Add(new Option(tbOptionName.Text, pr));
                tbOptionName.Text = string.Empty;
                numOptionPrice.Value = 0;
            }
        }
        
        /// <summary>
        /// Имитация поездки на 1000
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRun_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 1000; i++)
            {
                foreach(var item in lbCars.Items)
                {
                    ((Car)item).Run();
                }
            }
        }

        /// <summary>
        /// Вывод отчета на выбранную машину
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReport_Click(object sender, EventArgs e)
        {
            if (lbCars.SelectedItem != null)
            {
                var tempCar = (Car)lbCars.SelectedItem;
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(string.Format(@"Автомобиль Марки: {0}", tempCar.GetType().Name));
                sb.AppendLine($@"Цена: {tempCar.Price}");
                if (tempCar.Options.Count != 0)
                    sb.AppendLine("Дополнительные опции:");
                else
                    sb.AppendLine("Дополнительных опций нет");
                foreach (var item in tempCar.Options)
                {
                    sb.AppendLine($@"{item.Name} - {item.Price}");
                }
                sb.AppendLine($@"Итого: {tempCar.GetAmount()}");

                MessageBox.Show(sb.ToString(), "ИТОГ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
