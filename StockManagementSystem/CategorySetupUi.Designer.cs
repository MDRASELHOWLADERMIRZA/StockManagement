namespace StockManagementSystem
{
    partial class CategorySetupUi
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
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.CategoryNameTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SaveButton);
            this.groupBox1.Controls.Add(this.CategoryNameTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(35, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 369);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Setup";
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // CategoryNameTextBox
            // 
            this.CategoryNameTextBox.Location = new System.Drawing.Point(164, 41);
            this.CategoryNameTextBox.Name = "CategoryNameTextBox";
            this.CategoryNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.CategoryNameTextBox.TabIndex = 1;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(277, 85);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 2;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // CategorySetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 436);
            this.Controls.Add(this.groupBox1);
            this.Name = "CategorySetup";
            this.Text = "CategorySetup";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox CategoryNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.EventLog eventLog1;
    }
}