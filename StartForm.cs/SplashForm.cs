﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StartForm.cs
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void TimerSplashForm_Tick(object sender, EventArgs e)
        {
            TimerSplashForm.Enabled = false;

            StartForm startForm = new StartForm();
            startForm.Show();
            this.Hide();
        }
    }
}
