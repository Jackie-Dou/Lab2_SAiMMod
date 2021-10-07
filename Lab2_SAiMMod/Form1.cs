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
                    labelChange1.Text = "N"; textBoxChange1.Text = "0";
                    labelChange2.Text = "m"; textBoxChange2.Text = "0";
                    labelChange3.Text = "σ"; textBoxChange3.Text = "0";
                    break;
                case EXP_STR:
                    labelChange1.Text = "N"; textBoxChange1.Text = "0";
                    labelChange2.Text = "λ"; textBoxChange2.Text = "0";
                    labelChange3.Text = " "; textBoxChange3.Text = "no input";
                    break;
                case GAMMA_STR:
                    labelChange1.Text = "N = "; textBoxChange1.Text = "0";
                    labelChange2.Text = "η = "; textBoxChange1.Text = "0";
                    labelChange3.Text = "λ = "; textBoxChange1.Text = "0";
                    break;
                case TRIANG_STR:
                    labelChange1.Text = "N"; textBoxChange1.Text = "0";
                    labelChange2.Text = "a"; textBoxChange2.Text = "0";
                    labelChange3.Text = "b"; textBoxChange3.Text = "0";
                    break;
                case SIMPSON_STR:
                    labelChange1.Text = "N"; textBoxChange1.Text = "0";
                    labelChange2.Text = "a"; textBoxChange2.Text = "0";
                    labelChange3.Text = "b"; textBoxChange3.Text = "0";
                    break;
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
                    numbersX = GaussDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text), Convert.ToDouble(textBoxChange3.Text));
                    numbersX.Sort();
                    break;
                case EXP_STR:
                    numbersX = ExponentialDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text));
                    numbersX.Sort();
                    break;
                case GAMMA_STR:
                    numbersX = GammaDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text), Convert.ToDouble(textBoxChange3.Text));
                    numbersX.Sort();
                    break;
                case TRIANG_STR:
                    numbersX = TriangularDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text), Convert.ToDouble(textBoxChange3.Text));
                    numbersX.Sort();
                    break;
                case SIMPSON_STR:
                    numbersX = SimpsonDistribution(Convert.ToInt32(textBoxChange1.Text), Convert.ToDouble(textBoxChange2.Text), Convert.ToDouble(textBoxChange3.Text));
                    numbersX.Sort();
                    break;
            }
            double expValue = Math.Round(GetExpectedValue(numbersX), 4);
            double disp = Math.Round(GetDispersion(numbersX, expValue), 4);
            double deviation = Math.Round(GetStandartDeviation(disp), 4);
            textBoxExpValue.Text = expValue.ToString();
            textBoxDisp.Text = disp.ToString();
            textBoxDeviation.Text = deviation.ToString();

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

        private double GetExpectedValue(List<double> numbers)
        {
            double sum = numbers.Sum();
            return sum / SIZE;
        }

        private double GetDispersion(List<double> numbers, double expValue)
        {
            double sum = numbers.Sum(x => Math.Pow(x - expValue, 2));
            return sum / SIZE;
        }

        private double GetStandartDeviation(double disp)
        {
            return Math.Sqrt(disp);
        }

        private static List<double> EvenDistribution(int N, double a, double b)
        {
            if (N == 0) N = 130000;
            if (a == 0) a = 5000;
            if (b == 0) b = 10000;

            var result = new List<double>();

            for (int i = 0; i < N; i++)
                result.Insert(i, a + (b - a) * numbersR.ElementAt(i));

            return result;
        }

        private static List<double> GaussDistribution(int N, double m, double sig)
        {
            if (N == 0) N = 130000;
            if (m == 0) m = 500;
            if (sig == 0) sig = 100;

            var result = new List<double>();

            double n = 6;
            for (int i = 0; i < N; i++)
            {
                double sum = 0;
                for (int j = 0; j < n; j++)
                    sum += numbersR.ElementAt((i + j) % N);

                result.Insert(i, m + sig * Math.Sqrt(12.0 / n) * (sum - (double)n / 2));
            }

            return result;
        }

        private static List<double> ExponentialDistribution(int N, double l)
        {
            if (N == 0) N = 130000;
            if (l == 0) l = 100;

            var result = new List<double>();
            for (int i = 0; i < N; i++)
                result.Insert(i, -Math.Log(numbersR.ElementAt(i)) / l);
            return result;
        }

        private static List<double> GammaDistribution(int N, double n, double l)
        {
            if (N == 0) N = 130000;
            if (n == 0) n = 100;
            if (l == 0) l = 400;

            var result = new List<double>();

            for (int i = 0; i < N; i++)
            {
                double tmp = 1;
                for (int j = 0; j < n; j++)
                    tmp *= numbersR.ElementAt((i + j) % N);

                result.Insert(i, -Math.Log(tmp) / l);
            }

            return result;
        }

        private static List<double> TriangularDistribution(int N, double a, double b)
        {
            if (N == 0) N = 130000;
            if (a == 0) a = 1;
            if (b == 0) b = 50;

            var result = new List<double>();

            for (int i = 0; i < N-1; i++)
            {
                double R1 = numbersR.ElementAt(i);
                double R2 = numbersR.ElementAt(i + 1);
                result.Insert(i, a + (b - a) * Math.Max(R1, R2));
            }

            return result;
        }

        private static List<double> SimpsonDistribution(int N, double a, double b)
        {
            if (N == 0) N = 130000;
            if (a == 0) a = 20;
            if (b == 0) b = 100;

            var result = new List<double>();

            for (int i = 0; i < N; i++)
                result.Insert(i, a / 2 + (b / 2 - a / 2) * numbersR.ElementAt(i) + a / 2 + (b / 2 - a / 2) * numbersR.ElementAt((i + 1) % N));

            return result;
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
