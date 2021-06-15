
namespace Задание_4
{
    partial class Таблица
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.TextBox();
            this.Section = new System.Windows.Forms.TextBox();
            this.Description = new System.Windows.Forms.TextBox();
            this.Date = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add = new System.Windows.Forms.Button();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Filter = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.GroupBox();
            this.Q4 = new System.Windows.Forms.RadioButton();
            this.Q3 = new System.Windows.Forms.RadioButton();
            this.Q2 = new System.Windows.Forms.RadioButton();
            this.Q1 = new System.Windows.Forms.RadioButton();
            this.Ok = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.GroupBox();
            this.T_Y = new System.Windows.Forms.RadioButton();
            this.T_D = new System.Windows.Forms.RadioButton();
            this.Year = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.Group.SuspendLayout();
            this.Type.SuspendLayout();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(140, 49);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(160, 20);
            this.Title.TabIndex = 0;
            // 
            // Section
            // 
            this.Section.Location = new System.Drawing.Point(140, 100);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(160, 20);
            this.Section.TabIndex = 1;
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(140, 150);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(160, 40);
            this.Description.TabIndex = 2;
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(240, 239);
            this.Date.Mask = "00/00/0000";
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(60, 20);
            this.Date.TabIndex = 3;
            this.Date.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Раздел науки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Описание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата открытия";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add.Location = new System.Drawing.Point(661, 49);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(113, 29);
            this.Add.TabIndex = 10;
            this.Add.Text = "Добавить";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Table
            // 
            this.Table.AllowUserToAddRows = false;
            this.Table.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.Table.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Table.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.Table.GridColor = System.Drawing.SystemColors.Desktop;
            this.Table.Location = new System.Drawing.Point(22, 347);
            this.Table.Name = "Table";
            this.Table.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Table.Size = new System.Drawing.Size(752, 238);
            this.Table.TabIndex = 11;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Раздел науки";
            this.Column2.Name = "Column2";
            this.Column2.Width = 140;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Описание";
            this.Column3.Name = "Column3";
            this.Column3.Width = 330;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата";
            this.Column4.Name = "Column4";
            // 
            // Filter
            // 
            this.Filter.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Filter.Location = new System.Drawing.Point(661, 99);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(113, 29);
            this.Filter.TabIndex = 12;
            this.Filter.Text = "Фильтр";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // Group
            // 
            this.Group.BackColor = System.Drawing.Color.Transparent;
            this.Group.Controls.Add(this.Q4);
            this.Group.Controls.Add(this.Q3);
            this.Group.Controls.Add(this.Q2);
            this.Group.Controls.Add(this.Q1);
            this.Group.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group.ForeColor = System.Drawing.Color.White;
            this.Group.Location = new System.Drawing.Point(646, 150);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(128, 143);
            this.Group.TabIndex = 14;
            this.Group.TabStop = false;
            this.Group.Text = "Фильтр";
            this.Group.Visible = false;
            // 
            // Q4
            // 
            this.Q4.AutoSize = true;
            this.Q4.Location = new System.Drawing.Point(15, 112);
            this.Q4.Name = "Q4";
            this.Q4.Size = new System.Drawing.Size(98, 23);
            this.Q4.TabIndex = 16;
            this.Q4.TabStop = true;
            this.Q4.Text = "4 четверть";
            this.Q4.UseVisualStyleBackColor = true;
            // 
            // Q3
            // 
            this.Q3.AutoSize = true;
            this.Q3.Location = new System.Drawing.Point(15, 83);
            this.Q3.Name = "Q3";
            this.Q3.Size = new System.Drawing.Size(98, 23);
            this.Q3.TabIndex = 16;
            this.Q3.TabStop = true;
            this.Q3.Text = "3 четверть";
            this.Q3.UseVisualStyleBackColor = true;
            // 
            // Q2
            // 
            this.Q2.AutoSize = true;
            this.Q2.Location = new System.Drawing.Point(15, 54);
            this.Q2.Name = "Q2";
            this.Q2.Size = new System.Drawing.Size(98, 23);
            this.Q2.TabIndex = 16;
            this.Q2.TabStop = true;
            this.Q2.Text = "2 четверть";
            this.Q2.UseVisualStyleBackColor = true;
            // 
            // Q1
            // 
            this.Q1.AutoSize = true;
            this.Q1.Location = new System.Drawing.Point(15, 25);
            this.Q1.Name = "Q1";
            this.Q1.Size = new System.Drawing.Size(98, 23);
            this.Q1.TabIndex = 15;
            this.Q1.TabStop = true;
            this.Q1.Text = "1 четверть";
            this.Q1.UseVisualStyleBackColor = true;
            // 
            // Ok
            // 
            this.Ok.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Ok.Location = new System.Drawing.Point(715, 299);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(59, 23);
            this.Ok.TabIndex = 15;
            this.Ok.Text = "Ок";
            this.Ok.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Visible = false;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Type
            // 
            this.Type.BackColor = System.Drawing.Color.Transparent;
            this.Type.Controls.Add(this.T_Y);
            this.Type.Controls.Add(this.T_D);
            this.Type.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Type.ForeColor = System.Drawing.Color.White;
            this.Type.Location = new System.Drawing.Point(140, 211);
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(80, 88);
            this.Type.TabIndex = 16;
            this.Type.TabStop = false;
            this.Type.Text = "Тип";
            // 
            // T_Y
            // 
            this.T_Y.AutoSize = true;
            this.T_Y.Location = new System.Drawing.Point(15, 54);
            this.T_Y.Name = "T_Y";
            this.T_Y.Size = new System.Drawing.Size(51, 23);
            this.T_Y.TabIndex = 16;
            this.T_Y.TabStop = true;
            this.T_Y.Text = "Год";
            this.T_Y.UseVisualStyleBackColor = true;
            this.T_Y.Click += new System.EventHandler(this.T_Y_Click);
            // 
            // T_D
            // 
            this.T_D.AutoSize = true;
            this.T_D.Location = new System.Drawing.Point(15, 25);
            this.T_D.Name = "T_D";
            this.T_D.Size = new System.Drawing.Size(59, 23);
            this.T_D.TabIndex = 15;
            this.T_D.TabStop = true;
            this.T_D.Text = "Дата";
            this.T_D.UseVisualStyleBackColor = true;
            this.T_D.Click += new System.EventHandler(this.T_D_Click);
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(240, 268);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(60, 20);
            this.Year.TabIndex = 17;
            // 
            // Таблица
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.BackgroundImage = global::Задание_4.Properties.Resources.Фон;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(799, 611);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Type);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.Title);
            this.Name = "Таблица";
            this.Text = "Изобретения 20 века";
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.Group.ResumeLayout(false);
            this.Group.PerformLayout();
            this.Type.ResumeLayout(false);
            this.Type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.TextBox Section;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.MaskedTextBox Date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.GroupBox Group;
        private System.Windows.Forms.RadioButton Q4;
        private System.Windows.Forms.RadioButton Q3;
        private System.Windows.Forms.RadioButton Q2;
        private System.Windows.Forms.RadioButton Q1;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox Type;
        private System.Windows.Forms.RadioButton T_Y;
        private System.Windows.Forms.RadioButton T_D;
        private System.Windows.Forms.TextBox Year;
    }
}

