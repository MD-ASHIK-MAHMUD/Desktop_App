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
    public partial class Admin_Log_in : Form
    {
        public Admin_Log_in()
        {
            InitializeComponent();
        }

        private void linkAdLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home2().Show();
            this.Hide();
        }

        private void linkUserLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_Sign_up().Show();
            this.Hide();
        }
    }
}
