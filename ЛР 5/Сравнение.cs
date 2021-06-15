using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сделано Новиковым Никитой

namespace Система
{
    public partial class Сравнение : Form
    {
        // Функция перевода выбранной величины с массивом мер в качестве передаваемого параметра (в соотвествии с величиной, в которую происходит перевод)
        private void Trans(double[] arr)
        {
            switch (Measure2.SelectedIndex)
            {
                case 0:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[0]);
                        break;
                    }
                case 1:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[1]);
                        break;
                    }
                case 2:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[2]);
                        break;
                    }
                case 3:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[3]);
                        break;
                    }
                case 4:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[4]);
                        break;
                    }
                case 5:
                    {
                        Num2.Text = Convert.ToString(Convert.ToDouble(Num1.Text) * arr[5]);
                        break;
                    }
            }
        }
        public Сравнение()
        {
            InitializeComponent();
            Translate.Enabled = true;
        }
        // Обработка нажатия кнопки "Перевести"
        private void Translate_Click(object sender, System.EventArgs e)
        {
            // Проверка наличия переводимой величины
            if (Num1.Text == "")
            {
                MessageBox.Show("Укажите величину");
                return;
            }
            // Передача массива мер в функцию перевода в соответствии с выбранной величиной, из которой происходит перевод
            switch (Measure1.SelectedIndex)
            {
                case 0:
                    {
                        double[] arr = new double[] { 1, 39.37, 0.00094, 0.47, 1.41, 3.28 };
                        Trans(arr);
                        break;
                    }
                case 1:
                    {
                        double[] arr = new double[] { 0.025, 1, 0.000024, 0.012, 0.036, 0.083 };
                        Trans(arr);
                        break;
                    }
                case 2:
                    {
                        double[] arr = new double[] { 1066.8, 42000, 1, 500, 1500, 3500 };
                        Trans(arr);
                        break;
                    }
                case 3:
                    {
                        double[] arr = new double[] { 2.13, 84, 0.02, 1, 3, 7 };
                        Trans(arr);
                        break;
                    }
                case 4:
                    {
                        double[] arr = new double[] { 28, 0.71, 0.00067, 0.33, 1, 2.33 };
                        Trans(arr);
                        break;
                    }
                case 5:
                    {
                        double[] arr = new double[] { 0.3, 12, 0.00029, 0.14, 0.43, 1 };
                        Trans(arr);
                        break;
                    }
            }
        }
        // Обработка нажатия кнопки "Закрыть" (сокрытые текущей формы (сравнительного модуля) и возврат к учётному модулю)
        private void Close_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }
    }
}
