using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_SAiMMod
{
    public partial class Form1 : Form
    {
        private const int NUM_STEPS = 20;
        private const int SIZE = 200000;
        private const string EVEN_STR = "Равномерное распределение";
        private const string GAUSS_STR = "Гауссовское распределение";
        private const string EXP_STR = "Экспоненциальное распределение";
        private const string GAMMA_STR = "Гамма-распределение";
        private const string TRIANG_STR = "Треугольное распределение";
        private const string SIMPSON_STR = "Распределение Симпсона";


        /*
                const double xMin = 0;
                const double xMax = 1;
                const double yMin = 0;
                const double yMax = 0.1;
                const double delta = 1 / (double)NUM_STEPS;*/

        static List<double> numbersR = new List<double>();

        public Form1()
        {
            InitializeComponent();
            comboBoxTypes.Items.Add(EVEN_STR);
            comboBoxTypes.Items.Add(GAUSS_STR);
            comboBoxTypes.Items.Add(EXP_STR);
            comboBoxTypes.Items.Add(GAMMA_STR);
            comboBoxTypes.Items.Add(TRIANG_STR);
            comboBoxTypes.Items.Add(SIMPSON_STR);
        }

        private void GetLemer(int a, int R0, int m)
        {
            double R = R0;
            for (int i = 0; i < SIZE; i++)
            {
                double temp1 = (a * R) % m;
                double temp2 = temp1 / m;
                numbersR.Add(temp2);
                R = temp1;
            }
        }



        private void buttonStart_Click(object sender, EventArgs e)
        {
            numbersR.Clear();

            int a = 0, R0 = 0, m = 0;
            try
            {
                a = Int32.Parse(textBoxA.Text);
                R0 = Int32.Parse(textBoxR0.Text);
                m = Int32.Parse(textBoxM.Text);
                if (R0 >= (Math.Pow(2, SIZE) - 1) || a > m)
                {
                    throw new Exception("Ограничение на R");
                }
            }
            catch
            {
                MessageBox.Show(
                    "Некорректный ввод",
                    "Сообщение");
                return;
            }
            GetLemer(a, R0, m); 

            string type;
            type = comboBoxTypes.Text;

            List<double> numbersX = new List<double>();
            switch (type)
            {
                case EVEN_STR:
                    numbersX = EvenDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text), Convert.ToDouble(textBoxChange3.Text));
                   // DrawEvaluationDiagram(numbersX, 5000, 10000, 0.06);
                    break;
                case GAUSS_STR:
                    //numbersX = GaussDistribution();
                    break;
                case EXP_STR:
                    //ExponentialDistribution();
                    break;
                case GAMMA_STR:
                    break;
                case TRIANG_STR:
                    break;
                case SIMPSON_STR:
                    break;
            }
        }

        private static List<double> EvenDistribution(int N = 130000, double a = 5000, double b = 10000)
        {
            if (N == 0) N = 130000;
            if (a == 0) a = 5000;
            if (b == 0) b = 10000;
            var result = new List<double>();

            for (int i = 0; i < N; i++)
                result.Insert(i, a + (b - a) * numbersR.ElementAt(i));

            return result;
        }

        private void comboBoxTypes_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (comboBoxTypes.Text)
            {
                case EVEN_STR:
                    labelChange1.Text = "N"; textBoxChange1.Text = "0";
                    labelChange2.Text = "a"; textBoxChange2.Text = "0";
                    labelChange3.Text = "b"; textBoxChange3.Text = "0";
                    break;
                case GAUSS_STR:
                    break;
                case EXP_STR:
                    break;
                case GAMMA_STR:
                    break;
                case TRIANG_STR:
                    break;
                case SIMPSON_STR:
                    break;
            }
        }

        /*        private void DrawEvaluationDiagram(List<double> xValues, double? minX = null, double? maxX = null, double? maxY = null)
                {
                    xValues.Sort();

                    chart1.Series["Ci"].Points.Clear();
                    chart1.Series["Xi"].Points.Clear();

                    int[] countInIntervals = new int[NUM_STEPS + 1];
                    int intervalNumber;
                    int max = 0;

                    double delta = (xValues.Last() - xValues.First()) / NUM_STEPS;

                    foreach (double x in xValues)
                    {
                        intervalNumber = (int)Math.Truncate((x - xValues.First()) / delta) % 20;
                        countInIntervals[intervalNumber]++;
                    }

                    foreach (int i in countInIntervals)
                    {
                        if (i > max)
                        {
                            max = i;
                        }
                    }

                    chart1.ChartAreas[0].AxisY.Maximum = (maxY != null) ? maxY.Value : (1.5 * ((double)max / xValues.Count));
                    chart1.ChartAreas[0].AxisY.Minimum = yMin;
                    chart1.ChartAreas[0].AxisX.Maximum = (maxX != null) ? maxX.Value : xValues.Last();
                    chart1.ChartAreas[0].AxisX.Minimum = (minX != null) ? minX.Value : xValues.First();

                    for (int i = 0; i < countInIntervals.Length; i++)
                    {
                        chart1.Series["Ci"].Points.AddXY(xValues.First() + i * delta + delta / 2, (double)countInIntervals[i] / xValues.Count);
                        Console.WriteLine((double)countInIntervals[i] / xValues.Count);
                    }
                }*/
    }
}
