
namespace MarketManagementSystem
{
    partial class Sells
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sells));
            this.linkBackSells = new System.Windows.Forms.LinkLabel();
            this.btnSold = new System.Windows.Forms.Button();
            this.btnNotSold = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataShowAllInfo = new System.Windows.Forms.DataGridView();
            this.btnShowAllData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnPrice = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAllInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBackSells
            // 
            this.linkBackSells.AutoSize = true;
            this.linkBackSells.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkBackSells.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBackSells.Location = new System.Drawing.Point(687, 399);
            this.linkBackSells.Name = "linkBackSells";
            this.linkBackSells.Size = new System.Drawing.Size(47, 20);
            this.linkBackSells.TabIndex = 0;
            this.linkBackSells.TabStop = true;
            this.linkBackSells.Text = "Back";
            this.linkBackSells.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackSells_LinkClicked);
            // 
            // btnSold
            // 
            this.btnSold.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSold.Location = new System.Drawing.Point(517, 38);
            this.btnSold.Name = "btnSold";
            this.btnSold.Size = new System.Drawing.Size(93, 31);
            this.btnSold.TabIndex = 1;
            this.btnSold.Text = "Sold";
            this.btnSold.UseVisualStyleBackColor = false;
            this.btnSold.Click += new System.EventHandler(this.btnSold_Click);
            // 
            // btnNotSold
            // 
            this.btnNotSold.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnNotSold.Location = new System.Drawing.Point(616, 38);
            this.btnNotSold.Name = "btnNotSold";
            this.btnNotSold.Size = new System.Drawing.Size(81, 31);
            this.btnNotSold.TabIndex = 2;
            this.btnNotSold.Text = "Not Sold";
            this.btnNotSold.UseVisualStyleBackColor = false;
            this.btnNotSold.Click += new System.EventHandler(this.btnNotSold_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(256, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 22);
            this.textBox1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(212, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "PID :";
            // 
            // dataShowAllInfo
            // 
            this.dataShowAllInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowAllInfo.Location = new System.Drawing.Point(12, 191);
            this.dataShowAllInfo.Name = "dataShowAllInfo";
            this.dataShowAllInfo.RowHeadersWidth = 51;
            this.dataShowAllInfo.RowTemplate.Height = 24;
            this.dataShowAllInfo.Size = new System.Drawing.Size(624, 215);
            this.dataShowAllInfo.TabIndex = 5;
            // 
            // btnShowAllData
            // 
            this.btnShowAllData.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowAllData.Location = new System.Drawing.Point(12, 150);
            this.btnShowAllData.Name = "btnShowAllData";
            this.btnShowAllData.Size = new System.Drawing.Size(143, 35);
            this.btnShowAllData.TabIndex = 6;
            this.btnShowAllData.Text = "Show All Data";
            this.btnShowAllData.UseVisualStyleBackColor = false;
            this.btnShowAllData.Click += new System.EventHandler(this.btnShowAllData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(202, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Price :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(256, 75);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 22);
            this.textBox2.TabIndex = 8;
            // 
            // btnPrice
            // 
            this.btnPrice.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPrice.Location = new System.Drawing.Point(326, 103);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(121, 31);
            this.btnPrice.TabIndex = 9;
            this.btnPrice.Text = "Update Price";
            this.btnPrice.UseVisualStyleBackColor = false;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // Sells
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnShowAllData);
            this.Controls.Add(this.dataShowAllInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnNotSold);
            this.Controls.Add(this.btnSold);
            this.Controls.Add(this.linkBackSells);
            this.Name = "Sells";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sells";
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAllInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBackSells;
        private System.Windows.Forms.Button btnSold;
        private System.Windows.Forms.Button btnNotSold;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataShowAllInfo;
        private System.Windows.Forms.Button btnShowAllData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnPrice;
    }
}