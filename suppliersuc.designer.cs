namespace FinalProject
{
    partial class SuppliersUC
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
            this.DeleteSupplierBTN = new System.Windows.Forms.Button();
            this.lblSupplierIDdelete = new System.Windows.Forms.Label();
            this.lblDeleteSupplier = new System.Windows.Forms.Label();
            this.cmbSupplierIddel = new System.Windows.Forms.ComboBox();
            this.SupplierdelName = new System.Windows.Forms.Label();
            this.SupplierName = new System.Windows.Forms.TextBox();
            this.lblSupplierPhone = new System.Windows.Forms.Label();
            this.SupplierMail = new System.Windows.Forms.TextBox();
            this.lblSupplierMail = new System.Windows.Forms.Label();
            this.SupplierPhone = new System.Windows.Forms.MaskedTextBox();
            this.lblSupplierName = new System.Windows.Forms.Label();
            this.AddSupplierBTN = new System.Windows.Forms.Button();
            this.lblSupplierIDadd = new System.Windows.Forms.Label();
            this.lblAddSupplier = new System.Windows.Forms.Label();
            this.SupplierID = new System.Windows.Forms.MaskedTextBox();
            this.EditSupplierName = new System.Windows.Forms.TextBox();
            this.NewPhone = new System.Windows.Forms.Label();
            this.EditSupplierMail = new System.Windows.Forms.TextBox();
            this.NewMail = new System.Windows.Forms.Label();
            this.EditSupplierPhone = new System.Windows.Forms.MaskedTextBox();
            this.NewName = new System.Windows.Forms.Label();
            this.EditSupplierBTN = new System.Windows.Forms.Button();
            this.lblSupplierIDedit = new System.Windows.Forms.Label();
            this.lblEditSupplier = new System.Windows.Forms.Label();
            this.cmbSupplierID = new System.Windows.Forms.ComboBox();
            this.SuppliereditName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DeleteSupplierBTN
            // 
            this.DeleteSupplierBTN.Location = new System.Drawing.Point(461, 107);
            this.DeleteSupplierBTN.Name = "DeleteSupplierBTN";
            this.DeleteSupplierBTN.Size = new System.Drawing.Size(107, 23);
            this.DeleteSupplierBTN.TabIndex = 24;
            this.DeleteSupplierBTN.Text = "Delete Supplier";
            this.DeleteSupplierBTN.UseVisualStyleBackColor = true;
            this.DeleteSupplierBTN.Click += new System.EventHandler(this.DeleteSupplierBTN_Click);
            // 
            // lblSupplierIDdelete
            // 
            this.lblSupplierIDdelete.AutoSize = true;
            this.lblSupplierIDdelete.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDdelete.Location = new System.Drawing.Point(420, 70);
            this.lblSupplierIDdelete.Name = "lblSupplierIDdelete";
            this.lblSupplierIDdelete.Size = new System.Drawing.Size(25, 16);
            this.lblSupplierIDdelete.TabIndex = 13;
            this.lblSupplierIDdelete.Text = "ID:";
            // 
            // lblDeleteSupplier
            // 
            this.lblDeleteSupplier.AutoSize = true;
            this.lblDeleteSupplier.Font = new System.Drawing.Font("Arial", 16F);
            this.lblDeleteSupplier.ForeColor = System.Drawing.Color.Salmon;
            this.lblDeleteSupplier.Location = new System.Drawing.Point(424, 17);
            this.lblDeleteSupplier.Name = "lblDeleteSupplier";
            this.lblDeleteSupplier.Size = new System.Drawing.Size(158, 25);
            this.lblDeleteSupplier.TabIndex = 12;
            this.lblDeleteSupplier.Text = "Delete Supplier";
            // 
            // cmbSupplierIddel
            // 
            this.cmbSupplierIddel.FormattingEnabled = true;
            this.cmbSupplierIddel.Location = new System.Drawing.Point(461, 69);
            this.cmbSupplierIddel.Name = "cmbSupplierIddel";
            this.cmbSupplierIddel.Size = new System.Drawing.Size(121, 21);
            this.cmbSupplierIddel.TabIndex = 25;
            // 
            // SupplierdelName
            // 
            this.SupplierdelName.AutoSize = true;
            this.SupplierdelName.Location = new System.Drawing.Point(604, 72);
            this.SupplierdelName.Name = "SupplierdelName";
            this.SupplierdelName.Size = new System.Drawing.Size(33, 13);
            this.SupplierdelName.TabIndex = 28;
            this.SupplierdelName.Text = "None";
            this.SupplierdelName.Visible = false;
            // 
            // SupplierName
            // 
            this.SupplierName.Location = new System.Drawing.Point(72, 88);
            this.SupplierName.MaxLength = 15;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.Size = new System.Drawing.Size(100, 20);
            this.SupplierName.TabIndex = 20;
            this.SupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplierName_KeyPress);
            // 
            // lblSupplierPhone
            // 
            this.lblSupplierPhone.AutoSize = true;
            this.lblSupplierPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierPhone.Location = new System.Drawing.Point(194, 62);
            this.lblSupplierPhone.Name = "lblSupplierPhone";
            this.lblSupplierPhone.Size = new System.Drawing.Size(53, 16);
            this.lblSupplierPhone.TabIndex = 17;
            this.lblSupplierPhone.Text = "Phone:";
            // 
            // SupplierMail
            // 
            this.SupplierMail.Location = new System.Drawing.Point(265, 92);
            this.SupplierMail.Name = "SupplierMail";
            this.SupplierMail.Size = new System.Drawing.Size(100, 20);
            this.SupplierMail.TabIndex = 21;
            this.SupplierMail.TextChanged += new System.EventHandler(this.SupplierMail_TextChanged);
            // 
            // lblSupplierMail
            // 
            this.lblSupplierMail.AutoSize = true;
            this.lblSupplierMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierMail.Location = new System.Drawing.Point(194, 92);
            this.lblSupplierMail.Name = "lblSupplierMail";
            this.lblSupplierMail.Size = new System.Drawing.Size(48, 16);
            this.lblSupplierMail.TabIndex = 15;
            this.lblSupplierMail.Text = "Email:";
            // 
            // SupplierPhone
            // 
            this.SupplierPhone.Location = new System.Drawing.Point(265, 63);
            this.SupplierPhone.Mask = "000-0000000";
            this.SupplierPhone.Name = "SupplierPhone";
            this.SupplierPhone.PromptChar = ' ';
            this.SupplierPhone.Size = new System.Drawing.Size(100, 20);
            this.SupplierPhone.TabIndex = 23;
            // 
            // lblSupplierName
            // 
            this.lblSupplierName.AutoSize = true;
            this.lblSupplierName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierName.Location = new System.Drawing.Point(16, 88);
            this.lblSupplierName.Name = "lblSupplierName";
            this.lblSupplierName.Size = new System.Drawing.Size(49, 16);
            this.lblSupplierName.TabIndex = 14;
            this.lblSupplierName.Text = "Name:";
            // 
            // AddSupplierBTN
            // 
            this.AddSupplierBTN.Location = new System.Drawing.Point(160, 133);
            this.AddSupplierBTN.Name = "AddSupplierBTN";
            this.AddSupplierBTN.Size = new System.Drawing.Size(107, 23);
            this.AddSupplierBTN.TabIndex = 24;
            this.AddSupplierBTN.Text = "Add Supplier";
            this.AddSupplierBTN.UseVisualStyleBackColor = true;
            this.AddSupplierBTN.Click += new System.EventHandler(this.AddSupplierBTN_Click);
            // 
            // lblSupplierIDadd
            // 
            this.lblSupplierIDadd.AutoSize = true;
            this.lblSupplierIDadd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDadd.Location = new System.Drawing.Point(40, 63);
            this.lblSupplierIDadd.Name = "lblSupplierIDadd";
            this.lblSupplierIDadd.Size = new System.Drawing.Size(25, 16);
            this.lblSupplierIDadd.TabIndex = 13;
            this.lblSupplierIDadd.Text = "ID:";
            // 
            // lblAddSupplier
            // 
            this.lblAddSupplier.AutoSize = true;
            this.lblAddSupplier.Font = new System.Drawing.Font("Arial", 16F);
            this.lblAddSupplier.ForeColor = System.Drawing.Color.Salmon;
            this.lblAddSupplier.Location = new System.Drawing.Point(67, 17);
            this.lblAddSupplier.Name = "lblAddSupplier";
            this.lblAddSupplier.Size = new System.Drawing.Size(135, 25);
            this.lblAddSupplier.TabIndex = 12;
            this.lblAddSupplier.Text = "Add Supplier";
            // 
            // SupplierID
            // 
            this.SupplierID.Location = new System.Drawing.Point(72, 62);
            this.SupplierID.Mask = "0000000000";
            this.SupplierID.Name = "SupplierID";
            this.SupplierID.PromptChar = ' ';
            this.SupplierID.Size = new System.Drawing.Size(100, 20);
            this.SupplierID.TabIndex = 25;
            this.SupplierID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SupplierID_KeyPress);
            // 
            // EditSupplierName
            // 
            this.EditSupplierName.Location = new System.Drawing.Point(88, 278);
            this.EditSupplierName.MaxLength = 15;
            this.EditSupplierName.Name = "EditSupplierName";
            this.EditSupplierName.Size = new System.Drawing.Size(100, 20);
            this.EditSupplierName.TabIndex = 20;
            this.EditSupplierName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EditSupplierName_KeyPress);
            // 
            // NewPhone
            // 
            this.NewPhone.AutoSize = true;
            this.NewPhone.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPhone.Location = new System.Drawing.Point(271, 251);
            this.NewPhone.Name = "NewPhone";
            this.NewPhone.Size = new System.Drawing.Size(53, 16);
            this.NewPhone.TabIndex = 17;
            this.NewPhone.Text = "Phone:";
            // 
            // EditSupplierMail
            // 
            this.EditSupplierMail.Location = new System.Drawing.Point(339, 277);
            this.EditSupplierMail.Name = "EditSupplierMail";
            this.EditSupplierMail.Size = new System.Drawing.Size(100, 20);
            this.EditSupplierMail.TabIndex = 21;
            // 
            // NewMail
            // 
            this.NewMail.AutoSize = true;
            this.NewMail.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewMail.Location = new System.Drawing.Point(271, 280);
            this.NewMail.Name = "NewMail";
            this.NewMail.Size = new System.Drawing.Size(48, 16);
            this.NewMail.TabIndex = 15;
            this.NewMail.Text = "Email:";
            // 
            // EditSupplierPhone
            // 
            this.EditSupplierPhone.Location = new System.Drawing.Point(339, 248);
            this.EditSupplierPhone.Mask = "000-0000000";
            this.EditSupplierPhone.Name = "EditSupplierPhone";
            this.EditSupplierPhone.PromptChar = ' ';
            this.EditSupplierPhone.Size = new System.Drawing.Size(100, 20);
            this.EditSupplierPhone.TabIndex = 23;
            // 
            // NewName
            // 
            this.NewName.AutoSize = true;
            this.NewName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewName.Location = new System.Drawing.Point(10, 278);
            this.NewName.Name = "NewName";
            this.NewName.Size = new System.Drawing.Size(49, 16);
            this.NewName.TabIndex = 14;
            this.NewName.Text = "Name:";
            // 
            // EditSupplierBTN
            // 
            this.EditSupplierBTN.Location = new System.Drawing.Point(169, 304);
            this.EditSupplierBTN.Name = "EditSupplierBTN";
            this.EditSupplierBTN.Size = new System.Drawing.Size(107, 23);
            this.EditSupplierBTN.TabIndex = 24;
            this.EditSupplierBTN.Text = "Update Supplier";
            this.EditSupplierBTN.UseVisualStyleBackColor = true;
            this.EditSupplierBTN.Click += new System.EventHandler(this.EditSupplierBTN_Click);
            // 
            // lblSupplierIDedit
            // 
            this.lblSupplierIDedit.AutoSize = true;
            this.lblSupplierIDedit.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSupplierIDedit.Location = new System.Drawing.Point(34, 252);
            this.lblSupplierIDedit.Name = "lblSupplierIDedit";
            this.lblSupplierIDedit.Size = new System.Drawing.Size(25, 16);
            this.lblSupplierIDedit.TabIndex = 13;
            this.lblSupplierIDedit.Text = "ID:";
            // 
            // lblEditSupplier
            // 
            this.lblEditSupplier.AutoSize = true;
            this.lblEditSupplier.Font = new System.Drawing.Font("Arial", 16F);
            this.lblEditSupplier.ForeColor = System.Drawing.Color.Salmon;
            this.lblEditSupplier.Location = new System.Drawing.Point(68, 186);
            this.lblEditSupplier.Name = "lblEditSupplier";
            this.lblEditSupplier.Size = new System.Drawing.Size(134, 25);
            this.lblEditSupplier.TabIndex = 12;
            this.lblEditSupplier.Text = "Edit Supplier";
            // 
            // cmbSupplierID
            // 
            this.cmbSupplierID.FormattingEnabled = true;
            this.cmbSupplierID.Location = new System.Drawing.Point(88, 251);
            this.cmbSupplierID.Name = "cmbSupplierID";
            this.cmbSupplierID.Size = new System.Drawing.Size(100, 21);
            this.cmbSupplierID.TabIndex = 25;
            // 
            // SuppliereditName
            // 
            this.SuppliereditName.AutoSize = true;
            this.SuppliereditName.Location = new System.Drawing.Point(205, 255);
            this.SuppliereditName.Name = "SuppliereditName";
            this.SuppliereditName.Size = new System.Drawing.Size(33, 13);
            this.SuppliereditName.TabIndex = 26;
            this.SuppliereditName.Text = "None";
            this.SuppliereditName.Visible = false;
            // 
            // SuppliersUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.Controls.Add(this.SupplierID);
            this.Controls.Add(this.SuppliereditName);
            this.Controls.Add(this.lblAddSupplier);
            this.Controls.Add(this.lblSupplierIDadd);
            this.Controls.Add(this.SupplierdelName);
            this.Controls.Add(this.AddSupplierBTN);
            this.Controls.Add(this.cmbSupplierID);
            this.Controls.Add(this.lblSupplierName);
            this.Controls.Add(this.lblEditSupplier);
            this.Controls.Add(this.SupplierPhone);
            this.Controls.Add(this.lblSupplierIDedit);
            this.Controls.Add(this.lblSupplierMail);
            this.Controls.Add(this.SupplierMail);
            this.Controls.Add(this.EditSupplierBTN);
            this.Controls.Add(this.lblSupplierPhone);
            this.Controls.Add(this.NewName);
            this.Controls.Add(this.SupplierName);
            this.Controls.Add(this.cmbSupplierIddel);
            this.Controls.Add(this.EditSupplierPhone);
            this.Controls.Add(this.NewMail);
            this.Controls.Add(this.lblDeleteSupplier);
            this.Controls.Add(this.EditSupplierMail);
            this.Controls.Add(this.lblSupplierIDdelete);
            this.Controls.Add(this.NewPhone);
            this.Controls.Add(this.DeleteSupplierBTN);
            this.Controls.Add(this.EditSupplierName);
            this.ForeColor = System.Drawing.Color.DarkCyan;
            this.Name = "SuppliersUC";
            this.Size = new System.Drawing.Size(1160, 487);
            this.Load += new System.EventHandler(this.SuppliersUC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteSupplierBTN;
        private System.Windows.Forms.Label lblSupplierIDdelete;
        private System.Windows.Forms.Label lblDeleteSupplier;
        private System.Windows.Forms.ComboBox cmbSupplierIddel;
        private System.Windows.Forms.Label SupplierdelName;
        private System.Windows.Forms.TextBox SupplierName;
        private System.Windows.Forms.Label lblSupplierPhone;
        private System.Windows.Forms.TextBox SupplierMail;
        private System.Windows.Forms.Label lblSupplierMail;
        private System.Windows.Forms.MaskedTextBox SupplierPhone;
        private System.Windows.Forms.Label lblSupplierName;
        private System.Windows.Forms.Button AddSupplierBTN;
        private System.Windows.Forms.Label lblSupplierIDadd;
        private System.Windows.Forms.Label lblAddSupplier;
        private System.Windows.Forms.MaskedTextBox SupplierID;
        private System.Windows.Forms.TextBox EditSupplierName;
        private System.Windows.Forms.Label NewPhone;
        private System.Windows.Forms.TextBox EditSupplierMail;
        private System.Windows.Forms.Label NewMail;
        private System.Windows.Forms.MaskedTextBox EditSupplierPhone;
        private System.Windows.Forms.Label NewName;
        private System.Windows.Forms.Button EditSupplierBTN;
        private System.Windows.Forms.Label lblSupplierIDedit;
        private System.Windows.Forms.Label lblEditSupplier;
        private System.Windows.Forms.ComboBox cmbSupplierID;
        private System.Windows.Forms.Label SuppliereditName;
    }
}
