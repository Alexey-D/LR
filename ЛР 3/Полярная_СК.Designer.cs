
namespace Полярная_СК
{
    partial class Полярная_СК
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.P = new System.Windows.Forms.TextBox();
            this.Ok = new System.Windows.Forms.Button();
            this.Sin = new System.Windows.Forms.RadioButton();
            this.Cos = new System.Windows.Forms.RadioButton();
            this.SinCos = new System.Windows.Forms.GroupBox();
            this.PlusMinus = new System.Windows.Forms.GroupBox();
            this.Plus = new System.Windows.Forms.RadioButton();
            this.Minus = new System.Windows.Forms.RadioButton();
            this.Num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Num2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SinCos.SuspendLayout();
            this.PlusMinus.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised;
            chartArea2.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.Chart.Legends.Add(legend2);
            this.Chart.Location = new System.Drawing.Point(30, 21);
            this.Chart.Name = "Chart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Legend = "Legend1";
            series2.Name = "График";
            this.Chart.Series.Add(series2);
            this.Chart.Size = new System.Drawing.Size(627, 316);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "Chart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "* (";
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(49, 359);
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(22, 20);
            this.P.TabIndex = 2;
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(388, 357);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(34, 23);
            this.Ok.TabIndex = 5;
            this.Ok.Text = "Ок";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Sin
            // 
            this.Sin.AutoSize = true;
            this.Sin.Location = new System.Drawing.Point(6, 19);
            this.Sin.Name = "Sin";
            this.Sin.Size = new System.Drawing.Size(38, 17);
            this.Sin.TabIndex = 6;
            this.Sin.TabStop = true;
            this.Sin.Text = "sin";
            this.Sin.UseVisualStyleBackColor = true;
            // 
            // Cos
            // 
            this.Cos.AutoSize = true;
            this.Cos.Location = new System.Drawing.Point(6, 42);
            this.Cos.Name = "Cos";
            this.Cos.Size = new System.Drawing.Size(42, 17);
            this.Cos.TabIndex = 7;
            this.Cos.TabStop = true;
            this.Cos.Text = "cos";
            this.Cos.UseVisualStyleBackColor = true;
            // 
            // SinCos
            // 
            this.SinCos.BackColor = System.Drawing.Color.Transparent;
            this.SinCos.Controls.Add(this.Sin);
            this.SinCos.Controls.Add(this.Cos);
            this.SinCos.Location = new System.Drawing.Point(171, 343);
            this.SinCos.Name = "SinCos";
            this.SinCos.Size = new System.Drawing.Size(46, 65);
            this.SinCos.TabIndex = 8;
            this.SinCos.TabStop = false;
            // 
            // PlusMinus
            // 
            this.PlusMinus.BackColor = System.Drawing.Color.Transparent;
            this.PlusMinus.Controls.Add(this.Plus);
            this.PlusMinus.Controls.Add(this.Minus);
            this.PlusMinus.Location = new System.Drawing.Point(128, 343);
            this.PlusMinus.Name = "PlusMinus";
            this.PlusMinus.Size = new System.Drawing.Size(37, 65);
            this.PlusMinus.TabIndex = 9;
            this.PlusMinus.TabStop = false;
            // 
            // Plus
            // 
            this.Plus.AutoSize = true;
            this.Plus.Location = new System.Drawing.Point(6, 19);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(31, 17);
            this.Plus.TabIndex = 6;
            this.Plus.TabStop = true;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            // 
            // Minus
            // 
            this.Minus.AutoSize = true;
            this.Minus.Location = new System.Drawing.Point(6, 42);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(28, 17);
            this.Minus.TabIndex = 7;
            this.Minus.TabStop = true;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            // 
            // Num1
            // 
            this.Num1.Location = new System.Drawing.Point(100, 359);
            this.Num1.Name = "Num1";
            this.Num1.Size = new System.Drawing.Size(22, 20);
            this.Num1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "f )";
            // 
            // Num2
            // 
            this.Num2.Location = new System.Drawing.Point(223, 359);
            this.Num2.Name = "Num2";
            this.Num2.Size = new System.Drawing.Size(22, 20);
            this.Num2.TabIndex = 12;
            // 
            // Полярная_СК
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 438);
            this.Controls.Add(this.Num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Num1);
            this.Controls.Add(this.PlusMinus);
            this.Controls.Add(this.SinCos);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.P);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart);
            this.Name = "Полярная_СК";
            this.Text = "Полярная система координат";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.SinCos.ResumeLayout(false);
            this.SinCos.PerformLayout();
            this.PlusMinus.ResumeLayout(false);
            this.PlusMinus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox P;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.RadioButton Sin;
        private System.Windows.Forms.RadioButton Cos;
        private System.Windows.Forms.GroupBox SinCos;
        private System.Windows.Forms.GroupBox PlusMinus;
        private System.Windows.Forms.RadioButton Plus;
        private System.Windows.Forms.RadioButton Minus;
        private System.Windows.Forms.TextBox Num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Num2;
    }
}

