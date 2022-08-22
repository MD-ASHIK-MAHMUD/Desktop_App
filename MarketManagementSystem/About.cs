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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void linkBackAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home1().Show();
            this.Hide();
        }
    }
}
