namespace FinalProject
{
    partial class OrderUC
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
            this.AvailableAmount = new System.Windows.Forms.Label();
            this.lblProductAvailableAmount = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.ProductAmount = new System.Windows.Forms.NumericUpDown();
            this.lblAmount = new System.Windows.Forms.Label();
            this.cmbCustomerID = new System.Windows.Forms.ComboBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.cmbProductName = new System.Windows.Forms.ComboBox();
            this.lblOrder = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.MakeOrderBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // AvailableAmount
            // 
            this.AvailableAmount.AutoSize = true;
            this.AvailableAmount.Location = new System.Drawing.Point(183, 162);
            this.AvailableAmount.Name = "AvailableAmount";
            this.AvailableAmount.Size = new System.Drawing.Size(33, 13);
            this.AvailableAmount.TabIndex = 64;
            this.AvailableAmount.Text = "None";
            this.AvailableAmount.Visible = false;
            // 
            // lblProductAvailableAmount
            // 
            this.lblProductAvailableAmount.AutoSize = true;
            this.lblProductAvailableAmount.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProductAvailableAmount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblProductAvailableAmount.Location = new System.Drawing.Point(58, 159);
            this.lblProductAvailableAmount.Name = "lblProductAvailableAmount";
            this.lblProductAvailableAmount.Size = new System.Drawing.Size(122, 18);
            this.lblProductAvailableAmount.TabIndex = 63;
            this.lblProductAvailableAmount.Text = "Amount in stock:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCustomerName.Location = new System.Drawing.Point(58, 87);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(126, 18);
            this.lblCustomerName.TabIndex = 61;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(183, 90);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(33, 13);
            this.CustomerName.TabIndex = 60;
            this.CustomerName.Text = "None";
            this.CustomerName.Visible = false;
            // 
            // ProductAmount
            // 
            this.ProductAmount.Location = new System.Drawing.Point(186, 182);
            this.ProductAmount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ProductAmount.Name = "ProductAmount";
            this.ProductAmount.Size = new System.Drawing.Size(54, 20);
            this.ProductAmount.TabIndex = 59;
            this.ProductAmount.ValueChanged += new System.EventHandler(this.ProductAmount_ValueChanged);
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Arial", 12F);
            this.lblAmount.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblAmount.Location = new System.Drawing.Point(58, 186);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(68, 18);
            this.lblAmount.TabIndex = 58;
            this.lblAmount.Text = "Quantity:";
            // 
            // cmbCustomerID
            // 
            this.cmbCustomerID.FormattingEnabled = true;
            this.cmbCustomerID.Location = new System.Drawing.Point(186, 59);
            this.cmbCustomerID.Name = "cmbCustomerID";
            this.cmbCustomerID.Size = new System.Drawing.Size(121, 21);
            this.cmbCustomerID.TabIndex = 57;
            this.cmbCustomerID.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerID_SelectedIndexChanged);
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerID.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblCustomerID.Location = new System.Drawing.Point(58, 64);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(99, 18);
            this.lblCustomerID.TabIndex = 56;
            this.lblCustomerID.Text = "Customer ID:";
            this.lblCustomerID.Click += new System.EventHandler(this.lblCustomerID_Click);
            // 
            // cmbProductName
            // 
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.Location = new System.Drawing.Point(186, 130);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(121, 21);
            this.cmbProductName.TabIndex = 55;
            this.cmbProductName.SelectedIndexChanged += new System.EventHandler(this.cmbProductName_SelectedIndexChanged);
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Arial", 16F);
            this.lblOrder.ForeColor = System.Drawing.Color.Salmon;
            this.lblOrder.Location = new System.Drawing.Point(74, 14);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(126, 25);
            this.lblOrder.TabIndex = 52;
            this.lblOrder.Text = "Make Order";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProductName.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.lblProductName.Location = new System.Drawing.Point(58, 130);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(112, 18);
            this.lblProductName.TabIndex = 53;
            this.lblProductName.Text = "Product Name:";
            // 
            // MakeOrderBTN
            // 
            this.MakeOrderBTN.ForeColor = System.Drawing.Color.LightSlateGray;
            this.MakeOrderBTN.Location = new System.Drawing.Point(133, 227);
            this.MakeOrderBTN.Name = "MakeOrderBTN";
            this.MakeOrderBTN.Size = new System.Drawing.Size(107, 23);
            this.MakeOrderBTN.TabIndex = 54;
            this.MakeOrderBTN.Text = "Buy Now";
            this.MakeOrderBTN.UseVisualStyleBackColor = true;
            this.MakeOrderBTN.Click += new System.EventHandler(this.MakeOrderBTN_Click);
            // 
            // OrderUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.AvailableAmount);
            this.Controls.Add(this.lblProductAvailableAmount);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.ProductAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cmbCustomerID);
            this.Controls.Add(this.lblCustomerID);
            this.Controls.Add(this.cmbProductName);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.MakeOrderBTN);
            this.ForeColor = System.Drawing.Color.LightGoldenrodYellow;
            this.Name = "OrderUC";
            this.Size = new System.Drawing.Size(699, 413);
            this.Load += new System.EventHandler(this.OrderUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvailableAmount;
        private System.Windows.Forms.Label lblProductAvailableAmount;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.NumericUpDown ProductAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.ComboBox cmbCustomerID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.ComboBox cmbProductName;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button MakeOrderBTN;
    }
}
