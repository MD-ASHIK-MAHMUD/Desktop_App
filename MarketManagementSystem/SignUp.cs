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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void linkSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Convert.ToInt32(txtAge.Text) >= 18)
            {
                if ((txtUserName.Text != "") & (txtEmpNID.Text != "") & (txtPassword.Text != "") & (txtPhoneNum.Text != ""))
                {
                    if (txtPassword.Text == txtConfirmPassword.Text)
                    {
                        EemployeeInfo eemployeeInfo = new EemployeeInfo();


                        try { eemployeeInfo.Name = txtUserName.Text; }
                        catch { }

                        try { eemployeeInfo.Email = txtEmail.Text; }
                        catch { }

                        try { eemployeeInfo.NID = txtEmpNID.Text; }
                        catch { }

                        try { eemployeeInfo.PhoneNo = txtPhoneNum.Text; }
                        catch { }


                        OemployeeInfo oemployeeInfo = new OemployeeInfo(eemployeeInfo);
                        int effectedRows = oemployeeInfo.SignUpEmp(eemployeeInfo);
                        new Home1().Show();
                        this.Hide();
                        MessageBox.Show("Account Created");
                        effectedRows = oemployeeInfo.CopyEmp(eemployeeInfo);

                    }
                    else
                    {
                        MessageBox.Show("Confirm password was not correct");
                    }
                }
                else
                {
                    MessageBox.Show("All filed must be filled");
                }
            }
            else
            {
                MessageBox.Show("You are not eligable for this job");
            }

            


        }

        private void linkLogIn2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void linkAdSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Admin_Sign_up().Show();
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
