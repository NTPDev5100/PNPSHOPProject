namespace phatnguyen
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnHideForm = new System.Windows.Forms.Button();
            this.productControl1 = new phatnguyen.ProductControl();
            this.billControl2 = new phatnguyen.BillControl();
            this.staffControl1 = new phatnguyen.StaffControl();
            this.customerControl1 = new phatnguyen.CustomerControl();
            this.fisrtCustomerControl1 = new phatnguyen.FisrtCustomerControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnProduct);
            this.panel1.Controls.Add(this.btnStatistic);
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnStaff);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(209, 601);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 487);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(209, 114);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // btnProduct
            // 
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.ForeColor = System.Drawing.Color.White;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(12, 313);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(197, 54);
            this.btnProduct.TabIndex = 7;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.FlatAppearance.BorderSize = 0;
            this.btnStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistic.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStatistic.ForeColor = System.Drawing.Color.White;
            this.btnStatistic.Image = ((System.Drawing.Image)(resources.GetObject("btnStatistic.Image")));
            this.btnStatistic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatistic.Location = new System.Drawing.Point(12, 373);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(197, 54);
            this.btnStatistic.TabIndex = 8;
            this.btnStatistic.Text = "Statistics";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnBill
            // 
            this.btnBill.FlatAppearance.BorderSize = 0;
            this.btnBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBill.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBill.Location = new System.Drawing.Point(12, 253);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(197, 54);
            this.btnBill.TabIndex = 6;
            this.btnBill.Text = "Bill";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnStaff
            // 
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Image = ((System.Drawing.Image)(resources.GetObject("btnStaff.Image")));
            this.btnStaff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStaff.Location = new System.Drawing.Point(12, 193);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(197, 54);
            this.btnStaff.TabIndex = 5;
            this.btnStaff.Text = "Staff";
            this.btnStaff.UseVisualStyleBackColor = true;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(12, 133);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(197, 54);
            this.btnCustomer.TabIndex = 4;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SidePanel.Location = new System.Drawing.Point(3, 73);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 5;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(12, 73);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(197, 54);
            this.btnHome.TabIndex = 3;
            this.btnHome.Text = "         Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(209, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(842, 10);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(243, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(111, 143);
            this.panel3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "PNP Store";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(111, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1007, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 35);
            this.btnClose.TabIndex = 5;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(819, 22);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 17);
            this.lblName.TabIndex = 10;
            this.lblName.Text = "Name";
            // 
            // btnHideForm
            // 
            this.btnHideForm.BackColor = System.Drawing.SystemColors.Control;
            this.btnHideForm.FlatAppearance.BorderSize = 0;
            this.btnHideForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHideForm.Image = ((System.Drawing.Image)(resources.GetObject("btnHideForm.Image")));
            this.btnHideForm.Location = new System.Drawing.Point(969, 18);
            this.btnHideForm.Name = "btnHideForm";
            this.btnHideForm.Size = new System.Drawing.Size(32, 25);
            this.btnHideForm.TabIndex = 20;
            this.btnHideForm.UseVisualStyleBackColor = false;
            this.btnHideForm.Click += new System.EventHandler(this.btnHideForm_Click);
            // 
            // productControl1
            // 
            this.productControl1.Location = new System.Drawing.Point(209, 149);
            this.productControl1.Name = "productControl1";
            this.productControl1.Size = new System.Drawing.Size(842, 452);
            this.productControl1.TabIndex = 15;
            // 
            // billControl2
            // 
            this.billControl2.Location = new System.Drawing.Point(209, 149);
            this.billControl2.Name = "billControl2";
            this.billControl2.Size = new System.Drawing.Size(842, 452);
            this.billControl2.TabIndex = 14;
            // 
            // staffControl1
            // 
            this.staffControl1.Location = new System.Drawing.Point(209, 149);
            this.staffControl1.Name = "staffControl1";
            this.staffControl1.Size = new System.Drawing.Size(842, 452);
            this.staffControl1.TabIndex = 13;
            // 
            // customerControl1
            // 
            this.customerControl1.BackColor = System.Drawing.Color.White;
            this.customerControl1.Location = new System.Drawing.Point(209, 149);
            this.customerControl1.Name = "customerControl1";
            this.customerControl1.Size = new System.Drawing.Size(842, 452);
            this.customerControl1.TabIndex = 12;
            // 
            // fisrtCustomerControl1
            // 
            this.fisrtCustomerControl1.BackColor = System.Drawing.Color.White;
            this.fisrtCustomerControl1.Location = new System.Drawing.Point(209, 149);
            this.fisrtCustomerControl1.Name = "fisrtCustomerControl1";
            this.fisrtCustomerControl1.Size = new System.Drawing.Size(842, 452);
            this.fisrtCustomerControl1.TabIndex = 11;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1051, 601);
            this.Controls.Add(this.btnHideForm);
            this.Controls.Add(this.productControl1);
            this.Controls.Add(this.billControl2);
            this.Controls.Add(this.staffControl1);
            this.Controls.Add(this.customerControl1);
            this.Controls.Add(this.fisrtCustomerControl1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnStaff;
        private FisrtCustomerControl fisrtCustomerControl1;
        private CustomerControl customerControl1;
        private StaffControl staffControl1;
        private BillControl billControl2;
        private ProductControl productControl1;
        private System.Windows.Forms.Button btnHideForm;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}