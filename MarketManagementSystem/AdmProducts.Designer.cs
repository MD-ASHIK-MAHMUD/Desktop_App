
namespace MarketManagementSystem
{
    partial class AdmProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdmProducts));
            this.linkBackProducts = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.lblAdProduct = new System.Windows.Forms.Label();
            this.dataSrchAdProduct = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnShowAdProducts = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchAdProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBackProducts
            // 
            this.linkBackProducts.AutoSize = true;
            this.linkBackProducts.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkBackProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBackProducts.Location = new System.Drawing.Point(700, 407);
            this.linkBackProducts.Name = "linkBackProducts";
            this.linkBackProducts.Size = new System.Drawing.Size(47, 20);
            this.linkBackProducts.TabIndex = 0;
            this.linkBackProducts.TabStop = true;
            this.linkBackProducts.Text = "Back";
            this.linkBackProducts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackProducts_LinkClicked);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(123, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(123, 87);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.Size = new System.Drawing.Size(206, 22);
            this.txtProductId.TabIndex = 2;
            // 
            // lblAdProduct
            // 
            this.lblAdProduct.AutoSize = true;
            this.lblAdProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblAdProduct.Location = new System.Drawing.Point(35, 90);
            this.lblAdProduct.Name = "lblAdProduct";
            this.lblAdProduct.Size = new System.Drawing.Size(82, 17);
            this.lblAdProduct.TabIndex = 3;
            this.lblAdProduct.Text = "Product ID :";
            // 
            // dataSrchAdProduct
            // 
            this.dataSrchAdProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSrchAdProduct.Location = new System.Drawing.Point(12, 226);
            this.dataSrchAdProduct.Name = "dataSrchAdProduct";
            this.dataSrchAdProduct.RowHeadersWidth = 51;
            this.dataSrchAdProduct.RowTemplate.Height = 24;
            this.dataSrchAdProduct.Size = new System.Drawing.Size(382, 167);
            this.dataSrchAdProduct.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Search Result :";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(400, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(388, 306);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnShowAdProducts
            // 
            this.btnShowAdProducts.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAdProducts.Location = new System.Drawing.Point(534, 48);
            this.btnShowAdProducts.Name = "btnShowAdProducts";
            this.btnShowAdProducts.Size = new System.Drawing.Size(152, 33);
            this.btnShowAdProducts.TabIndex = 7;
            this.btnShowAdProducts.Text = "Show All Products";
            this.btnShowAdProducts.UseVisualStyleBackColor = false;
            this.btnShowAdProducts.Click += new System.EventHandler(this.btnShowAdProducts_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteProduct.Location = new System.Drawing.Point(248, 127);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(81, 31);
            this.btnDeleteProduct.TabIndex = 8;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // AdmProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnShowAdProducts);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataSrchAdProduct);
            this.Controls.Add(this.lblAdProduct);
            this.Controls.Add(this.txtProductId);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.linkBackProducts);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdmProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchAdProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBackProducts;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.Label lblAdProduct;
        private System.Windows.Forms.DataGridView dataSrchAdProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnShowAdProducts;
        private System.Windows.Forms.Button btnDeleteProduct;
    }
}