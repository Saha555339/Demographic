namespace Demographic.WinForms
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button_Mod = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TBox_population = new System.Windows.Forms.TextBox();
            this.TBox_YearStart = new System.Windows.Forms.TextBox();
            this.TBox_YearEnd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chart_spline = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_male = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart_female = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button_InitialAge = new System.Windows.Forms.Button();
            this.button_DeathRules = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart_spline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_male)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_female)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "Загрузка начальных данных";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button_Mod
            // 
            this.button_Mod.Location = new System.Drawing.Point(238, 330);
            this.button_Mod.Name = "button_Mod";
            this.button_Mod.Size = new System.Drawing.Size(134, 48);
            this.button_Mod.TabIndex = 1;
            this.button_Mod.Text = "Моделирование";
            this.button_Mod.UseVisualStyleBackColor = true;
            this.button_Mod.Click += new System.EventHandler(this.button_Mod_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Начальная популяция";
            // 
            // TBox_population
            // 
            this.TBox_population.Location = new System.Drawing.Point(401, 330);
            this.TBox_population.Name = "TBox_population";
            this.TBox_population.Size = new System.Drawing.Size(100, 22);
            this.TBox_population.TabIndex = 3;
            this.TBox_population.Text = "130000000";
            // 
            // TBox_YearStart
            // 
            this.TBox_YearStart.Location = new System.Drawing.Point(555, 332);
            this.TBox_YearStart.Name = "TBox_YearStart";
            this.TBox_YearStart.Size = new System.Drawing.Size(62, 22);
            this.TBox_YearStart.TabIndex = 4;
            this.TBox_YearStart.Text = "1970";
            // 
            // TBox_YearEnd
            // 
            this.TBox_YearEnd.Location = new System.Drawing.Point(667, 332);
            this.TBox_YearEnd.Name = "TBox_YearEnd";
            this.TBox_YearEnd.Size = new System.Drawing.Size(62, 22);
            this.TBox_YearEnd.TabIndex = 5;
            this.TBox_YearEnd.Text = "2021";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(548, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Первый год";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Последний год";
            // 
            // chart_spline
            // 
            chartArea4.Name = "ChartArea1";
            this.chart_spline.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_spline.Legends.Add(legend4);
            this.chart_spline.Location = new System.Drawing.Point(64, 12);
            this.chart_spline.Name = "chart_spline";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "ser_population";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series7.Legend = "Legend1";
            series7.Name = "ser_male";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series8.Legend = "Legend1";
            series8.Name = "ser_female";
            this.chart_spline.Series.Add(series6);
            this.chart_spline.Series.Add(series7);
            this.chart_spline.Series.Add(series8);
            this.chart_spline.Size = new System.Drawing.Size(780, 300);
            this.chart_spline.TabIndex = 9;
            this.chart_spline.Text = "chart2";
            // 
            // chart_male
            // 
            chartArea5.Name = "ChartArea1";
            this.chart_male.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_male.Legends.Add(legend5);
            this.chart_male.Location = new System.Drawing.Point(851, 12);
            this.chart_male.Name = "chart_male";
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Series1";
            this.chart_male.Series.Add(series9);
            this.chart_male.Size = new System.Drawing.Size(368, 411);
            this.chart_male.TabIndex = 10;
            this.chart_male.Text = "chart1";
            // 
            // chart_female
            // 
            chartArea6.Name = "ChartArea1";
            this.chart_female.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart_female.Legends.Add(legend6);
            this.chart_female.Location = new System.Drawing.Point(1234, 12);
            this.chart_female.Name = "chart_female";
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "Series1";
            this.chart_female.Series.Add(series10);
            this.chart_female.Size = new System.Drawing.Size(356, 411);
            this.chart_female.TabIndex = 11;
            this.chart_female.Text = "chart3";
            // 
            // button_InitialAge
            // 
            this.button_InitialAge.Location = new System.Drawing.Point(64, 400);
            this.button_InitialAge.Name = "button_InitialAge";
            this.button_InitialAge.Size = new System.Drawing.Size(136, 23);
            this.button_InitialAge.TabIndex = 12;
            this.button_InitialAge.Text = "Выбрать";
            this.button_InitialAge.UseVisualStyleBackColor = true;
            this.button_InitialAge.Click += new System.EventHandler(this.button_InitialAge_Click);
            // 
            // button_DeathRules
            // 
            this.button_DeathRules.Location = new System.Drawing.Point(238, 400);
            this.button_DeathRules.Name = "button_DeathRules";
            this.button_DeathRules.Size = new System.Drawing.Size(134, 23);
            this.button_DeathRules.TabIndex = 13;
            this.button_DeathRules.Text = "Выбрать";
            this.button_DeathRules.UseVisualStyleBackColor = true;
            this.button_DeathRules.Click += new System.EventHandler(this.button_DeathRules_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 430);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 48);
            this.label4.TabIndex = 14;
            this.label4.Text = "Выберите файл \r\nс возрастным\r\nсоставом населения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Выберите файл\r\nс таблицей смертности";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1882, 498);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_DeathRules);
            this.Controls.Add(this.button_InitialAge);
            this.Controls.Add(this.chart_female);
            this.Controls.Add(this.chart_male);
            this.Controls.Add(this.chart_spline);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBox_YearEnd);
            this.Controls.Add(this.TBox_YearStart);
            this.Controls.Add(this.TBox_population);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Mod);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart_spline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_male)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_female)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button_Mod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBox_population;
        private System.Windows.Forms.TextBox TBox_YearStart;
        private System.Windows.Forms.TextBox TBox_YearEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_spline;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_male;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_female;
        private System.Windows.Forms.Button button_InitialAge;
        private System.Windows.Forms.Button button_DeathRules;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

