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

        struct GistogramInfo
        {
            public int numOfValue { get; set; }
            public double startOfSegment { get; set; }
            public double endOfSegment { get; set; }
        }
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
                    labelChange2.Text = "λ"; textBoxChange1.Text = "0";
                    labelChange3.Text = " "; textBoxChange1.Text = "no input";
                    break;
                case GAMMA_STR:
                    break;
                case TRIANG_STR:
                    break;
                case SIMPSON_STR:
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
                    break;
                case TRIANG_STR:
                    break;
                case SIMPSON_STR:
                    break;
            }
            List<GistogramInfo> gistData = new List<GistogramInfo>();
            gistData = GetGistogramInfo(numbersX);
            gistData.ForEach(delegate (GistogramInfo info)
            {
                chart1.Series[0].Points.AddXY(Math.Round(info.startOfSegment, 4), info.numOfValue);
            });
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

        private List<GistogramInfo> GetGistogramInfo(List<double> numbers)
        {
            double maxValue = numbers.Max();
            double minValue = numbers.Min();
            double step = (double)(maxValue - minValue) / (double)NUM_STEPS;
            List<GistogramInfo> result = new List<GistogramInfo>();
            double temp = minValue;
            int num = numbers.FindAll(x => (x == minValue)).Count;
            while (temp < maxValue)
            {
                num += numbers.FindAll(x => (x <= temp + step && x > temp)).Count;
                GistogramInfo info = new GistogramInfo
                {
                    numOfValue = num,
                    startOfSegment = temp,
                    endOfSegment = temp + step
                };
                result.Add(info);
                num = 0;
                temp += step;
                temp = Math.Round(temp, 5);
            }
            return result;
        }
    }
}
