using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Globalization;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        Stopwatch stopwatch;

        public Form1()
        {
            InitializeComponent();
            
            //20 ms timer gives 50 FPS
            timer1.Interval = 20;
            timer1.Enabled = true;

            stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StopwatchTime.Text = stopwatch.ElapsedMilliseconds.ToString();
        }
    }
}
