namespace FinalProject
{
    partial class CustomersUC
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
            this.DeleteCustomerBtn = new System.Windows.Forms.Button();
            this.lblCustomerIDdelete = new System.Windows.Forms.Label();
            this.lblDeleteCustomer = new System.Windows.Forms.Label();
            this.txtbCustomerIdDel = new System.Windows.Forms.ComboBox();
            this.EditCustomerName = new System.Windows.Forms.TextBox();
            this.NewPhone = new System.Windows.Forms.Label();
            this.EditCustomerCity = new System.Windows.Forms.TextBox();
            this.NewCity = new System.Windows.Forms.Label();
            this.EditCustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.NewName = new System.Windows.Forms.Label();
            this.UpdateCustomerBtn = new System.Windows.Forms.Button();
            this.lblCustomerIDedit = new System.Windows.Forms.Label();
            this.lblEditCustomer = new System.Windows.Forms.Label();
            this.txtbCustomerID = new System.Windows.Forms.ComboBox();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerPhone = new System.Windows.Forms.Label();
            this.CustomerCity = new System.Windows.Forms.TextBox();
            this.lblCustomerCity = new System.Windows.Forms.Label();
            this.CustomerPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.AddCustomerBtn = new System.Windows.Forms.Button();
            this.lblCustomerIDadd = new System.Windows.Forms.Label();
            this.lblAddCustomer = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // DeleteCustomerBtn
            // 
            this.DeleteCustomerBtn.Location = new System.Drawing.Point(145, 294);
            this.DeleteCustomerBtn.Name = "DeleteCustomerBtn";
            this.DeleteCustomerBtn.Size = new System.Drawing.Size(107, 23);
            this.DeleteCustomerBtn.TabIndex = 24;
            this.DeleteCustomerBtn.Text = "Delete Customer";
            this.DeleteCustomerBtn.UseVisualStyleBackColor = true;
            this.DeleteCustomerBtn.Click += new System.EventHandler(this.DeleteCustomerBTN_Click);
            // 
            // lblCustomerIDdelete
            // 
            this.lblCustomerIDdelete.AutoSize = true;
            this.lblCustomerIDdelete.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerIDdelete.Location = new System.Drawing.Point(112, 265);
            this.lblCustomerIDdelete.Name = "lblCustomerIDdelete";
            this.lblCustomerIDdelete.Size = new System.Drawing.Size(27, 18);
            this.lblCustomerIDdelete.TabIndex = 13;
            this.lblCustomerIDdelete.Text = "ID:";
            // 
            // lblDeleteCustomer
            // 
            this.lblDeleteCustomer.AutoSize = true;
            this.lblDeleteCustomer.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDeleteCustomer.ForeColor = System.Drawing.Color.Salmon;
            this.lblDeleteCustomer.Location = new System.Drawing.Point(117, 229);
            this.lblDeleteCustomer.Name = "lblDeleteCustomer";
            this.lblDeleteCustomer.Size = new System.Drawing.Size(174, 25);
            this.lblDeleteCustomer.TabIndex = 12;
            this.lblDeleteCustomer.Text = "Delete Customer";
            // 
            // txtbCustomerIdDel
            // 
            this.txtbCustomerIdDel.FormattingEnabled = true;
            this.txtbCustomerIdDel.Location = new System.Drawing.Point(145, 266);
            this.txtbCustomerIdDel.Name = "txtbCustomerIdDel";
            this.txtbCustomerIdDel.Size = new System.Drawing.Size(121, 21);
            this.txtbCustomerIdDel.TabIndex = 25;
            this.txtbCustomerIdDel.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerIddel_SelectedIndexChanged);
            // 
            // EditCustomerName
            // 
            this.EditCustomerName.Location = new System.Drawing.Point(539, 122);
            this.EditCustomerName.MaxLength = 15;
            this.EditCustomerName.Name = "EditCustomerName";
            this.EditCustomerName.Size = new System.Drawing.Size(100, 20);
            this.EditCustomerName.TabIndex = 20;
            this.EditCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditCustomerName_KeyPress);
            // 
            // NewPhone
            // 
            this.NewPhone.AutoSize = true;
            this.NewPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.NewPhone.Location = new System.Drawing.Point(653, 121);
            this.NewPhone.Name = "NewPhone";
            this.NewPhone.Size = new System.Drawing.Size(53, 18);
            this.NewPhone.TabIndex = 17;
            this.NewPhone.Text = "Phone";
            // 
            // EditCustomerCity
            // 
            this.EditCustomerCity.Location = new System.Drawing.Point(712, 95);
            this.EditCustomerCity.MaxLength = 15;
            this.EditCustomerCity.Name = "EditCustomerCity";
            this.EditCustomerCity.Size = new System.Drawing.Size(100, 20);
            this.EditCustomerCity.TabIndex = 21;
            this.EditCustomerCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditCustomerCity_KeyPress);
            // 
            // NewCity
            // 
            this.NewCity.AutoSize = true;
            this.NewCity.Font = new System.Drawing.Font("Arial", 12F);
            this.NewCity.Location = new System.Drawing.Point(661, 95);
            this.NewCity.Name = "NewCity";
            this.NewCity.Size = new System.Drawing.Size(35, 18);
            this.NewCity.TabIndex = 15;
            this.NewCity.Text = "City";
            // 
            // EditCustomerPhone
            // 
            this.EditCustomerPhone.Location = new System.Drawing.Point(712, 121);
            this.EditCustomerPhone.Mask = "000-0000000";
            this.EditCustomerPhone.Name = "EditCustomerPhone";
            this.EditCustomerPhone.PromptChar = ' ';
            this.EditCustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.EditCustomerPhone.TabIndex = 23;
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Font = new System.Drawing.Font("Arial", 12F);
            this.NewName.Location = new System.Drawing.Point(479, 124);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(54, 18);
            this.NewName.TabIndex = 14;
            this.NewName.Text = "Name:";
            // 
            // UpdateCustomerBtn
            // 
            this.UpdateCustomerBtn.Location = new System.Drawing.Point(589, 173);
            this.UpdateCustomerBtn.Name = "UpdateCustomerBtn";
            this.UpdateCustomerBtn.Size = new System.Drawing.Size(107, 23);
            this.UpdateCustomerBtn.TabIndex = 24;
            this.UpdateCustomerBtn.Text = "Update Customer";
            this.UpdateCustomerBtn.UseVisualStyleBackColor = true;
            this.UpdateCustomerBtn.Click += new System.EventHandler(this.EditCustomerBtn_Click);
            // 
            // lblCustomerIDedit
            // 
            this.lblCustomerIDedit.AutoSize = true;
            this.lblCustomerIDedit.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerIDedit.Location = new System.Drawing.Point(506, 91);
            this.lblCustomerIDedit.Name = "lblCustomerIDedit";
            this.lblCustomerIDedit.Size = new System.Drawing.Size(27, 18);
            this.lblCustomerIDedit.TabIndex = 13;
            this.lblCustomerIDedit.Text = "ID:";
            // 
            // lblEditCustomer
            // 
            this.lblEditCustomer.AutoSize = true;
            this.lblEditCustomer.Font = new System.Drawing.Font("Arial", 16F);
            this.lblEditCustomer.ForeColor = System.Drawing.Color.Salmon;
            this.lblEditCustomer.Location = new System.Drawing.Point(598, 55);
            this.lblEditCustomer.Name = "lblEditCustomer";
            this.lblEditCustomer.Size = new System.Drawing.Size(150, 25);
            this.lblEditCustomer.TabIndex = 12;
            this.lblEditCustomer.Text = "Edit Customer";
            // 
            // txtbCustomerID
            // 
            this.txtbCustomerID.FormattingEnabled = true;
            this.txtbCustomerID.Location = new System.Drawing.Point(539, 92);
            this.txtbCustomerID.Name = "txtbCustomerID";
            this.txtbCustomerID.Size = new System.Drawing.Size(100, 21);
            this.txtbCustomerID.TabIndex = 25;
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(89, 128);
            this.CustomerName.MaxLength = 10;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(100, 20);
            this.CustomerName.TabIndex = 20;
            this.CustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerName_KeyPress);
            // 
            // lblCustomerPhone
            // 
            this.lblCustomerPhone.AutoSize = true;
            this.lblCustomerPhone.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerPhone.Location = new System.Drawing.Point(209, 127);
            this.lblCustomerPhone.Name = "lblCustomerPhone";
            this.lblCustomerPhone.Size = new System.Drawing.Size(57, 18);
            this.lblCustomerPhone.TabIndex = 17;
            this.lblCustomerPhone.Text = "Phone:";
            // 
            // CustomerCity
            // 
            this.CustomerCity.Location = new System.Drawing.Point(253, 89);
            this.CustomerCity.Name = "CustomerCity";
            this.CustomerCity.Size = new System.Drawing.Size(100, 20);
            this.CustomerCity.TabIndex = 21;
            this.CustomerCity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerCity_KeyPress);
            // 
            // lblCustomerCity
            // 
            this.lblCustomerCity.AutoSize = true;
            this.lblCustomerCity.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerCity.Location = new System.Drawing.Point(212, 89);
            this.lblCustomerCity.Name = "lblCustomerCity";
            this.lblCustomerCity.Size = new System.Drawing.Size(39, 18);
            this.lblCustomerCity.TabIndex = 15;
            this.lblCustomerCity.Text = "City:";
            // 
            // CustomerPhone
            // 
            this.CustomerPhone.Location = new System.Drawing.Point(280, 125);
            this.CustomerPhone.Mask = "000-0000000";
            this.CustomerPhone.Name = "CustomerPhone";
            this.CustomerPhone.PromptChar = ' ';
            this.CustomerPhone.Size = new System.Drawing.Size(100, 20);
            this.CustomerPhone.TabIndex = 23;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerName.Location = new System.Drawing.Point(33, 127);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(54, 18);
            this.lblCustomerName.TabIndex = 14;
            this.lblCustomerName.Text = "Name:";
            // 
            // AddCustomerBtn
            // 
            this.AddCustomerBtn.Location = new System.Drawing.Point(159, 173);
            this.AddCustomerBtn.Name = "AddCustomerBtn";
            this.AddCustomerBtn.Size = new System.Drawing.Size(107, 23);
            this.AddCustomerBtn.TabIndex = 24;
            this.AddCustomerBtn.Text = "Add Customer";
            this.AddCustomerBtn.UseVisualStyleBackColor = true;
            this.AddCustomerBtn.Click += new System.EventHandler(this.AddCustomerBtn_Click);
            // 
            // lblCustomerIDadd
            // 
            this.lblCustomerIDadd.AutoSize = true;
            this.lblCustomerIDadd.Font = new System.Drawing.Font("Arial", 12F);
            this.lblCustomerIDadd.Location = new System.Drawing.Point(60, 91);
            this.lblCustomerIDadd.Name = "lblCustomerIDadd";
            this.lblCustomerIDadd.Size = new System.Drawing.Size(27, 18);
            this.lblCustomerIDadd.TabIndex = 13;
            this.lblCustomerIDadd.Text = "ID:";
            // 
            // lblAddCustomer
            // 
            this.lblAddCustomer.AutoSize = true;
            this.lblAddCustomer.Font = new System.Drawing.Font("Arial", 16F);
            this.lblAddCustomer.ForeColor = System.Drawing.Color.Salmon;
            this.lblAddCustomer.Location = new System.Drawing.Point(140, 48);
            this.lblAddCustomer.Name = "lblAddCustomer";
            this.lblAddCustomer.Size = new System.Drawing.Size(151, 25);
            this.lblAddCustomer.TabIndex = 12;
            this.lblAddCustomer.Text = "Add Customer";
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(89, 87);
            this.CustomerID.Mask = "00000000";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.PromptChar = ' ';
            this.CustomerID.Size = new System.Drawing.Size(100, 20);
            this.CustomerID.TabIndex = 25;
            this.CustomerID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerID_KeyPress);
            // 
            // CustomersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.txtbCustomerIdDel);
            this.Controls.Add(this.txtbCustomerID);
            this.Controls.Add(this.lblDeleteCustomer);
            this.Controls.Add(this.lblCustomerIDdelete);
            this.Controls.Add(this.DeleteCustomerBtn);
            this.Controls.Add(this.lblEditCustomer);
            this.Controls.Add(this.lblCustomerIDedit);
            this.Controls.Add(this.lblAddCustomer);
            this.Controls.Add(this.UpdateCustomerBtn);
            this.Controls.Add(this.lblCustomerIDadd);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.EditCustomerPhone);
            this.Controls.Add(this.AddCustomerBtn);
            this.Controls.Add(this.NewCity);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.EditCustomerCity);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.NewPhone);
            this.Controls.Add(this.CustomerPhone);
            this.Controls.Add(this.EditCustomerName);
            this.Controls.Add(this.lblCustomerPhone);
            this.Controls.Add(this.lblCustomerCity);
            this.Controls.Add(this.CustomerCity);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "CustomersUC";
            this.Size = new System.Drawing.Size(921, 473);
            this.Load += new System.EventHandler(this.CustomersUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox txtbCustomerIdDel;
        private System.Windows.Forms.Label lblDeleteCustomer;
        private System.Windows.Forms.Label lblCustomerIDdelete;
        private System.Windows.Forms.Button DeleteCustomerBtn;
        private System.Windows.Forms.ComboBox txtbCustomerID;
        private System.Windows.Forms.Label lblEditCustomer;
        private System.Windows.Forms.Label lblCustomerIDedit;
        private System.Windows.Forms.Button UpdateCustomerBtn;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.MaskedTextBox EditCustomerPhone;
        private System.Windows.Forms.Label NewCity;
        private System.Windows.Forms.TextBox EditCustomerCity;
        private System.Windows.Forms.Label NewPhone;
        private System.Windows.Forms.TextBox EditCustomerName;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label lblCustomerPhone;
        private System.Windows.Forms.TextBox CustomerCity;
        private System.Windows.Forms.Label lblCustomerCity;
        private System.Windows.Forms.MaskedTextBox CustomerPhone;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Button AddCustomerBtn;
        private System.Windows.Forms.Label lblCustomerIDadd;
        private System.Windows.Forms.Label lblAddCustomer;
        private System.Windows.Forms.MaskedTextBox CustomerID;
    }
}
