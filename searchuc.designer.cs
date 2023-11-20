namespace FinalProject
{
    partial class SearchUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AccessGV = new System.Windows.Forms.DataGridView();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.lblSupplierID = new System.Windows.Forms.Label();
            this.SearchProductBtn = new System.Windows.Forms.Button();
            this.SearchListBtn = new System.Windows.Forms.Button();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.supplierPanel = new System.Windows.Forms.Panel();
            this.customerPanel = new System.Windows.Forms.Panel();
            this.supplierBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AccessGV)).BeginInit();
            this.supplierPanel.SuspendLayout();
            this.customerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AccessGV
            // 
            this.AccessGV.BackgroundColor = System.Drawing.Color.White;
            this.AccessGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccessGV.Location = new System.Drawing.Point(24, 136);
            this.AccessGV.Name = "AccessGV";
            this.AccessGV.Size = new System.Drawing.Size(702, 150);
            this.AccessGV.TabIndex = 38;
            this.AccessGV.Visible = false;
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.Location = new System.Drawing.Point(98, 41);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(98, 21);
            this.cmbSupplierID.TabIndex = 41;
            // 
            // lblSupplierID
            // 
            this.lblSupplierID.AutoSize = true;
            this.lblSupplierID.Font = new System.Drawing.Font("Arial", 12F);
            this.lblSupplierID.Location = new System.Drawing.Point(3, 42);
            this.lblSupplierID.Name = "lblSupplierID";
            this.lblSupplierID.Size = new System.Drawing.Size(89, 18);
            this.lblSupplierID.TabIndex = 40;
            this.lblSupplierID.Text = "Supplier ID:";
            // 
            // SearchProductBtn
            // 
            this.SearchProductBtn.Location = new System.Drawing.Point(98, 68);
            this.SearchProductBtn.Name = "SearchProductBtn";
            this.SearchProductBtn.Size = new System.Drawing.Size(107, 23);
            this.SearchProductBtn.TabIndex = 39;
            this.SearchProductBtn.Text = "Search";
            this.SearchProductBtn.UseVisualStyleBackColor = true;
            this.SearchProductBtn.Click += new System.EventHandler(this.SearchProductBTN_Click);
            // 
            // SearchListBtn
            // 
            this.SearchListBtn.Location = new System.Drawing.Point(108, 50);
            this.SearchListBtn.Name = "SearchListBtn";
            this.SearchListBtn.Size = new System.Drawing.Size(107, 23);
            this.SearchListBtn.TabIndex = 46;
            this.SearchListBtn.Text = "Search";
            this.SearchListBtn.UseVisualStyleBackColor = true;
            this.SearchListBtn.Click += new System.EventHandler(this.SearchListBTN_Click);
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(108, 23);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(88, 21);
            this.cmbCustomerID.TabIndex = 44;
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerID.Location = new System.Drawing.Point(3, 26);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 18);
            this.lblCustomerID.TabIndex = 43;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // supplierPanel
            // 
            this.supplierPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.supplierPanel.Controls.Add(this.lblSupplierID);
            this.supplierPanel.Controls.Add(this.SearchProductBtn);
            this.supplierPanel.Controls.Add(this.cmbSupplierID);
            this.supplierPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.supplierPanel.Location = new System.Drawing.Point(35, 32);
            this.supplierPanel.Name = "supplierPanel";
            this.supplierPanel.Size = new System.Drawing.Size(249, 100);
            this.supplierPanel.TabIndex = 47;
            this.supplierPanel.Visible = false;
            this.supplierPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // customerPanel
            // 
            this.customerPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.customerPanel.Controls.Add(this.lblCustomerID);
            this.customerPanel.Controls.Add(this.cmbCustomerID);
            this.customerPanel.Controls.Add(this.SearchListBtn);
            this.customerPanel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.customerPanel.Location = new System.Drawing.Point(404, 32);
            this.customerPanel.Name = "customerPanel";
            this.customerPanel.Size = new System.Drawing.Size(249, 100);
            this.customerPanel.TabIndex = 48;
            this.customerPanel.Visible = false;
            // 
            // supplierBtn
            // 
            this.supplierBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.supplierBtn.Location = new System.Drawing.Point(92, 3);
            this.supplierBtn.Name = "supplierBtn";
            this.supplierBtn.Size = new System.Drawing.Size(111, 23);
            this.supplierBtn.TabIndex = 49;
            this.supplierBtn.Text = "Supplier Search";
            this.supplierBtn.UseVisualStyleBackColor = true;
            this.supplierBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.customerBtn.Location = new System.Drawing.Point(484, 3);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(104, 23);
            this.customerBtn.TabIndex = 50;
            this.customerBtn.Text = "Customer Search";
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // SearchUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.customerBtn);
            this.Controls.Add(this.supplierBtn);
            this.Controls.Add(this.AccessGV);
            this.Controls.Add(this.customerPanel);
            this.Controls.Add(this.supplierPanel);
            this.Name = "SearchUC";
            this.Size = new System.Drawing.Size(745, 426);
            this.Load += new System.EventHandler(this.SearchUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccessGV)).EndInit();
            this.supplierPanel.ResumeLayout(false);
            this.supplierPanel.PerformLayout();
            this.customerPanel.ResumeLayout(false);
            this.customerPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccessGV;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.Label lblSupplierID;
        private System.Windows.Forms.Button SearchProductBtn;
        private System.Windows.Forms.Button SearchListBtn;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Panel supplierPanel;
        private System.Windows.Forms.Panel customerPanel;
        private System.Windows.Forms.Button supplierBtn;
        private System.Windows.Forms.Button customerBtn;
    }
}
