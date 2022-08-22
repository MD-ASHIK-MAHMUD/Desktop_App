using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Home1 : Form
    {
        public Home1()
        {
            InitializeComponent();
        }

        private void linkStores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Stores().Show();
            this.Hide();
        }

        private void linkProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new EmpProducts().Show();
            this.Hide();
        }

        private void linkAboutMarket_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new About().Show();
            this.Hide();
        }

        private void linkSignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void Home1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }
    }
}
