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
    public partial class Stores : Form
    {
        public Stores()
        {
            InitializeComponent();
        }

        private void linkBackStore_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home1().Show();
            this.Hide();
        }

        private void btnSrchEmpStore_Click(object sender, EventArgs e)
        {
            if (txtStoreEmpID.Text != "")
            {
                EStore eStore = new EStore();
                eStore.SID = txtStoreEmpID.Text;
                OStore oStore = new OStore(eStore);
                SqlDataAdapter sqlDataAdapter = oStore.SrchStore();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataSearchEmpSearch.DataSource = dataTable;

            }
            else
            {
                MessageBox.Show("Please Enter a Store ID");
            }
        }

        private void btnShowEmpStores_Click(object sender, EventArgs e)
        {
            EStore eStore = new EStore();
            OStore oStore = new OStore(eStore);
            SqlDataAdapter sqlDataAdapter = oStore.ShowAllEmpStore();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
