using System;
using Microsoft;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyPoint [] array = Program.FindF();
            MyPoint[] array2 = Program.FindFAnalit();
            MyPoint[] array3 = Program.FindDiff();
            for (int i=0; i<array.Length; i++ )
            {
                chart1.Series[0].Points.AddXY(array[i].X, array[i].Y);
                chart1.Series[1].Points.AddXY(array2[i].X, array2[i].Y);
                chart1.Series[2].Points.AddXY(array3[i].X, array3[i].Y);
            }
        }


    }
}
