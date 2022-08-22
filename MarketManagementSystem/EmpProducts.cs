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
    public partial class EmpProducts : Form
    {
        public object EProduct { get; private set; }

        public EmpProducts()
        {
            InitializeComponent();
        }

        private void linkEmpPro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Home1().Show();
            this.Hide();
        }

        private void btnAddEmpProduct_Click(object sender, EventArgs e)
        {
            if (txtEmpProductId.Text != "" & txtEmpProductName.Text != "" & txtEmpProductType.Text != "" & txtEmpQuantity.Text != "")
            {
                EProduct eProduct = new EProduct();
                eProduct.PID = txtEmpProductId.Text;
                eProduct.PName = txtEmpProductName.Text;
                eProduct.PType = txtEmpProductType.Text;
                eProduct.PQuantity = txtEmpQuantity.Text;

                OProduct oProduct = new OProduct(eProduct);
                int effectedRows = oProduct.AddProducts(eProduct);
                effectedRows = oProduct.CopyPID(eProduct);
                MessageBox.Show("Product has been added");
            }
            else
            {
                MessageBox.Show("Please fill up every feild");
            }
        }

        private void btnEmpSrchPro_Click(object sender, EventArgs e)
        {
            if(txtDeleteEmpProduct.Text !="")
            {
                EProduct eProduct = new EProduct();
                eProduct.PID = txtDeleteEmpProduct.Text;

                OProduct oProduct = new OProduct(eProduct);
                SqlDataAdapter sqlDataAdapter = oProduct.SrchProduct();
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                dataSrchResult.DataSource = dataTable;
            }
            else { MessageBox.Show("Please Enter a Product ID"); }
        }

        private void btnUpdateEmpProduct_Click(object sender, EventArgs e)
        {
            if(txtDeleteEmpProduct.Text !="")
            {
                EProduct eProduct = new EProduct();
                eProduct.PID = txtDeleteEmpProduct.Text;
                eProduct.PQuantity = txtProductUpdate.Text;

                OProduct oProduct = new OProduct(eProduct);
                int effectedRows = oProduct.UpdateProduct(eProduct);
                
                if(effectedRows>0)
                {
                    MessageBox.Show("Product updated");

                }
                else
                {
                    MessageBox.Show("Error to Update Product");
                }
            }
            else
            {
                MessageBox.Show("Please Enter a Product ID");
            }
        }

        private void btnShowEmpPro_Click(object sender, EventArgs e)
        {
            EProduct eProduct = new EProduct();
            OProduct oProduct = new OProduct(eProduct);
            SqlDataAdapter sqlDataAdapter = oProduct.ShowAllProduct();
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataShowEmpProduct.DataSource = dataTable;
        }
    }
}
