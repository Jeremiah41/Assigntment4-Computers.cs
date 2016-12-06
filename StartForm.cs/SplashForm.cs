using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//App Name: Corperate Computers
//Author's Name: Jeremiah Hughes
//Student ID: 200318676
//App Creation Date: 11/30/2016
//App Description: Corperate Computers helps people like trump Equip themselves with the brains they need to take over america.
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

        private void SplashForm_Load(object sender, EventArgs e)
        {

        }
    }
}
