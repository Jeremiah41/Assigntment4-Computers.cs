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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void ButtonStartOrder_Click(object sender, EventArgs e)
        {
            SelectForm SelectForm = new SelectForm();
            SelectForm.Show();
            this.Hide();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
