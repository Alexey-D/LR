using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сделано Денисовым Алексеем

namespace Система
{
    public partial class Учёт : Form
    {
        // Объявление дополнительных форм (иначе говоря, модулей)
        Математика f1 = new Математика();
        Справочник f2 = new Справочник();
        Сравнение f3 = new Сравнение();
        // Опредление начальных записей в таблице
        public Учёт()
        {
            InitializeComponent();
            Equations.Text = Convert.ToString(Global.Equations);
            Records.Text = Convert.ToString(Global.Records);
            CU.Text = "6";
        }
        // Обработка нажатия кнопки "Математический" (открытие математического модуля и сокрытие учётного)
        private void Math_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            f1.Show();
        }
        // Обработка нажатия кнопки "Математический" (открытие справочного модуля и сокрытие учётного)
        private void Book_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            f2.Show();
        }
        // Обработка нажатия кнопки "Математический" (открытие сравнительного модуля и сокрытие учётного)
        private void Compare_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            f3.Show();
        }
        // Обработка нажатия кнопки "Обновить" (обновление статистических полей)
        private void Update_Click(object sender, System.EventArgs e)
        {
            Equations.Text = Convert.ToString(Global.Equations);
            Records.Text = Convert.ToString(Global.Records);
        }
        // Обработка нажатия кнопки "Выход"
        private void Exit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
    }
}


