
namespace MarketManagementSystem
{
    partial class Home2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home2));
            this.linkEmp = new System.Windows.Forms.LinkLabel();
            this.linkSells = new System.Windows.Forms.LinkLabel();
            this.linkSignOut1 = new System.Windows.Forms.LinkLabel();
            this.linkProducts1 = new System.Windows.Forms.LinkLabel();
            this.linkAdStores = new System.Windows.Forms.LinkLabel();
            this.btnAdmins = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkEmp
            // 
            this.linkEmp.AutoSize = true;
            this.linkEmp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkEmp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEmp.Location = new System.Drawing.Point(186, 78);
            this.linkEmp.Name = "linkEmp";
            this.linkEmp.Size = new System.Drawing.Size(87, 22);
            this.linkEmp.TabIndex = 0;
            this.linkEmp.TabStop = true;
            this.linkEmp.Text = "Emloyees";
            this.linkEmp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmp_LinkClicked);
            // 
            // linkSells
            // 
            this.linkSells.AutoSize = true;
            this.linkSells.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkSells.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSells.Location = new System.Drawing.Point(186, 274);
            this.linkSells.Name = "linkSells";
            this.linkSells.Size = new System.Drawing.Size(50, 22);
            this.linkSells.TabIndex = 1;
            this.linkSells.TabStop = true;
            this.linkSells.Text = "Sells";
            this.linkSells.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSells_LinkClicked);
            // 
            // linkSignOut1
            // 
            this.linkSignOut1.AutoSize = true;
            this.linkSignOut1.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkSignOut1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkSignOut1.Location = new System.Drawing.Point(695, 395);
            this.linkSignOut1.Name = "linkSignOut1";
            this.linkSignOut1.Size = new System.Drawing.Size(70, 20);
            this.linkSignOut1.TabIndex = 2;
            this.linkSignOut1.TabStop = true;
            this.linkSignOut1.Text = "Sign out";
            this.linkSignOut1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSignOut1_LinkClicked);
            // 
            // linkProducts1
            // 
            this.linkProducts1.AutoSize = true;
            this.linkProducts1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkProducts1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkProducts1.Location = new System.Drawing.Point(186, 139);
            this.linkProducts1.Name = "linkProducts1";
            this.linkProducts1.Size = new System.Drawing.Size(79, 22);
            this.linkProducts1.TabIndex = 3;
            this.linkProducts1.TabStop = true;
            this.linkProducts1.Text = "Products";
            this.linkProducts1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkProducts1_LinkClicked);
            // 
            // linkAdStores
            // 
            this.linkAdStores.AutoSize = true;
            this.linkAdStores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.linkAdStores.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkAdStores.Location = new System.Drawing.Point(186, 205);
            this.linkAdStores.Name = "linkAdStores";
            this.linkAdStores.Size = new System.Drawing.Size(60, 22);
            this.linkAdStores.TabIndex = 4;
            this.linkAdStores.TabStop = true;
            this.linkAdStores.Text = "Stores";
            this.linkAdStores.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkAdStores_LinkClicked);
            // 
            // btnAdmins
            // 
            this.btnAdmins.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdmins.Location = new System.Drawing.Point(625, 294);
            this.btnAdmins.Name = "btnAdmins";
            this.btnAdmins.Size = new System.Drawing.Size(163, 28);
            this.btnAdmins.TabIndex = 5;
            this.btnAdmins.Text = "See All Admins";
            this.btnAdmins.UseVisualStyleBackColor = false;
            this.btnAdmins.Click += new System.EventHandler(this.btnAdmins_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(379, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(409, 205);
            this.dataGridView1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(357, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(45, 20);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(22, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 24);
            this.lblTime.TabIndex = 8;
            this.lblTime.Text = "Time";
            // 
            // Home2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAdmins);
            this.Controls.Add(this.linkAdStores);
            this.Controls.Add(this.linkProducts1);
            this.Controls.Add(this.linkSignOut1);
            this.Controls.Add(this.linkSells);
            this.Controls.Add(this.linkEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkEmp;
        private System.Windows.Forms.LinkLabel linkSells;
        private System.Windows.Forms.LinkLabel linkSignOut1;
        private System.Windows.Forms.LinkLabel linkProducts1;
        private System.Windows.Forms.LinkLabel linkAdStores;
        private System.Windows.Forms.Button btnAdmins;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblTime;
    }
}