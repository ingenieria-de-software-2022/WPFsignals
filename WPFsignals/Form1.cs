using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WPFsignals
{
    public partial class Form1 : Form
    {
        double ti, tf, g, t;
        int n;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double h, w, A, T, q;
            ti = -5;
            tf = 5;
            n = chart1.Width;
            h = (tf - ti) / n;
            w = trackBar1.Value;
            A = trackBar2.Value;
            q = trackBar3.Value;
            T = DateTime.Now.Second * 0.1 * q;
            chart1.Series["Series1"].Points.Clear();

            for (int k = 0; k < n; k++)
            {
                t = ti + k * h;
                if (comboBox1.Text == "cos") g = A * Math.Cos(w * t - T);
                if (comboBox1.Text == "sen") g = A * Math.Sin(w * t - T);
                if (comboBox1.Text == "tan") g = A * Math.Tan(w * t - T);
                chart1.Series["Series1"].Points.AddXY(t, g);
            }
        }
    }
}
