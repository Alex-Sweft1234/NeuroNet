using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RBFNet
{
    public class Neuron
    {
        const int n = 10;
        Random r = new Random();
        double[] Xi = { -0.9602, -0.5770, -0.0729,  0.3771,  0.6405,  0.6600,  0.4609, 0.1336, -0.2013, -0.4344};
        double[] Weight = new double[n];

        double[] InitWeight()
        {
            for (int i = 0; i < n; i++)
            {
                Weight[i] = (r.NextDouble() - 0.5) * 2;
            }
            return Weight;
        }

        double Summator()
        {
            double S = 0;
            InitWeight();
            for (int i = 0; i < n; i++)
            {
                double c = Xi[i] * Weight[i];
                S += c;
            }
            return S;
        }

        public double FuncActivation()
        {
            double sigma = 2;
            double s = Summator();
            double mu = -2;
            double y = (1 / (sigma * Math.Sqrt(2 * Math.PI)))*Math.Exp((Math.Pow((s - mu),2)/Math.Pow((2*sigma),2))*(-1));
            return y;
        }
    }

    public class NeuroNet
    { 
        
    }

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
