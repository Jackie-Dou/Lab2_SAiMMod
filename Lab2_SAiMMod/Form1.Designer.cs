
namespace Lab2_SAiMMod
{
    partial class Form1
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
            this.comboBoxTypes = new System.Windows.Forms.ComboBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelChange3 = new System.Windows.Forms.Label();
            this.labelChange2 = new System.Windows.Forms.Label();
            this.labelChange1 = new System.Windows.Forms.Label();
            this.textBoxChange3 = new System.Windows.Forms.TextBox();
            this.textBoxChange2 = new System.Windows.Forms.TextBox();
            this.textBoxChange1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.textBoxR0 = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxDeviation = new System.Windows.Forms.TextBox();
            this.textBoxDisp = new System.Windows.Forms.TextBox();
            this.textBoxExpValue = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTypes
            // 
            this.comboBoxTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypes.FormattingEnabled = true;
            this.comboBoxTypes.Location = new System.Drawing.Point(12, 12);
            this.comboBoxTypes.Name = "comboBoxTypes";
            this.comboBoxTypes.Size = new System.Drawing.Size(218, 24);
            this.comboBoxTypes.TabIndex = 0;
            this.comboBoxTypes.SelectedValueChanged += new System.EventHandler(this.comboBoxTypes_SelectedValueChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(90, 534);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(140, 27);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Сгенерировать";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelChange3);
            this.panel1.Controls.Add(this.labelChange2);
            this.panel1.Controls.Add(this.labelChange1);
            this.panel1.Controls.Add(this.textBoxChange3);
            this.panel1.Controls.Add(this.textBoxChange2);
            this.panel1.Controls.Add(this.textBoxChange1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBoxM);
            this.panel1.Controls.Add(this.textBoxR0);
            this.panel1.Controls.Add(this.textBoxA);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 246);
            this.panel1.TabIndex = 2;
            // 
            // labelChange3
            // 
            this.labelChange3.AutoSize = true;
            this.labelChange3.Location = new System.Drawing.Point(3, 192);
            this.labelChange3.Name = "labelChange3";
            this.labelChange3.Size = new System.Drawing.Size(20, 17);
            this.labelChange3.TabIndex = 12;
            this.labelChange3.Text = "f3";
            // 
            // labelChange2
            // 
            this.labelChange2.AutoSize = true;
            this.labelChange2.Location = new System.Drawing.Point(3, 163);
            this.labelChange2.Name = "labelChange2";
            this.labelChange2.Size = new System.Drawing.Size(20, 17);
            this.labelChange2.TabIndex = 11;
            this.labelChange2.Text = "f2";
            // 
            // labelChange1
            // 
            this.labelChange1.AutoSize = true;
            this.labelChange1.Location = new System.Drawing.Point(3, 134);
            this.labelChange1.Name = "labelChange1";
            this.labelChange1.Size = new System.Drawing.Size(20, 17);
            this.labelChange1.TabIndex = 10;
            this.labelChange1.Text = "f1";
            // 
            // textBoxChange3
            // 
            this.textBoxChange3.Location = new System.Drawing.Point(49, 192);
            this.textBoxChange3.Name = "textBoxChange3";
            this.textBoxChange3.Size = new System.Drawing.Size(100, 22);
            this.textBoxChange3.TabIndex = 9;
            // 
            // textBoxChange2
            // 
            this.textBoxChange2.Location = new System.Drawing.Point(49, 164);
            this.textBoxChange2.Name = "textBoxChange2";
            this.textBoxChange2.Size = new System.Drawing.Size(100, 22);
            this.textBoxChange2.TabIndex = 8;
            // 
            // textBoxChange1
            // 
            this.textBoxChange1.Location = new System.Drawing.Point(49, 135);
            this.textBoxChange1.Name = "textBoxChange1";
            this.textBoxChange1.Size = new System.Drawing.Size(100, 22);
            this.textBoxChange1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "m";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "R0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "a";
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(49, 87);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(100, 22);
            this.textBoxM.TabIndex = 3;
            // 
            // textBoxR0
            // 
            this.textBoxR0.Location = new System.Drawing.Point(49, 59);
            this.textBoxR0.Name = "textBoxR0";
            this.textBoxR0.Size = new System.Drawing.Size(100, 22);
            this.textBoxR0.TabIndex = 2;
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(49, 31);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(100, 22);
            this.textBoxA.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Входные данные";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBoxDeviation);
            this.panel2.Controls.Add(this.textBoxDisp);
            this.panel2.Controls.Add(this.textBoxExpValue);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 294);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 223);
            this.panel2.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "Среднеквадрат.отклонение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Дисперсия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 4;
            this.label6.Text = "Мат.ожидание";
            // 
            // textBoxDeviation
            // 
            this.textBoxDeviation.Location = new System.Drawing.Point(3, 170);
            this.textBoxDeviation.Name = "textBoxDeviation";
            this.textBoxDeviation.ReadOnly = true;
            this.textBoxDeviation.Size = new System.Drawing.Size(100, 22);
            this.textBoxDeviation.TabIndex = 3;
            // 
            // textBoxDisp
            // 
            this.textBoxDisp.Location = new System.Drawing.Point(6, 113);
            this.textBoxDisp.Name = "textBoxDisp";
            this.textBoxDisp.ReadOnly = true;
            this.textBoxDisp.Size = new System.Drawing.Size(100, 22);
            this.textBoxDisp.TabIndex = 2;
            // 
            // textBoxExpValue
            // 
            this.textBoxExpValue.Location = new System.Drawing.Point(6, 61);
            this.textBoxExpValue.Name = "textBoxExpValue";
            this.textBoxExpValue.ReadOnly = true;
            this.textBoxExpValue.Size = new System.Drawing.Size(100, 22);
            this.textBoxExpValue.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Выходные данные";
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(251, 42);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(1218, 475);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "f1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1513, 570);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.comboBoxTypes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTypes;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChange3;
        private System.Windows.Forms.Label labelChange2;
        private System.Windows.Forms.Label labelChange1;
        private System.Windows.Forms.TextBox textBoxChange3;
        private System.Windows.Forms.TextBox textBoxChange2;
        private System.Windows.Forms.TextBox textBoxChange1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.TextBox textBoxR0;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxDeviation;
        private System.Windows.Forms.TextBox textBoxDisp;
        private System.Windows.Forms.TextBox textBoxExpValue;
    }
}

