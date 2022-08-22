
namespace MarketManagementSystem
{
    partial class Employees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            this.linkBackEmp = new System.Windows.Forms.LinkLabel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtSrchNid = new System.Windows.Forms.TextBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.dataSearchViewEmp = new System.Windows.Forms.DataGridView();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDltEmp = new System.Windows.Forms.Button();
            this.dataShowAllEmp = new System.Windows.Forms.DataGridView();
            this.btnShowEmp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpPost = new System.Windows.Forms.TextBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAssignNID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchViewEmp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAllEmp)).BeginInit();
            this.SuspendLayout();
            // 
            // linkBackEmp
            // 
            this.linkBackEmp.AutoSize = true;
            this.linkBackEmp.BackColor = System.Drawing.SystemColors.Highlight;
            this.linkBackEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkBackEmp.Location = new System.Drawing.Point(699, 406);
            this.linkBackEmp.Name = "linkBackEmp";
            this.linkBackEmp.Size = new System.Drawing.Size(47, 20);
            this.linkBackEmp.TabIndex = 0;
            this.linkBackEmp.TabStop = true;
            this.linkBackEmp.Text = "Back";
            this.linkBackEmp.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkBackEmp_LinkClicked);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Location = new System.Drawing.Point(70, 162);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "NID :";
            // 
            // txtSrchNid
            // 
            this.txtSrchNid.Location = new System.Drawing.Point(123, 157);
            this.txtSrchNid.Name = "txtSrchNid";
            this.txtSrchNid.Size = new System.Drawing.Size(232, 22);
            this.txtSrchNid.TabIndex = 2;
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSearchEmp.Location = new System.Drawing.Point(147, 185);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(78, 35);
            this.btnSearchEmp.TabIndex = 3;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = false;
            this.btnSearchEmp.Click += new System.EventHandler(this.btnSearchEmp_Click);
            // 
            // dataSearchViewEmp
            // 
            this.dataSearchViewEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchViewEmp.Location = new System.Drawing.Point(7, 243);
            this.dataSearchViewEmp.Name = "dataSearchViewEmp";
            this.dataSearchViewEmp.RowHeadersWidth = 51;
            this.dataSearchViewEmp.RowTemplate.Height = 24;
            this.dataSearchViewEmp.Size = new System.Drawing.Size(412, 149);
            this.dataSearchViewEmp.TabIndex = 4;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.Transparent;
            this.lblSearch.Location = new System.Drawing.Point(4, 223);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(105, 17);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search Result :";
            // 
            // btnDltEmp
            // 
            this.btnDltEmp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDltEmp.Location = new System.Drawing.Point(246, 185);
            this.btnDltEmp.Name = "btnDltEmp";
            this.btnDltEmp.Size = new System.Drawing.Size(82, 35);
            this.btnDltEmp.TabIndex = 6;
            this.btnDltEmp.Text = "Delete";
            this.btnDltEmp.UseVisualStyleBackColor = false;
            this.btnDltEmp.Click += new System.EventHandler(this.btnDltEmp_Click);
            // 
            // dataShowAllEmp
            // 
            this.dataShowAllEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataShowAllEmp.Location = new System.Drawing.Point(425, 54);
            this.dataShowAllEmp.Name = "dataShowAllEmp";
            this.dataShowAllEmp.RowHeadersWidth = 51;
            this.dataShowAllEmp.RowTemplate.Height = 24;
            this.dataShowAllEmp.Size = new System.Drawing.Size(363, 338);
            this.dataShowAllEmp.TabIndex = 7;
            // 
            // btnShowEmp
            // 
            this.btnShowEmp.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnShowEmp.Location = new System.Drawing.Point(550, 18);
            this.btnShowEmp.Name = "btnShowEmp";
            this.btnShowEmp.Size = new System.Drawing.Size(150, 30);
            this.btnShowEmp.TabIndex = 8;
            this.btnShowEmp.Text = "Show All Employee";
            this.btnShowEmp.UseVisualStyleBackColor = false;
            this.btnShowEmp.Click += new System.EventHandler(this.btnShowEmp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(19, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Assign Post :";
            // 
            // txtEmpPost
            // 
            this.txtEmpPost.Location = new System.Drawing.Point(115, 54);
            this.txtEmpPost.Name = "txtEmpPost";
            this.txtEmpPost.Size = new System.Drawing.Size(232, 22);
            this.txtEmpPost.TabIndex = 10;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAssign.Location = new System.Drawing.Point(187, 82);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(89, 32);
            this.btnAssign.TabIndex = 11;
            this.btnAssign.Text = "Assign";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(70, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "NID :";
            // 
            // txtAssignNID
            // 
            this.txtAssignNID.Location = new System.Drawing.Point(115, 26);
            this.txtAssignNID.Name = "txtAssignNID";
            this.txtAssignNID.Size = new System.Drawing.Size(232, 22);
            this.txtAssignNID.TabIndex = 13;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAssignNID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAssign);
            this.Controls.Add(this.txtEmpPost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnShowEmp);
            this.Controls.Add(this.dataShowAllEmp);
            this.Controls.Add(this.btnDltEmp);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.dataSearchViewEmp);
            this.Controls.Add(this.btnSearchEmp);
            this.Controls.Add(this.txtSrchNid);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.linkBackEmp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Employees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchViewEmp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataShowAllEmp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkBackEmp;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtSrchNid;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.DataGridView dataSearchViewEmp;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDltEmp;
        private System.Windows.Forms.DataGridView dataShowAllEmp;
        private System.Windows.Forms.Button btnShowEmp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmpPost;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAssignNID;
    }
}