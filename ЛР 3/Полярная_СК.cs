using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Полярная_СК
{
    public partial class  Полярная_СК : Form
    {
        // Опредление начальных значений некоторых элементов (истинность селекторов "+" и "sin") 
        public Полярная_СК()
        {
            InitializeComponent();
            Plus.Checked = true;
            Sin.Checked = true;
        }
        // Обработка уравнения
        public void Ok_Click(object sender, EventArgs e)
        {
            Chart.Series[0].Points.Clear(); // Очистка графика
            double x, y, res;
            int p, num1, num2;
            // Цикл для обработки каждого возможного угла
            for (int angle = 0; angle <= 360; angle++)
            {
                p = Int32.Parse(P.Text); // Общий множитель
                num1 = Int32.Parse(Num1.Text); // Число, из которого отнимают или к которому прибавляют
                num2 = Int32.Parse(Num2.Text); // Множитель угла
                // Проверка селекторов "sin" и "cos"
                if (Sin.Checked)
                {
                    // Проверка селекторов "+" и "-"
                    if (Plus.Checked)
                        res = p * (num1 + Math.Sin(num2 * angle)); // Резултат уравнения
                    else
                        res = p * (num1 - Math.Sin(num2 * angle));
                }
                else
                {
                    if (Plus.Checked)
                        res = p * (num1 + Math.Cos(num2 * angle));
                    else
                        res = p * (num1 - Math.Cos(num2 * angle));
                }
                // Перевод в декартову систему (x и y)
                x = res * Math.Cos(angle);
                y = res * Math.Sin(angle);
                Chart.Series[0].Points.AddXY(x, y); // Добавление точек на график
            }
        }
    }
}
