
namespace Система
{
    partial class Сравнение
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
            this.Num1 = new System.Windows.Forms.TextBox();
            this.Measure1 = new System.Windows.Forms.ComboBox();
            this.Measure2 = new System.Windows.Forms.ComboBox();
            this.Num2 = new System.Windows.Forms.TextBox();
            this.Translate = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Num1
            // 
            this.Num1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num1.Location = new System.Drawing.Point(30, 45);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(130, 29);
            this.Num1.TabIndex = 0;
            // 
            // Measure1
            // 
            this.Measure1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Measure1.FormattingEnabled = true;
            this.Measure1.Items.AddRange(new object[] {
            "метр",
            "дюйм",
            "верста ",
            "сажень",
            "аршин",
            "фут"});
            this.Measure1.Location = new System.Drawing.Point(166, 45);
            this.Measure1.Name = "Measure1";
            this.Measure1.Size = new System.Drawing.Size(121, 32);
            this.Measure1.TabIndex = 2;
            // 
            // Measure2
            // 
            this.Measure2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Measure2.FormattingEnabled = true;
            this.Measure2.Items.AddRange(new object[] {
            "метр",
            "дюйм",
            "верста ",
            "сажень",
            "аршин",
            "фут"});
            this.Measure2.Location = new System.Drawing.Point(556, 45);
            this.Measure2.Name = "Measure2";
            this.Measure2.Size = new System.Drawing.Size(121, 32);
            this.Measure2.TabIndex = 4;
            // 
            // Num2
            // 
            this.Num2.Enabled = false;
            this.Num2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Num2.Location = new System.Drawing.Point(420, 45);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(130, 29);
            this.Num2.TabIndex = 3;
            // 
            // Translate
            // 
            this.Translate.Enabled = false;
            this.Translate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Translate.Location = new System.Drawing.Point(293, 44);
            this.Translate.Name = "Translate";
            this.Translate.Size = new System.Drawing.Size(121, 33);
            this.Translate.TabIndex = 5;
            this.Translate.Text = "Перевести";
            this.Translate.UseVisualStyleBackColor = true;
            this.Translate.Click += new System.EventHandler(this.Translate_Click);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(602, 112);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(75, 23);
            this.Close.TabIndex = 6;
            this.Close.Text = "Закрыть";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Сравнение
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(699, 148);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Translate);
            this.Controls.Add(this.Measure2);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.Measure1);
            this.Controls.Add(this.Num1);
            this.Name = "Сравнение";
            this.Text = "Сравнительный модуль";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.ComboBox Measure1;
        private System.Windows.Forms.ComboBox Measure2;
        private System.Windows.Forms.TextBox Num2;
        private System.Windows.Forms.Button Translate;
        private System.Windows.Forms.Button Close;
    }
}