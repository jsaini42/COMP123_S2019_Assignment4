﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Assignment4
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            SplashTimer.Enabled = true;
        }
        private void SplashTimer_Tick(object sender, EventArgs e)
        {
            SplashTimer.Enabled = false;
            this.Hide();
            Program.bmiform.Show();
        }
    }
}
