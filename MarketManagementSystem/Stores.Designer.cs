
namespace MarketManagementSystem
{
    partial class Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stores));
            this.linkBackStore = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStoreEmpID = new System.Windows.Forms.TextBox();
            this.btnSrchEmpStore = new System.Windows.Forms.Button();
            this.dataSearchEmpSearch = new System.Windows.Forms.DataGridView();
            this.btnShowEmpStores = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchEmpSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBackStore
            // 
            this.linkBackStore.AutoSize = true;
            this.linkBackStore.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkBackStore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBackStore.Location = new System.Drawing.Point(716, 407);
            this.linkBackStore.Name = "linkBackStore";
            this.linkBackStore.Size = new System.Drawing.Size(47, 20);
            this.linkBackStore.TabIndex = 0;
            this.linkBackStore.TabStop = true;
            this.linkBackStore.Text = "Back";
            this.linkBackStore.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackStore_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(71, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID :";
            // 
            // txtStoreEmpID
            // 
            this.txtStoreEmpID.Location = new System.Drawing.Point(74, 92);
            this.txtStoreEmpID.Name = "txtStoreEmpID";
            this.txtStoreEmpID.Size = new System.Drawing.Size(143, 22);
            this.txtStoreEmpID.TabIndex = 2;
            // 
            // btnSrchEmpStore
            // 
            this.btnSrchEmpStore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSrchEmpStore.Location = new System.Drawing.Point(104, 120);
            this.btnSrchEmpStore.Name = "btnSrchEmpStore";
            this.btnSrchEmpStore.Size = new System.Drawing.Size(75, 28);
            this.btnSrchEmpStore.TabIndex = 3;
            this.btnSrchEmpStore.Text = "Search";
            this.btnSrchEmpStore.UseVisualStyleBackColor = false;
            this.btnSrchEmpStore.Click += new System.EventHandler(this.btnSrchEmpStore_Click);
            // 
            // dataSearchEmpSearch
            // 
            this.dataSearchEmpSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchEmpSearch.Location = new System.Drawing.Point(243, 54);
            this.dataSearchEmpSearch.Name = "dataSearchEmpSearch";
            this.dataSearchEmpSearch.RowHeadersWidth = 51;
            this.dataSearchEmpSearch.RowTemplate.Height = 24;
            this.dataSearchEmpSearch.Size = new System.Drawing.Size(441, 110);
            this.dataSearchEmpSearch.TabIndex = 4;
            // 
            // btnShowEmpStores
            // 
            this.btnShowEmpStores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowEmpStores.Location = new System.Drawing.Point(74, 194);
            this.btnShowEmpStores.Name = "btnShowEmpStores";
            this.btnShowEmpStores.Size = new System.Drawing.Size(130, 35);
            this.btnShowEmpStores.TabIndex = 5;
            this.btnShowEmpStores.Text = "Show All Stores";
            this.btnShowEmpStores.UseVisualStyleBackColor = false;
            this.btnShowEmpStores.Click += new System.EventHandler(this.btnShowEmpStores_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(74, 235);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(610, 173);
            this.dataGridView1.TabIndex = 6;
            // 
            // Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnShowEmpStores);
            this.Controls.Add(this.dataSearchEmpSearch);
            this.Controls.Add(this.btnSrchEmpStore);
            this.Controls.Add(this.txtStoreEmpID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkBackStore);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stores";
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchEmpSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBackStore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStoreEmpID;
        private System.Windows.Forms.Button btnSrchEmpStore;
        private System.Windows.Forms.DataGridView dataSearchEmpSearch;
        private System.Windows.Forms.Button btnShowEmpStores;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}