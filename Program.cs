using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace Task4
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static int n = 1000;
        static double h = 1.0 / n;
        public static double[] FindU()
        {
            double[] arrayU = new double[n];
            arrayU[0] = -1 / h;
            for (int i = 1; i < arrayU.Length; i++)
                arrayU[i] = -1 / (2 + arrayU[i - 1]);
            return arrayU;
        }
        public static double[] Findb()
        {
            double[] arrayb = new double[n];
            int halfArray = arrayb.Length / 2;
            for (int i = 0; i < halfArray; i++)
                arrayb[i] = 4 * Math.PI * h * (h * i * h * i + h * h / 6);
            for (int i = halfArray; i < arrayb.Length; i++)
                arrayb[i] = 4 * Math.PI * h * ((1 - i * h) * (1 - i * h) + h * h / 6);
            return arrayb;
        }
        public static double[] FindY()
        {
            double[] arrayb = Findb();
            double[] arrayu = FindU();
            double[] arrayY = new double[n];
            arrayY[0] = 0;
            for (int i = 1; i < arrayY.Length; i++)
                arrayY[i] = (arrayb[i] + 1 / h * arrayY[i - 1]) / (2 / h + 1 / h * arrayu[i - 1]);
            return arrayY;
        }
        public static double[] FindA()
        {
            double[] arrayA = new double[n+1];
            double[] arrayu = FindU();
            double[] arrayy = FindY();
            arrayA[arrayA.Length - 1] = arrayy[arrayy.Length - 1];
            for (int i = arrayA.Length - 2; i >= 0; i--)
                arrayA[i] = arrayy[i] - arrayu[i] * arrayA[i + 1];
            return arrayA;
        }
        public static MyPoint[] FindF()
        {
            var arrayF = new MyPoint[n+1];
            var arrayXi = new double[n+2];
            double[] arraya = FindA();
            double q;
            for (double t = 0; t <= 1 + 3*h / 2; t += h)
            {
                arrayXi[(int)Math.Round((t * n))] = t;
            }
            for (double t=0; t<=1+h/2; t+=h)
            {
                arrayF[(int)Math.Round((t * n))] = new MyPoint(t, 0);
            }
            for (double x = 0; x<1+h/2; x+=h )
            {
                q = Math.Abs((Math.Round(x-1, (int)(-Math.Log(h)))));
                if (x == 0)
                    arrayF[0] = new MyPoint(x, 0);
                else if (q<h)
                    arrayF[n] = new MyPoint(x, 0);
                else
                {
                    var m = (int)(Math.Round((x / h), (int)(-Math.Log(h))));
                    for (int j = m; j <= m + 2; j++)
                    {
                        if (x >= arrayXi[j - 1] && x <= arrayXi[j])
                        {
                            arrayF[m].Y += arraya[j] * (x - arrayXi[j - 1]) / h;
                        }
                        else if (x >= arrayXi[j] && x <= arrayXi[j + 1])
                            arrayF[m].Y+= arraya[j] * (arrayXi[j + 1] - x) / h;
                    }
                }
            }
            return arrayF;
        }
        public static MyPoint[] FindFAnalit()
        {
            var arrayFAnalit = new MyPoint[n + 1];
            for (double t = 0; t <= 1 + h / 2; t += h)
            {
                arrayFAnalit[(int)Math.Round((t * n))] = new MyPoint(t, 0);
            }
            for (double i = 0; i < 0.5; i += h)
            {
                double y = -Math.PI / 3 * i * i * i * i + Math.PI / 6 * i;
                arrayFAnalit[(int)Math.Round((i * n))] = new MyPoint(i, y);

            }
            for (double i = 0.5; i <= 1; i += h)
            {
                double y =-Math.PI / 3 * (1 - i) * (1 - i) * (1 - i) * (1 - i) - Math.PI / 6 * i + Math.PI / 6;
                arrayFAnalit[(int)Math.Round((i * n))] = new MyPoint(i, y);
            }
            return arrayFAnalit;
        }
        public static MyPoint[] FindDiff()
        {
            var arrayDiff = new MyPoint[n + 1];
            var ar1 = FindF();
            var ar2 = FindFAnalit();
            for (int i=0; i<arrayDiff.Length; i++)
            {
                arrayDiff[i]=new MyPoint( ar1[i].X, Math.Abs(ar1[i].Y - ar2[i].Y));
            }
            return arrayDiff;
        }
    }
}
