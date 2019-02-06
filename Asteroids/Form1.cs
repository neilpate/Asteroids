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
using SDL2;

namespace Asteroids
{
    public partial class Form1 : Form
    {
        private Game game;

        public Form1()
        {
            InitializeComponent();

            game = new Game();

            //20 ms timer gives 50 FPS
            timer1.Interval = 20;
            timer1.Enabled = true;

          

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (game.Update())
                System.Windows.Forms.Application.Exit();
        }

    }
}
