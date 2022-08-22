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
    public partial class AdmProducts : Form
    {
        public AdmProducts()
        {
            InitializeComponent();
        }

        private void linkBackProducts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home2().Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            eProduct.PID = txtProductId.Text;

            OProduct oProduct = new OProduct(eProduct);
            SqlDataAdapter sqlDataAdapter = oProduct.SrchFromAdmin();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataSrchAdProduct.DataSource = dataTable;

        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (txtProductId.Text != "")
            {
                EProduct eProduct = new EProduct();
                eProduct.PID = txtProductId.Text;

                OProduct oProduct = new OProduct(eProduct);
                int effectedRows = oProduct.DeleteProduct(eProduct);
                //int effectedRows = oProduct.DltFromSells(eProduct);
                if (effectedRows > 0)
                {
                    MessageBox.Show("Product deleted");
                }
                else { MessageBox.Show("Error during delete product"); }
            }
            else
            {
                MessageBox.Show("Please Enter a Product ID");
            }
        }

        private void btnShowAdProducts_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            OProduct oProduct = new OProduct(eProduct);
            SqlDataAdapter sqlDataAdapter = oProduct.ShowAllProduct();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
