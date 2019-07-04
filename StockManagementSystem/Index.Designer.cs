namespace StockManagementSystem
{
    partial class Index
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.CategorySetupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.CompanySetupLinkLabel = new System.Windows.Forms.LinkLabel();
            this.StockInLinkLabel = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.StockInLinkLabel);
            this.groupBox1.Controls.Add(this.CompanySetupLinkLabel);
            this.groupBox1.Controls.Add(this.CategorySetupLinkLabel);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(37, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 371);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Management System";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(176, 144);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Item Setup";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // CategorySetupLinkLabel
            // 
            this.CategorySetupLinkLabel.AutoSize = true;
            this.CategorySetupLinkLabel.LinkColor = System.Drawing.Color.Blue;
            this.CategorySetupLinkLabel.Location = new System.Drawing.Point(176, 109);
            this.CategorySetupLinkLabel.Name = "CategorySetupLinkLabel";
            this.CategorySetupLinkLabel.Size = new System.Drawing.Size(80, 13);
            this.CategorySetupLinkLabel.TabIndex = 1;
            this.CategorySetupLinkLabel.TabStop = true;
            this.CategorySetupLinkLabel.Text = "Category Setup";
            this.CategorySetupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CategorySetupLinkLabel_LinkClicked);
            // 
            // CompanySetupLinkLabel
            // 
            this.CompanySetupLinkLabel.AutoSize = true;
            this.CompanySetupLinkLabel.Location = new System.Drawing.Point(174, 77);
            this.CompanySetupLinkLabel.Name = "CompanySetupLinkLabel";
            this.CompanySetupLinkLabel.Size = new System.Drawing.Size(82, 13);
            this.CompanySetupLinkLabel.TabIndex = 2;
            this.CompanySetupLinkLabel.TabStop = true;
            this.CompanySetupLinkLabel.Text = "Company Setup";
            this.CompanySetupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CompanySetupLinkLabel_LinkClicked);
            // 
            // StockInLinkLabel
            // 
            this.StockInLinkLabel.AutoSize = true;
            this.StockInLinkLabel.Location = new System.Drawing.Point(176, 175);
            this.StockInLinkLabel.Name = "StockInLinkLabel";
            this.StockInLinkLabel.Size = new System.Drawing.Size(47, 13);
            this.StockInLinkLabel.TabIndex = 3;
            this.StockInLinkLabel.TabStop = true;
            this.StockInLinkLabel.Text = "Stock In";
            this.StockInLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StockInLinkLabel_LinkClicked);
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 458);
            this.Controls.Add(this.groupBox1);
            this.Name = "Index";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel StockInLinkLabel;
        private System.Windows.Forms.LinkLabel CompanySetupLinkLabel;
        private System.Windows.Forms.LinkLabel CategorySetupLinkLabel;
    }
}

