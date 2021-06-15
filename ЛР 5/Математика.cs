using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сделано Кадровой Екатериной

namespace Система
{
    public partial class Математика : Form
    {
        // Опредление кубического уравнения как начального
        public Математика()
        {
            InitializeComponent();
            Eq1.Checked = true;
        }
        // Проявление 3 коэффициента и корня при выборе кубического уравнения
        private void Eq1_Click(object sender, EventArgs e)
        {
            X3.Visible = true;
            X_3.Visible = true;
            D.Visible = true;
            K3.Visible = true;
        }
        // Сокрытие 3 коэффициента и корня при выборе квадратного уравнения
        private void Eq2_Click(object sender, EventArgs e)
        {
            X3.Visible = false;
            X_3.Visible = false;
            D.Visible = false;
            K3.Visible = false;
        }
        // Обработка нажатия кнопки "Добавить"
        private void OK_Click(object sender, EventArgs e)
        {
            // Кубическое уравнение
            if (Eq1.Checked == true)
            {
                // Проверка заполнения всех текстовых полей
                if (B.Text == "" || C.Text == "" || D.Text == "")
                {
                    MessageBox.Show("Введиете все данные");
                    return;
                }
                // Вывод уравнения
                Equation.Text = "x^3+" + B.Text + "x^2+" + C.Text + "x+" + D.Text + "=0";
                double x1, x2, x3;
                // Подбор корней и их дальнейшая проверка на основе системы уравнений теоремы Виета для кубического уравнения
                for (x1 = -100; x1 <= 100; x1++)
                {
                    for (x2 = -100; x2 <= 100; x2++)
                    {
                        for (x3 = -100; x3 <= 100; x3++)
                        {
                            if ((x1 + x2 + x3) == -Convert.ToInt32(B.Text))
                            {
                                if ((x1 * x2 + x1 * x3 + x2 * x3) == Convert.ToInt32(C.Text))
                                {
                                    if ((x1 * x2 * x3) == -Convert.ToInt32(D.Text))
                                    {
                                        // Вывод подходящих корней
                                        X1.Text = Convert.ToString(x1);
                                        X2.Text = Convert.ToString(x2);
                                        X3.Text = Convert.ToString(x3);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            // Квадратное уравнение
            if (Eq2.Checked == true)
            {
                // Проверка заполнения всех текстовых полей
                if (B.Text == "" || C.Text == "")
                {
                    MessageBox.Show("Введиете все данные");
                    return;
                }
                // Вывод уравнения
                Equation.Text = "x^2+" + B.Text + "x+" + C.Text + "=0";
                double x1, x2;
                // Подбор корней и их дальнейшая проверка на основе системы уравнений теоремы Виета для квадратного уравнения
                for (x1 = -100; x1 <= 100; x1++)
                {
                    for (x2 = -100; x2 <= 100; x2++)
                    {
                        if ((x1 * x2) == Convert.ToInt32(C.Text))
                        {
                            if ((x1 + x2) == -Convert.ToInt32(B.Text))
                            {
                                // Вывод подходящих корней
                                X1.Text = Convert.ToString(x1);
                                X2.Text = Convert.ToString(x2);
                            }
                        }
                    }
                }
            }
            // Обнуление текстовых полей
            B.Text = "";
            C.Text = "";
            D.Text = "";
            // Увелечение на 1 глобального параметра, показывающего количество записей
            Global.Equations++;
        }
        // Обработка нажатия кнопки "Закрыть" (сокрытые текущей формы (справочного модуля) и возврат к учётному модулю)
        private void Close_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }
    }
}
