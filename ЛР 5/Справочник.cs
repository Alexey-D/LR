using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Сделано Синьковым Денисом

namespace Система
{
    public partial class Справочник : Form
    {
        // Опредление начальных записей в таблице
        public Справочник()
        {
            InitializeComponent();
            Table.Rows.Add("Базы данных", "05.06.2020", "4");
            Table.Rows.Add("Информационная безопасность", "11.06.2020 ", "5");
            Table.Rows.Add("Методы и модели анализа данных", "15.06.2020", "3");
            Table.Rows.Add("Проектирование информационных систем", "27.06.2020", "4");
        }
        // Обработка нажатия кнопки "Добавить"
        private void Add_Click(object sender, System.EventArgs e)
        {
            // Проверка заполнения всех текстовых полей допустимыми значениями (относительно оценки и года)
            if (Learn.Text != "" && Date.MaskCompleted == true && Mark.Text != "" && Convert.ToInt32(Mark.Text) > 1 && Convert.ToInt32(Mark.Text) < 6)
            {
                // Добавление записи в таблицу
                Table.Rows.Add(Learn.Text, Date.Text, Mark.Text);
                // Обнуление текстовых полей
                Learn.Text = "";
                Date.Text = "";
                Mark.Text = "";
                // Увелечение на 1 глобального параметра, показывающего количество записей
                Global.Records++;
            }
            else
                MessageBox.Show("Введите все данные корректно");
        }
        // Обработка нажатия кнопки "Удалить"
        private void Delete_Click(object sender, EventArgs e)
        {
            // Проверка наличия хотя бы 1 записи
            if (Table.RowCount > 0)
            {
                // Удаление текущей записи
                Table.Rows.Remove(Table.Rows[Table.CurrentRow.Index]);
                // Уменьшение на 1 глобального параметра, показывающего количество записей
                Global.Records--;
            }
        }
        // Обработка нажатия кнопки "Закрыть" (сокрытые текущей формы (справочного модуля) и возврат к учётному модулю)
        private void Close_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            Application.OpenForms[0].Show();
        }
    }
}
