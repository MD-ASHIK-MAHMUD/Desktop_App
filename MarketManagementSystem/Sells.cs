using DataAcessLayerMarketManagetment.Entities;
using DataAcessLayerMarketManagetment.Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketManagementSystem
{
    public partial class Sells : Form
    {
        public Sells()
        {
            InitializeComponent();
            

            
        }

        private void linkBackSells_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home2().Show();
            this.Hide();
        }

        private void btnSold_Click(object sender, EventArgs e)
        {
            ESells eSells = new ESells();
            eSells.PID = textBox1.Text;
            OSells oSells = new OSells(eSells);
            int effectedRows = oSells.AddStatusSold(eSells);
            if(effectedRows>0)
            {
                MessageBox.Show("Sold");
            }
            else { MessageBox.Show("Error"); }
        }

        private void btnNotSold_Click(object sender, EventArgs e)
        {
            ESells eSells = new ESells();
            eSells.PID = textBox1.Text;
            OSells oSells = new OSells(eSells);
            int effectedRows = oSells.AddStatusNotSold(eSells);
            if (effectedRows > 0)
            {
                MessageBox.Show("Not Sold");
            }
            else { MessageBox.Show("Error"); }

        }

        private void btnShowAllData_Click(object sender, EventArgs e)
        {
            ESells eSells = new ESells();
            OSells oSells = new OSells(eSells);
            SqlDataAdapter sqlDataAdapter = oSells.ShowAllInfo();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataShowAllInfo.DataSource = dataTable;
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            ESells eSells = new ESells();
            eSells.PID = textBox1.Text;
            eSells.Price = textBox2.Text;
            OSells oSells = new OSells(eSells);
            int effectedRows = oSells.Price(eSells);
            if (effectedRows > 0)
            {
                MessageBox.Show("Added");
            }
            else { MessageBox.Show("Error"); }
        }
    }
}
