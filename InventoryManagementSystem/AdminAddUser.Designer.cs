namespace InventoryManagementSystem
{
    partial class AdminAddUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addUsers_clearBtn = new System.Windows.Forms.Button();
            this.addUsers_removeBtn = new System.Windows.Forms.Button();
            this.addUsers_updateBtn = new System.Windows.Forms.Button();
            this.addUsers_addBtn = new System.Windows.Forms.Button();
            this.addUsers_status = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addUsers_role = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addUsers_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addUsers_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(343, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 685);
            this.panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 600);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(25, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "All Users Data";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.addUsers_clearBtn);
            this.panel1.Controls.Add(this.addUsers_removeBtn);
            this.panel1.Controls.Add(this.addUsers_updateBtn);
            this.panel1.Controls.Add(this.addUsers_addBtn);
            this.panel1.Controls.Add(this.addUsers_status);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.addUsers_role);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addUsers_password);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addUsers_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 685);
            this.panel1.TabIndex = 2;
            // 
            // addUsers_clearBtn
            // 
            this.addUsers_clearBtn.Location = new System.Drawing.Point(181, 327);
            this.addUsers_clearBtn.Name = "addUsers_clearBtn";
            this.addUsers_clearBtn.Size = new System.Drawing.Size(99, 44);
            this.addUsers_clearBtn.TabIndex = 11;
            this.addUsers_clearBtn.Text = "Clear";
            this.addUsers_clearBtn.UseVisualStyleBackColor = true;
            this.addUsers_clearBtn.Click += new System.EventHandler(this.addUsers_clearBtn_Click);
            // 
            // addUsers_removeBtn
            // 
            this.addUsers_removeBtn.Location = new System.Drawing.Point(42, 327);
            this.addUsers_removeBtn.Name = "addUsers_removeBtn";
            this.addUsers_removeBtn.Size = new System.Drawing.Size(99, 44);
            this.addUsers_removeBtn.TabIndex = 10;
            this.addUsers_removeBtn.Text = "Remove";
            this.addUsers_removeBtn.UseVisualStyleBackColor = true;
            this.addUsers_removeBtn.Click += new System.EventHandler(this.addUsers_removeBtn_Click);
            // 
            // addUsers_updateBtn
            // 
            this.addUsers_updateBtn.Location = new System.Drawing.Point(181, 277);
            this.addUsers_updateBtn.Name = "addUsers_updateBtn";
            this.addUsers_updateBtn.Size = new System.Drawing.Size(99, 44);
            this.addUsers_updateBtn.TabIndex = 9;
            this.addUsers_updateBtn.Text = "Update";
            this.addUsers_updateBtn.UseVisualStyleBackColor = true;
            this.addUsers_updateBtn.Click += new System.EventHandler(this.addUsers_updateBtn_Click);
            // 
            // addUsers_addBtn
            // 
            this.addUsers_addBtn.Location = new System.Drawing.Point(42, 277);
            this.addUsers_addBtn.Name = "addUsers_addBtn";
            this.addUsers_addBtn.Size = new System.Drawing.Size(99, 44);
            this.addUsers_addBtn.TabIndex = 8;
            this.addUsers_addBtn.Text = "Add";
            this.addUsers_addBtn.UseVisualStyleBackColor = true;
            this.addUsers_addBtn.Click += new System.EventHandler(this.addUsers_addBtn_Click);
            // 
            // addUsers_status
            // 
            this.addUsers_status.FormattingEnabled = true;
            this.addUsers_status.Items.AddRange(new object[] {
            "Active",
            "Inactive",
            "Approval"});
            this.addUsers_status.Location = new System.Drawing.Point(40, 231);
            this.addUsers_status.Name = "addUsers_status";
            this.addUsers_status.Size = new System.Drawing.Size(264, 24);
            this.addUsers_status.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Status";
            // 
            // addUsers_role
            // 
            this.addUsers_role.FormattingEnabled = true;
            this.addUsers_role.Items.AddRange(new object[] {
            "Admin",
            "Cashier"});
            this.addUsers_role.Location = new System.Drawing.Point(40, 175);
            this.addUsers_role.Name = "addUsers_role";
            this.addUsers_role.Size = new System.Drawing.Size(264, 24);
            this.addUsers_role.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Role";
            // 
            // addUsers_password
            // 
            this.addUsers_password.Location = new System.Drawing.Point(40, 118);
            this.addUsers_password.Name = "addUsers_password";
            this.addUsers_password.Size = new System.Drawing.Size(264, 22);
            this.addUsers_password.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // addUsers_username
            // 
            this.addUsers_username.Location = new System.Drawing.Point(40, 64);
            this.addUsers_username.Name = "addUsers_username";
            this.addUsers_username.Size = new System.Drawing.Size(264, 22);
            this.addUsers_username.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // AdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddUser";
            this.Size = new System.Drawing.Size(1107, 707);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addUsers_clearBtn;
        private System.Windows.Forms.Button addUsers_removeBtn;
        private System.Windows.Forms.Button addUsers_updateBtn;
        private System.Windows.Forms.Button addUsers_addBtn;
        private System.Windows.Forms.ComboBox addUsers_status;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addUsers_role;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addUsers_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addUsers_username;
        private System.Windows.Forms.Label label1;
    }
}
