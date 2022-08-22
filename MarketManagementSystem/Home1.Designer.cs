
namespace MarketManagementSystem
{
    partial class Home1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home1));
            this.label1 = new System.Windows.Forms.Label();
            this.linkSignOut = new System.Windows.Forms.LinkLabel();
            this.linkStores = new System.Windows.Forms.LinkLabel();
            this.linkProducts = new System.Windows.Forms.LinkLabel();
            this.linkAboutMarket = new System.Windows.Forms.LinkLabel();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(152, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Market Management System";
            // 
            // linkSignOut
            // 
            this.linkSignOut.AutoSize = true;
            this.linkSignOut.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkSignOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignOut.Location = new System.Drawing.Point(671, 401);
            this.linkSignOut.Name = "linkSignOut";
            this.linkSignOut.Size = new System.Drawing.Size(74, 20);
            this.linkSignOut.TabIndex = 1;
            this.linkSignOut.TabStop = true;
            this.linkSignOut.Text = "Sign Out";
            this.linkSignOut.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignOut_LinkClicked);
            // 
            // linkStores
            // 
            this.linkStores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkStores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkStores.Location = new System.Drawing.Point(288, 142);
            this.linkStores.Name = "linkStores";
            this.linkStores.Size = new System.Drawing.Size(72, 29);
            this.linkStores.TabIndex = 2;
            this.linkStores.TabStop = true;
            this.linkStores.Text = "Stores";
            this.linkStores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkStores_LinkClicked);
            // 
            // linkProducts
            // 
            this.linkProducts.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkProducts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProducts.Location = new System.Drawing.Point(288, 196);
            this.linkProducts.Name = "linkProducts";
            this.linkProducts.Size = new System.Drawing.Size(83, 27);
            this.linkProducts.TabIndex = 3;
            this.linkProducts.TabStop = true;
            this.linkProducts.Text = "Products";
            this.linkProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProducts_LinkClicked);
            // 
            // linkAboutMarket
            // 
            this.linkAboutMarket.AutoSize = true;
            this.linkAboutMarket.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkAboutMarket.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAboutMarket.Location = new System.Drawing.Point(288, 256);
            this.linkAboutMarket.Name = "linkAboutMarket";
            this.linkAboutMarket.Size = new System.Drawing.Size(58, 22);
            this.linkAboutMarket.TabIndex = 6;
            this.linkAboutMarket.TabStop = true;
            this.linkAboutMarket.Text = "About";
            this.linkAboutMarket.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAboutMarket_LinkClicked);
            // 
            // lblTime
            // 
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(12, 396);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(191, 44);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "Time";
            // 
            // lblDate
            // 
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(565, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(223, 44);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.linkAboutMarket);
            this.Controls.Add(this.linkProducts);
            this.Controls.Add(this.linkStores);
            this.Controls.Add(this.linkSignOut);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkSignOut;
        private System.Windows.Forms.LinkLabel linkStores;
        private System.Windows.Forms.LinkLabel linkProducts;
        private System.Windows.Forms.LinkLabel linkAboutMarket;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
    }
}