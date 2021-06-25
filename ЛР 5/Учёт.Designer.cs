
namespace Система
{
    partial class Учёт
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Module = new System.Windows.Forms.GroupBox();
            this.Compare = new System.Windows.Forms.Button();
            this.Book = new System.Windows.Forms.Button();
            this.Math = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Equations = new System.Windows.Forms.TextBox();
            this.Records = new System.Windows.Forms.TextBox();
            this.CU = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.Module.SuspendLayout();
            this.SuspendLayout();
            // 
            // Module
            // 
            this.Module.Controls.Add(this.Compare);
            this.Module.Controls.Add(this.Book);
            this.Module.Controls.Add(this.Math);
            this.Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Module.Location = new System.Drawing.Point(582, 50);
            this.Module.Name = "Module";
            this.Module.Size = new System.Drawing.Size(206, 115);
            this.Module.TabIndex = 0;
            this.Module.TabStop = false;
            this.Module.Text = "Выберите модуль";
            // 
            // Compare
            // 
            this.Compare.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Compare.Location = new System.Drawing.Point(20, 78);
            this.Compare.Name = "Compare";
            this.Compare.Size = new System.Drawing.Size(180, 23);
            this.Compare.TabIndex = 2;
            this.Compare.Text = "Сравнительный";
            this.Compare.UseVisualStyleBackColor = true;
            this.Compare.Click += new System.EventHandler(this.Compare_Click);
            // 
            // Book
            // 
            this.Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Book.Location = new System.Drawing.Point(20, 49);
            this.Book.Name = "Book";
            this.Book.Size = new System.Drawing.Size(180, 23);
            this.Book.TabIndex = 1;
            this.Book.Text = "Справочный";
            this.Book.UseVisualStyleBackColor = true;
            this.Book.Click += new System.EventHandler(this.Book_Click);
            // 
            // Math
            // 
            this.Math.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Math.Location = new System.Drawing.Point(20, 20);
            this.Math.Name = "Math";
            this.Math.Size = new System.Drawing.Size(180, 23);
            this.Math.TabIndex = 0;
            this.Math.Text = "Математический";
            this.Math.UseVisualStyleBackColor = true;
            this.Math.Click += new System.EventHandler(this.Math_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество решённых уравнений";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(20, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(355, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Количество записей об учебных дисциплинах";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Количество УЕ в которые можно переводить";
            // 
            // Equations
            // 
            this.Equations.Enabled = false;
            this.Equations.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Equations.Location = new System.Drawing.Point(393, 47);
            this.Equations.Name = "Equations";
            this.Equations.Size = new System.Drawing.Size(65, 26);
            this.Equations.TabIndex = 4;
            // 
            // Records
            // 
            this.Records.Enabled = false;
            this.Records.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Records.Location = new System.Drawing.Point(393, 97);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(65, 26);
            this.Records.TabIndex = 5;
            // 
            // CU
            // 
            this.CU.Enabled = false;
            this.CU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CU.Location = new System.Drawing.Point(393, 147);
            this.CU.Name = "CU";
            this.CU.Size = new System.Drawing.Size(65, 26);
            this.CU.TabIndex = 6;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(707, 254);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 19;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Update
            // 
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update.Location = new System.Drawing.Point(602, 182);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(180, 23);
            this.Update.TabIndex = 20;
            this.Update.Text = "Обновить";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Учёт
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(800, 289);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.CU);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Equations);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Module);
            this.Name = "Учёт";
            this.Text = "Учётный модуль";
            this.Module.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Module;
        private System.Windows.Forms.Button Compare;
        private System.Windows.Forms.Button Book;
        private System.Windows.Forms.Button Math;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Equations;
        private System.Windows.Forms.TextBox Records;
        private System.Windows.Forms.TextBox CU;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Update;
    }
}