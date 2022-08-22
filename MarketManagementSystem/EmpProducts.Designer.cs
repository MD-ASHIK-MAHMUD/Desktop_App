
namespace MarketManagementSystem
{
    partial class EmpProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmpProducts));
            this.linkEmpPro = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmpProductId = new System.Windows.Forms.TextBox();
            this.txtEmpQuantity = new System.Windows.Forms.TextBox();
            this.txtEmpProductType = new System.Windows.Forms.TextBox();
            this.txtEmpProductName = new System.Windows.Forms.TextBox();
            this.btnAddEmpProduct = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDeleteEmpProduct = new System.Windows.Forms.TextBox();
            this.btnEmpSrchPro = new System.Windows.Forms.Button();
            this.btnUpdateEmpProduct = new System.Windows.Forms.Button();
            this.dataShowEmpProduct = new System.Windows.Forms.DataGridView();
            this.btnShowEmpPro = new System.Windows.Forms.Button();
            this.dataSrchResult = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProductUpdate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowEmpProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // linkEmpPro
            // 
            this.linkEmpPro.AutoSize = true;
            this.linkEmpPro.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkEmpPro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkEmpPro.Location = new System.Drawing.Point(694, 398);
            this.linkEmpPro.Name = "linkEmpPro";
            this.linkEmpPro.Size = new System.Drawing.Size(47, 20);
            this.linkEmpPro.TabIndex = 0;
            this.linkEmpPro.TabStop = true;
            this.linkEmpPro.Text = "Back";
            this.linkEmpPro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkEmpPro_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(80, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Product ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(56, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product Type :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(56, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Product Name :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(88, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quantity :";
            // 
            // txtEmpProductId
            // 
            this.txtEmpProductId.Location = new System.Drawing.Point(168, 49);
            this.txtEmpProductId.Name = "txtEmpProductId";
            this.txtEmpProductId.Size = new System.Drawing.Size(179, 22);
            this.txtEmpProductId.TabIndex = 5;
            // 
            // txtEmpQuantity
            // 
            this.txtEmpQuantity.Location = new System.Drawing.Point(168, 154);
            this.txtEmpQuantity.Name = "txtEmpQuantity";
            this.txtEmpQuantity.Size = new System.Drawing.Size(179, 22);
            this.txtEmpQuantity.TabIndex = 7;
            // 
            // txtEmpProductType
            // 
            this.txtEmpProductType.Location = new System.Drawing.Point(168, 118);
            this.txtEmpProductType.Name = "txtEmpProductType";
            this.txtEmpProductType.Size = new System.Drawing.Size(179, 22);
            this.txtEmpProductType.TabIndex = 8;
            // 
            // txtEmpProductName
            // 
            this.txtEmpProductName.Location = new System.Drawing.Point(168, 81);
            this.txtEmpProductName.Name = "txtEmpProductName";
            this.txtEmpProductName.Size = new System.Drawing.Size(179, 22);
            this.txtEmpProductName.TabIndex = 9;
            // 
            // btnAddEmpProduct
            // 
            this.btnAddEmpProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddEmpProduct.Location = new System.Drawing.Point(222, 182);
            this.btnAddEmpProduct.Name = "btnAddEmpProduct";
            this.btnAddEmpProduct.Size = new System.Drawing.Size(75, 27);
            this.btnAddEmpProduct.TabIndex = 10;
            this.btnAddEmpProduct.Text = "Add";
            this.btnAddEmpProduct.UseVisualStyleBackColor = false;
            this.btnAddEmpProduct.Click += new System.EventHandler(this.btnAddEmpProduct_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(72, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Product ID :";
            // 
            // txtDeleteEmpProduct
            // 
            this.txtDeleteEmpProduct.Location = new System.Drawing.Point(160, 231);
            this.txtDeleteEmpProduct.Name = "txtDeleteEmpProduct";
            this.txtDeleteEmpProduct.Size = new System.Drawing.Size(179, 22);
            this.txtDeleteEmpProduct.TabIndex = 12;
            // 
            // btnEmpSrchPro
            // 
            this.btnEmpSrchPro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnEmpSrchPro.Location = new System.Drawing.Point(345, 230);
            this.btnEmpSrchPro.Name = "btnEmpSrchPro";
            this.btnEmpSrchPro.Size = new System.Drawing.Size(75, 23);
            this.btnEmpSrchPro.TabIndex = 13;
            this.btnEmpSrchPro.Text = "Search";
            this.btnEmpSrchPro.UseVisualStyleBackColor = false;
            this.btnEmpSrchPro.Click += new System.EventHandler(this.btnEmpSrchPro_Click);
            // 
            // btnUpdateEmpProduct
            // 
            this.btnUpdateEmpProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdateEmpProduct.Location = new System.Drawing.Point(222, 290);
            this.btnUpdateEmpProduct.Name = "btnUpdateEmpProduct";
            this.btnUpdateEmpProduct.Size = new System.Drawing.Size(75, 29);
            this.btnUpdateEmpProduct.TabIndex = 14;
            this.btnUpdateEmpProduct.Text = "Update";
            this.btnUpdateEmpProduct.UseVisualStyleBackColor = false;
            this.btnUpdateEmpProduct.Click += new System.EventHandler(this.btnUpdateEmpProduct_Click);
            // 
            // dataShowEmpProduct
            // 
            this.dataShowEmpProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowEmpProduct.Location = new System.Drawing.Point(436, 77);
            this.dataShowEmpProduct.Name = "dataShowEmpProduct";
            this.dataShowEmpProduct.RowHeadersWidth = 51;
            this.dataShowEmpProduct.RowTemplate.Height = 24;
            this.dataShowEmpProduct.Size = new System.Drawing.Size(352, 303);
            this.dataShowEmpProduct.TabIndex = 15;
            // 
            // btnShowEmpPro
            // 
            this.btnShowEmpPro.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowEmpPro.Location = new System.Drawing.Point(558, 34);
            this.btnShowEmpPro.Name = "btnShowEmpPro";
            this.btnShowEmpPro.Size = new System.Drawing.Size(140, 37);
            this.btnShowEmpPro.TabIndex = 16;
            this.btnShowEmpPro.Text = "Show All Products";
            this.btnShowEmpPro.UseVisualStyleBackColor = false;
            this.btnShowEmpPro.Click += new System.EventHandler(this.btnShowEmpPro_Click);
            // 
            // dataSrchResult
            // 
            this.dataSrchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSrchResult.Location = new System.Drawing.Point(12, 325);
            this.dataSrchResult.Name = "dataSrchResult";
            this.dataSrchResult.RowHeadersWidth = 51;
            this.dataSrchResult.RowTemplate.Height = 24;
            this.dataSrchResult.Size = new System.Drawing.Size(418, 113);
            this.dataSrchResult.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(9, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Search Result :";
            // 
            // txtProductUpdate
            // 
            this.txtProductUpdate.Location = new System.Drawing.Point(159, 262);
            this.txtProductUpdate.Name = "txtProductUpdate";
            this.txtProductUpdate.Size = new System.Drawing.Size(179, 22);
            this.txtProductUpdate.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(35, 262);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Product Quantity :";
            // 
            // EmpProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataSrchResult);
            this.Controls.Add(this.btnShowEmpPro);
            this.Controls.Add(this.dataShowEmpProduct);
            this.Controls.Add(this.btnUpdateEmpProduct);
            this.Controls.Add(this.btnEmpSrchPro);
            this.Controls.Add(this.txtDeleteEmpProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddEmpProduct);
            this.Controls.Add(this.txtEmpProductName);
            this.Controls.Add(this.txtEmpProductType);
            this.Controls.Add(this.txtEmpQuantity);
            this.Controls.Add(this.txtEmpProductId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkEmpPro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EmpProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataShowEmpProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSrchResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkEmpPro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmpProductId;
        private System.Windows.Forms.TextBox txtEmpQuantity;
        private System.Windows.Forms.TextBox txtEmpProductType;
        private System.Windows.Forms.TextBox txtEmpProductName;
        private System.Windows.Forms.Button btnAddEmpProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDeleteEmpProduct;
        private System.Windows.Forms.Button btnEmpSrchPro;
        private System.Windows.Forms.Button btnUpdateEmpProduct;
        private System.Windows.Forms.DataGridView dataShowEmpProduct;
        private System.Windows.Forms.Button btnShowEmpPro;
        private System.Windows.Forms.DataGridView dataSrchResult;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProductUpdate;
        private System.Windows.Forms.Label label7;
    }
}