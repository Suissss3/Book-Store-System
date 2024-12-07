namespace InventoryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button8 = new System.Windows.Forms.Button();
            this.customers_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.addCategories_btn = new System.Windows.Forms.Button();
            this.addUsers_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.user_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.adminDashboard1 = new InventoryManagementSystem.AdminDashboard();
            this.adminAddUser1 = new InventoryManagementSystem.AdminAddUser();
            this.adminAddCategories1 = new InventoryManagementSystem.AdminAddCategories();
            this.adminAddProducts1 = new InventoryManagementSystem.AdminAddProducts();
            this.cashierCustomersForm1 = new InventoryManagementSystem.CashierCustomersForm();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(8, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1492, 50);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Location = new System.Drawing.Point(8, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1374, 754);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory Management System";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1302, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "X";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(647, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book Store System";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1421, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.customers_btn);
            this.panel3.Controls.Add(this.addProducts_btn);
            this.panel3.Controls.Add(this.addCategories_btn);
            this.panel3.Controls.Add(this.addUsers_btn);
            this.panel3.Controls.Add(this.dashboard_btn);
            this.panel3.Controls.Add(this.user_username);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(8, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 707);
            this.panel3.TabIndex = 6;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(21, 630);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(322, 50);
            this.button8.TabIndex = 17;
            this.button8.Text = "Log Out";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // customers_btn
            // 
            this.customers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customers_btn.Location = new System.Drawing.Point(21, 398);
            this.customers_btn.Name = "customers_btn";
            this.customers_btn.Size = new System.Drawing.Size(322, 50);
            this.customers_btn.TabIndex = 16;
            this.customers_btn.Text = "Customers";
            this.customers_btn.UseVisualStyleBackColor = true;
            this.customers_btn.Click += new System.EventHandler(this.customers_btn_Click_1);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_btn.Location = new System.Drawing.Point(21, 342);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(322, 50);
            this.addProducts_btn.TabIndex = 15;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // addCategories_btn
            // 
            this.addCategories_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategories_btn.Location = new System.Drawing.Point(21, 291);
            this.addCategories_btn.Name = "addCategories_btn";
            this.addCategories_btn.Size = new System.Drawing.Size(322, 45);
            this.addCategories_btn.TabIndex = 14;
            this.addCategories_btn.Text = "Add Categories";
            this.addCategories_btn.UseVisualStyleBackColor = true;
            this.addCategories_btn.Click += new System.EventHandler(this.button5_Click);
            // 
            // addUsers_btn
            // 
            this.addUsers_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUsers_btn.Location = new System.Drawing.Point(21, 237);
            this.addUsers_btn.Name = "addUsers_btn";
            this.addUsers_btn.Size = new System.Drawing.Size(322, 48);
            this.addUsers_btn.TabIndex = 13;
            this.addUsers_btn.Text = "Add Users";
            this.addUsers_btn.UseVisualStyleBackColor = true;
            this.addUsers_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboard_btn.Location = new System.Drawing.Point(21, 183);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(322, 48);
            this.dashboard_btn.TabIndex = 12;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // user_username
            // 
            this.user_username.AutoSize = true;
            this.user_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username.Location = new System.Drawing.Point(178, 141);
            this.user_username.Name = "user_username";
            this.user_username.Size = new System.Drawing.Size(87, 29);
            this.user_username.TabIndex = 11;
            this.user_username.Text = "Admin.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 10;
            this.label3.Text = "Welcome,";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(122, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.adminDashboard1);
            this.panel4.Controls.Add(this.adminAddUser1);
            this.panel4.Controls.Add(this.adminAddCategories1);
            this.panel4.Controls.Add(this.adminAddProducts1);
            this.panel4.Controls.Add(this.cashierCustomersForm1);
            this.panel4.Location = new System.Drawing.Point(393, 60);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1107, 707);
            this.panel4.TabIndex = 18;
            // 
            // adminDashboard1
            // 
            this.adminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.adminDashboard1.Name = "adminDashboard1";
            this.adminDashboard1.Size = new System.Drawing.Size(1107, 707);
            this.adminDashboard1.TabIndex = 4;
            // 
            // adminAddUser1
            // 
            this.adminAddUser1.Location = new System.Drawing.Point(0, 0);
            this.adminAddUser1.Name = "adminAddUser1";
            this.adminAddUser1.Size = new System.Drawing.Size(1107, 707);
            this.adminAddUser1.TabIndex = 3;
            // 
            // adminAddCategories1
            // 
            this.adminAddCategories1.Location = new System.Drawing.Point(0, 0);
            this.adminAddCategories1.Name = "adminAddCategories1";
            this.adminAddCategories1.Size = new System.Drawing.Size(1107, 707);
            this.adminAddCategories1.TabIndex = 2;
            // 
            // adminAddProducts1
            // 
            this.adminAddProducts1.Location = new System.Drawing.Point(0, 0);
            this.adminAddProducts1.Name = "adminAddProducts1";
            this.adminAddProducts1.Size = new System.Drawing.Size(1107, 707);
            this.adminAddProducts1.TabIndex = 1;
            // 
            // cashierCustomersForm1
            // 
            this.cashierCustomersForm1.Location = new System.Drawing.Point(0, 0);
            this.cashierCustomersForm1.Name = "cashierCustomersForm1";
            this.cashierCustomersForm1.Size = new System.Drawing.Size(1107, 707);
            this.cashierCustomersForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1529, 863);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label user_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button addCategories_btn;
        private System.Windows.Forms.Button addUsers_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button customers_btn;
        private System.Windows.Forms.Panel panel4;
        private AdminDashboard adminDashboard1;
        private AdminAddUser adminAddUser1;
        private AdminAddCategories adminAddCategories1;
        private AdminAddProducts adminAddProducts1;
        private CashierCustomersForm cashierCustomersForm1;
    }
}