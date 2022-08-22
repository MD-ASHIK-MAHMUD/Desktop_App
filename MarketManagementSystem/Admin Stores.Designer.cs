
namespace MarketManagementSystem
{
    partial class Admin_Stores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Stores));
            this.linkBack = new System.Windows.Forms.LinkLabel();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.lblStoreId = new System.Windows.Forms.Label();
            this.btnAddStore = new System.Windows.Forms.Button();
            this.txtStoreName = new System.Windows.Forms.TextBox();
            this.txtStoreId = new System.Windows.Forms.TextBox();
            this.lblStoreTyp = new System.Windows.Forms.Label();
            this.txtSType = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDltStoreId = new System.Windows.Forms.TextBox();
            this.btnDeleteAdStores = new System.Windows.Forms.Button();
            this.dataSearchAdStore = new System.Windows.Forms.DataGridView();
            this.dataShowAdStore = new System.Windows.Forms.DataGridView();
            this.btnShowStores = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSNo = new System.Windows.Forms.TextBox();
            this.btnSearchStores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchAdStore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAdStore)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBack
            // 
            this.linkBack.AutoSize = true;
            this.linkBack.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBack.Location = new System.Drawing.Point(690, 409);
            this.linkBack.Name = "linkBack";
            this.linkBack.Size = new System.Drawing.Size(47, 20);
            this.linkBack.TabIndex = 0;
            this.linkBack.TabStop = true;
            this.linkBack.Text = "Back";
            this.linkBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBack_LinkClicked);
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreName.Location = new System.Drawing.Point(110, 66);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(91, 17);
            this.lblStoreName.TabIndex = 1;
            this.lblStoreName.Text = "Store Name :";
            // 
            // lblStoreId
            // 
            this.lblStoreId.AutoSize = true;
            this.lblStoreId.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreId.Location = new System.Drawing.Point(172, 98);
            this.lblStoreId.Name = "lblStoreId";
            this.lblStoreId.Size = new System.Drawing.Size(29, 17);
            this.lblStoreId.TabIndex = 2;
            this.lblStoreId.Text = "ID :";
            // 
            // btnAddStore
            // 
            this.btnAddStore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAddStore.Location = new System.Drawing.Point(289, 177);
            this.btnAddStore.Name = "btnAddStore";
            this.btnAddStore.Size = new System.Drawing.Size(75, 27);
            this.btnAddStore.TabIndex = 3;
            this.btnAddStore.Text = "Add";
            this.btnAddStore.UseVisualStyleBackColor = false;
            this.btnAddStore.Click += new System.EventHandler(this.btnAddStore_Click);
            // 
            // txtStoreName
            // 
            this.txtStoreName.Location = new System.Drawing.Point(207, 66);
            this.txtStoreName.Name = "txtStoreName";
            this.txtStoreName.Size = new System.Drawing.Size(157, 22);
            this.txtStoreName.TabIndex = 4;
            // 
            // txtStoreId
            // 
            this.txtStoreId.Location = new System.Drawing.Point(207, 93);
            this.txtStoreId.Name = "txtStoreId";
            this.txtStoreId.Size = new System.Drawing.Size(157, 22);
            this.txtStoreId.TabIndex = 5;
            // 
            // lblStoreTyp
            // 
            this.lblStoreTyp.AutoSize = true;
            this.lblStoreTyp.BackColor = System.Drawing.Color.Transparent;
            this.lblStoreTyp.Location = new System.Drawing.Point(115, 152);
            this.lblStoreTyp.Name = "lblStoreTyp";
            this.lblStoreTyp.Size = new System.Drawing.Size(86, 17);
            this.lblStoreTyp.TabIndex = 6;
            this.lblStoreTyp.Text = "Store Type :";
            // 
            // txtSType
            // 
            this.txtSType.Location = new System.Drawing.Point(207, 149);
            this.txtSType.Name = "txtSType";
            this.txtSType.Size = new System.Drawing.Size(157, 22);
            this.txtSType.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID :";
            // 
            // txtDltStoreId
            // 
            this.txtDltStoreId.Location = new System.Drawing.Point(73, 212);
            this.txtDltStoreId.Name = "txtDltStoreId";
            this.txtDltStoreId.Size = new System.Drawing.Size(186, 22);
            this.txtDltStoreId.TabIndex = 9;
            // 
            // btnDeleteAdStores
            // 
            this.btnDeleteAdStores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDeleteAdStores.Location = new System.Drawing.Point(73, 240);
            this.btnDeleteAdStores.Name = "btnDeleteAdStores";
            this.btnDeleteAdStores.Size = new System.Drawing.Size(80, 42);
            this.btnDeleteAdStores.TabIndex = 10;
            this.btnDeleteAdStores.Text = "Delete";
            this.btnDeleteAdStores.UseVisualStyleBackColor = false;
            this.btnDeleteAdStores.Click += new System.EventHandler(this.btnDeleteAdStores_Click);
            // 
            // dataSearchAdStore
            // 
            this.dataSearchAdStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchAdStore.Location = new System.Drawing.Point(12, 288);
            this.dataSearchAdStore.Name = "dataSearchAdStore";
            this.dataSearchAdStore.RowHeadersWidth = 51;
            this.dataSearchAdStore.RowTemplate.Height = 24;
            this.dataSearchAdStore.Size = new System.Drawing.Size(377, 150);
            this.dataSearchAdStore.TabIndex = 14;
            // 
            // dataShowAdStore
            // 
            this.dataShowAdStore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowAdStore.Location = new System.Drawing.Point(395, 71);
            this.dataShowAdStore.Name = "dataShowAdStore";
            this.dataShowAdStore.RowHeadersWidth = 51;
            this.dataShowAdStore.RowTemplate.Height = 24;
            this.dataShowAdStore.Size = new System.Drawing.Size(393, 318);
            this.dataShowAdStore.TabIndex = 15;
            // 
            // btnShowStores
            // 
            this.btnShowStores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowStores.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowStores.Location = new System.Drawing.Point(546, 39);
            this.btnShowStores.Name = "btnShowStores";
            this.btnShowStores.Size = new System.Drawing.Size(138, 26);
            this.btnShowStores.TabIndex = 16;
            this.btnShowStores.Text = "Show All Store";
            this.btnShowStores.UseVisualStyleBackColor = false;
            this.btnShowStores.Click += new System.EventHandler(this.btnShowStores_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(95, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Serial Number :";
            // 
            // txtSNo
            // 
            this.txtSNo.Location = new System.Drawing.Point(207, 121);
            this.txtSNo.Name = "txtSNo";
            this.txtSNo.Size = new System.Drawing.Size(157, 22);
            this.txtSNo.TabIndex = 18;
            // 
            // btnSearchStores
            // 
            this.btnSearchStores.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchStores.Location = new System.Drawing.Point(184, 240);
            this.btnSearchStores.Name = "btnSearchStores";
            this.btnSearchStores.Size = new System.Drawing.Size(75, 42);
            this.btnSearchStores.TabIndex = 19;
            this.btnSearchStores.Text = "Search";
            this.btnSearchStores.UseVisualStyleBackColor = false;
            this.btnSearchStores.Click += new System.EventHandler(this.btnSearchStores_Click);
            // 
            // Admin_Stores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearchStores);
            this.Controls.Add(this.txtSNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowStores);
            this.Controls.Add(this.dataShowAdStore);
            this.Controls.Add(this.dataSearchAdStore);
            this.Controls.Add(this.btnDeleteAdStores);
            this.Controls.Add(this.txtDltStoreId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSType);
            this.Controls.Add(this.lblStoreTyp);
            this.Controls.Add(this.txtStoreId);
            this.Controls.Add(this.txtStoreName);
            this.Controls.Add(this.btnAddStore);
            this.Controls.Add(this.lblStoreId);
            this.Controls.Add(this.lblStoreName);
            this.Controls.Add(this.linkBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin_Stores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stores";
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchAdStore)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAdStore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBack;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.Label lblStoreId;
        private System.Windows.Forms.Button btnAddStore;
        private System.Windows.Forms.TextBox txtStoreName;
        private System.Windows.Forms.TextBox txtStoreId;
        private System.Windows.Forms.Label lblStoreTyp;
        private System.Windows.Forms.TextBox txtSType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDltStoreId;
        private System.Windows.Forms.Button btnDeleteAdStores;
        private System.Windows.Forms.DataGridView dataSearchAdStore;
        private System.Windows.Forms.DataGridView dataShowAdStore;
        private System.Windows.Forms.Button btnShowStores;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSNo;
        private System.Windows.Forms.Button btnSearchStores;
    }
}