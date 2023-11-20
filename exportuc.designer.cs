namespace FinalProject
{
    partial class ExportUC
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
            this.exportBtn = new System.Windows.Forms.Button();
            this.AccessGV = new System.Windows.Forms.DataGridView();
            this.productExportBtn = new System.Windows.Forms.Button();
            this.exportSupplierBtn = new System.Windows.Forms.Button();
            this.exportCustomerBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AccessGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // exportBtn
            // 
            this.exportBtn.ForeColor = System.Drawing.Color.DarkKhaki;
            this.exportBtn.Location = new System.Drawing.Point(286, 301);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(94, 23);
            this.exportBtn.TabIndex = 1;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // AccessGV
            // 
            this.AccessGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.AccessGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccessGV.Location = new System.Drawing.Point(35, 139);
            this.AccessGV.Name = "AccessGV";
            this.AccessGV.Size = new System.Drawing.Size(614, 156);
            this.AccessGV.TabIndex = 41;
            this.AccessGV.Visible = false;
            // 
            // productExportBtn
            // 
            this.productExportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productExportBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.productExportBtn.Location = new System.Drawing.Point(31, 21);
            this.productExportBtn.Name = "productExportBtn";
            this.productExportBtn.Size = new System.Drawing.Size(109, 23);
            this.productExportBtn.TabIndex = 4;
            this.productExportBtn.Text = "Export Products";
            this.productExportBtn.UseVisualStyleBackColor = true;
            this.productExportBtn.Click += new System.EventHandler(this.productExportBtn_Click);
            // 
            // exportSupplierBtn
            // 
            this.exportSupplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportSupplierBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exportSupplierBtn.Location = new System.Drawing.Point(31, 52);
            this.exportSupplierBtn.Name = "exportSupplierBtn";
            this.exportSupplierBtn.Size = new System.Drawing.Size(109, 23);
            this.exportSupplierBtn.TabIndex = 5;
            this.exportSupplierBtn.Text = "Export Suppliers";
            this.exportSupplierBtn.UseVisualStyleBackColor = true;
            this.exportSupplierBtn.Click += new System.EventHandler(this.exportSupplierBtn_Click);
            // 
            // exportCustomerBtn
            // 
            this.exportCustomerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exportCustomerBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.exportCustomerBtn.Location = new System.Drawing.Point(31, 81);
            this.exportCustomerBtn.Name = "exportCustomerBtn";
            this.exportCustomerBtn.Size = new System.Drawing.Size(109, 23);
            this.exportCustomerBtn.TabIndex = 6;
            this.exportCustomerBtn.Text = "Export Customers";
            this.exportCustomerBtn.UseVisualStyleBackColor = true;
            this.exportCustomerBtn.Click += new System.EventHandler(this.exportCustomerBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.productExportBtn);
            this.panel1.Controls.Add(this.exportCustomerBtn);
            this.panel1.Controls.Add(this.exportSupplierBtn);
            this.panel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.panel1.Location = new System.Drawing.Point(35, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(176, 117);
            this.panel1.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Choose Options:";
            // 
            // ExportUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.AccessGV);
            this.Name = "ExportUC";
            this.Size = new System.Drawing.Size(986, 489);
            this.Load += new System.EventHandler(this.ExportUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccessGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.DataGridView AccessGV;
        private System.Windows.Forms.Button productExportBtn;
        private System.Windows.Forms.Button exportSupplierBtn;
        private System.Windows.Forms.Button exportCustomerBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
