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
    public partial class Home2 : Form
    {
        public Home2()
        {
            InitializeComponent();
        }

        private void linkSignOut1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void linkEmp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            new Employees().Show();
            this.Hide();
        }

        private void linkSells_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Sells().Show();
            this.Hide();
        }

        private void linkProducts1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new AdmProducts().Show();
            this.Hide();
        }

        private void linkAdStores_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_Stores().Show();
            this.Hide();
        }

        private void btnAdmins_Click(object sender, EventArgs e)
        {
            EAdmin eAdmin = new EAdmin();
            OAdmin oAdmin = new OAdmin(eAdmin);
            SqlDataAdapter sqlDataAdapter = oAdmin.showAllAdmin();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Home2_Load(object sender, EventArgs e)
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
