namespace FinalProject
{
    partial class mainform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.home = new System.Windows.Forms.Button();
            this.products = new System.Windows.Forms.Button();
            this.suppliers = new System.Windows.Forms.Button();
            this.customer = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.searchbtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.orderBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.homeUC11 = new FinalProject.HomeUC1();
            this.exportUC1 = new FinalProject.ExportUC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.DarkCyan;
            this.home.ForeColor = System.Drawing.Color.Crimson;
            this.home.Location = new System.Drawing.Point(34, 26);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(47, 35); ;
            this.home.TabIndex = 0;
            this.home.Text = "Home ";
            this.home.UseVisualStyleBackColor = false;
            // 
            // products
            // 
            this.products.BackColor = System.Drawing.Color.DarkCyan;
            this.products.ForeColor = System.Drawing.Color.Crimson;
            this.products.Location = new System.Drawing.Point(20, 113); ;
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(47, 35);
            this.products.TabIndex = 1;
            this.products.Text = "products";
            this.products.UseVisualStyleBackColor = false;
            // 
            // suppliers
            // 
            this.suppliers.BackColor = System.Drawing.Color.DarkCyan;
            this.suppliers.ForeColor = System.Drawing.Color.Crimson;
            this.suppliers.Location = new System.Drawing.Point(9, 139);
            this.suppliers.Name = "suppliers";
            this.suppliers.Size = new System.Drawing.Size(47, 35);
            this.suppliers.TabIndex = 2;
            this.suppliers.Text = "suppliers";
            this.suppliers.UseVisualStyleBackColor = false;
            // 
            // customer
            // 
            this.customer.BackColor = System.Drawing.Color.DarkCyan;
            this.customer.ForeColor = System.Drawing.Color.Crimson;
            this.customer.Location = new System.Drawing.Point(20, 224);
            this.customer.Name = "customer";
            this.customer.Size = new System.Drawing.Size(47, 35);
            this.customer.TabIndex = 3;
            this.customer.Text = "customer ";
            this.customer.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(111, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 339);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.homeUC11);
            this.panel2.Controls.Add(this.exportUC1);
            this.panel2.Location = new System.Drawing.Point(-3, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(993, 487);
            this.panel2.TabIndex = 0;
            // 
            // searchbtn
            // 
            this.searchbtn.BackColor = System.Drawing.Color.DarkBlue;
            this.searchbtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.searchbtn.Location = new System.Drawing.Point(0, 0);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(47, 35);
            this.searchbtn.TabIndex = 6;
            this.searchbtn.Text = "search";
            this.searchbtn.UseVisualStyleBackColor = true;
            
            // 
            // exportBtn
            // 
            this.exportBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.exportBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.exportBtn.Location = new System.Drawing.Point(8, 384);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(47, 35);
            this.exportBtn.TabIndex = 7;
            this.exportBtn.Text = "export";
            this.exportBtn.UseVisualStyleBackColor = true;
            // 
            // orderBtn
            // 
            this.orderBtn.BackColor = System.Drawing.Color.DarkBlue;
            this.orderBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.orderBtn.Location = new System.Drawing.Point(8, 316);
            this.orderBtn.Name = "orderBtn";
            this.orderBtn.Size = new System.Drawing.Size(47, 35);
            this.orderBtn.TabIndex = 8;
            this.orderBtn.Text = "order";
            this.orderBtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(457, 458);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 135);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.exitBtn);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.exportBtn);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.searchbtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.orderBtn);
            this.panel3.Controls.Add(this.suppliers);
            this.panel3.Location = new System.Drawing.Point(12, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 514); 
            this.panel3.TabIndex = 16;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(422, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "label12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "label11";
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(381, 60);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 0;
            this.exitBtn.Text = "exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Home";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Customers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Suppliers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Products";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Order Now";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Export";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(39, 593);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(183, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Computers © Copyright 2021";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(8, 594);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "mona";
            // 
            // homeUC11
            // 
            this.homeUC11.BackColor = System.Drawing.Color.AliceBlue;
            this.homeUC11.Location = new System.Drawing.Point(317, 132);
            this.homeUC11.Name = "homeUC11";
            this.homeUC11.Size = new System.Drawing.Size(951, 339);
            this.homeUC11.TabIndex = 21;
            // 
            // exportUC1
            // 
            this.exportUC1.BackColor = System.Drawing.Color.Cornsilk;
            this.exportUC1.Location = new System.Drawing.Point(0, 3);
            this.exportUC1.Name = "exportUC1";
            this.exportUC1.Size = new System.Drawing.Size(8, 8);
            this.exportUC1.TabIndex = 21;
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 537);
            this.Controls.Add(this.homeUC11);
            this.Controls.Add(this.exportUC1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderBtn);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.searchbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.customer);
            this.Controls.Add(this.suppliers);
            this.Controls.Add(this.products);
            this.Controls.Add(this.home);
            this.Name = "mainform";
            this.Text = "mainform";
            this.Load += new System.EventHandler(this.mainform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button products;
        private System.Windows.Forms.Button suppliers;
        private System.Windows.Forms.Button customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button searchbtn;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Button orderBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private HomeUC1 homeUC11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ExportUC exportUC1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Timer timer1;
    }
}