using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demographic.FileOperations;
using System.Windows.Forms;
using Demographic.WinForms.Presentation;
using Demographic.WinForms.View;

namespace Demographic.WinForms
{
    public partial class Form1 : Form, IDemView
    {
        public int YearStart { get; set; }
        public long InitPop { get; set; }
        public int YearEnd { get; set; }
        public List<int> MaleFinalPopulation { get; set; }
        public List<int> FemaleFinalPopulation { get; set; }
        public string PathInitialAge { get; set; }
        public string PathDeathRules { get; set; }
        public List<int> YearPopulation { get; set; }
        public List<int> Male_Population { get; set; }
        public List<int> Female_Population { get; set; }
        DemPresentation presentation;
        public Form1()
        {
            InitializeComponent();
        }
        private bool check = true;
        private void button1_Click(object sender, EventArgs e)
        {
            presentation = new DemPresentation(this);
            if (PathDeathRules == null || PathInitialAge == null)
            {
                MessageBox.Show("Путь файла не загружен");
                check = false;
            }
            else
            {
                check = true;
                try
                {
                    presentation.DataChecking(TBox_YearStart.Text, TBox_YearEnd.Text, TBox_population.Text);
                    presentation.FileParse();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    check = false;
                }
            }
            if (check)
                MessageBox.Show("Загрузка данных завершена");
        }
        public void BarChart()
        {
            chart_female.Series.Clear();
            chart_female.Titles.Clear();
            chart_female.ChartAreas.Clear();
            chart_male.Series.Clear();
            chart_male.Titles.Clear();
            chart_male.ChartAreas.Clear();
            List<string> age = new List<string>() { "0-18", "19-45", "45-65", "65-100" };
            chart_male.ChartAreas.Add("M");
            chart_female.ChartAreas.Add("W");
            chart_male.Titles.Add("Мужчины");
            chart_female.Titles.Add("Женщины");
            for (int i=0;i<age.Count;i++)
            {
                chart_male.Series.Add(age[i]);
                chart_male.Series[i].Points.Add(MaleFinalPopulation[i]);
                chart_female.Series.Add(age[i]);
                chart_female.Series[i].Points.Add(FemaleFinalPopulation[i]);
            }
        }
        private void button_Mod_Click(object sender, EventArgs e)
        {
            if (PathDeathRules == null || PathInitialAge == null)
                MessageBox.Show("Путь файла не загружен");
            else
            {
                if (check == false)
                    MessageBox.Show("Некорректные начальные данные");
                else
                {
                    presentation.Modeling();
                    chart_spline.Series[0].Points.Clear();
                    chart_spline.Series[1].Points.Clear();
                    chart_spline.Series[2].Points.Clear();
                    for (int i=0;i<=YearEnd-YearStart;i++)
                    {
                        chart_spline.Series[0].Points.AddXY(YearStart + i, YearPopulation[i]);
                        chart_spline.Series[1].Points.AddXY(YearStart + i, Male_Population[i]);
                        chart_spline.Series[2].Points.AddXY(YearStart + i, Female_Population[i]);
                        BarChart();
                    }
                }
            }
        }

        private void button_InitialAge_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog1.ShowDialog();
            PathInitialAge = openFileDialog1.FileName;
        }

        private void button_DeathRules_Click(object sender, EventArgs e)
        {
            openFileDialog2.Filter = "CSV files (*.csv)|*.csv";
            openFileDialog2.ShowDialog();
            PathDeathRules = openFileDialog2.FileName;
        }
    }
}
