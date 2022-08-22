using DataAcessLayerMarketManagetment.Entities;
using DataAcessLayerMarketManagetment.Operations;
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
    public partial class Admin_Sign_up : Form
    {
        public Admin_Sign_up()
        {
            InitializeComponent();
        }

       

        private void linkAdSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(txtAge.Text) >= 18)
            {
                if (txtAdName.Text != "" & txtAdEmail.Text != "" & txtAdNID.Text != "" & txtAdPass.Text != "" & txtAdPhoneNo.Text != "" & txtAdConfirmPass.Text != "")
                {
                    if (txtAdPass.Text == txtAdConfirmPass.Text)
                    {
                        EAdmin eAdmin = new EAdmin();
                        eAdmin.Adname = txtAdName.Text;
                        eAdmin.AdEmail = txtAdEmail.Text;
                        eAdmin.AdNID = txtAdNID.Text;
                        eAdmin.AdPhoneNo = txtAdPhoneNo.Text;
                        eAdmin.AdAdress = txtAdAdress.Text;

                        OAdmin oAdmin = new OAdmin(eAdmin);
                        int effectedRows = oAdmin.AdSignUp(eAdmin);
                        new Home2().Show();
                        this.Hide();
                        MessageBox.Show("Account created");
                    }
                    else
                    {
                        MessageBox.Show("Confirm Password not correct");
                    }

                }
                else
                {
                    MessageBox.Show("Every field should be filled");
                }
            }
            else 
            {
                MessageBox.Show("Your age is not eligable");
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            new Admin_Log_in().Show();
            this.Hide();
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime from = dateTimePicker1.Value;
            DateTime current = DateTime.Now;
            TimeSpan timeSpan = current - from;
            txtAge.Text = (timeSpan.TotalDays / 365).ToString("0");
        }
    }
}
