namespace InventoryManagementSystem
{
    partial class AdminAddCategories
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.addCategories_clearBtn = new System.Windows.Forms.Button();
            this.addCategories_removeBtn = new System.Windows.Forms.Button();
            this.addCategories_updateBtn = new System.Windows.Forms.Button();
            this.addCategories_addBtn = new System.Windows.Forms.Button();
            this.addCategories_category = new System.Windows.Forms.TextBox();
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
            this.panel2.Location = new System.Drawing.Point(343, 11);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 685);
            this.panel2.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(21, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(709, 600);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.addCategories_clearBtn);
            this.panel1.Controls.Add(this.addCategories_removeBtn);
            this.panel1.Controls.Add(this.addCategories_updateBtn);
            this.panel1.Controls.Add(this.addCategories_addBtn);
            this.panel1.Controls.Add(this.addCategories_category);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 11);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 685);
            this.panel1.TabIndex = 4;
            // 
            // addCategories_clearBtn
            // 
            this.addCategories_clearBtn.Location = new System.Drawing.Point(188, 158);
            this.addCategories_clearBtn.Name = "addCategories_clearBtn";
            this.addCategories_clearBtn.Size = new System.Drawing.Size(99, 44);
            this.addCategories_clearBtn.TabIndex = 11;
            this.addCategories_clearBtn.Text = "Clear";
            this.addCategories_clearBtn.UseVisualStyleBackColor = true;
            this.addCategories_clearBtn.Click += new System.EventHandler(this.addCategories_clearBtn_Click);
            // 
            // addCategories_removeBtn
            // 
            this.addCategories_removeBtn.Location = new System.Drawing.Point(49, 158);
            this.addCategories_removeBtn.Name = "addCategories_removeBtn";
            this.addCategories_removeBtn.Size = new System.Drawing.Size(99, 44);
            this.addCategories_removeBtn.TabIndex = 10;
            this.addCategories_removeBtn.Text = "Remove";
            this.addCategories_removeBtn.UseVisualStyleBackColor = true;
            this.addCategories_removeBtn.Click += new System.EventHandler(this.addCategories_removeBtn_Click);
            // 
            // addCategories_updateBtn
            // 
            this.addCategories_updateBtn.Location = new System.Drawing.Point(188, 108);
            this.addCategories_updateBtn.Name = "addCategories_updateBtn";
            this.addCategories_updateBtn.Size = new System.Drawing.Size(99, 44);
            this.addCategories_updateBtn.TabIndex = 9;
            this.addCategories_updateBtn.Text = "Update";
            this.addCategories_updateBtn.UseVisualStyleBackColor = true;
            this.addCategories_updateBtn.Click += new System.EventHandler(this.addCategories_updateBtn_Click);
            // 
            // addCategories_addBtn
            // 
            this.addCategories_addBtn.Location = new System.Drawing.Point(49, 108);
            this.addCategories_addBtn.Name = "addCategories_addBtn";
            this.addCategories_addBtn.Size = new System.Drawing.Size(99, 44);
            this.addCategories_addBtn.TabIndex = 8;
            this.addCategories_addBtn.Text = "Add";
            this.addCategories_addBtn.UseVisualStyleBackColor = true;
            this.addCategories_addBtn.Click += new System.EventHandler(this.addCategories_addBtn_Click);
            // 
            // addCategories_category
            // 
            this.addCategories_category.Location = new System.Drawing.Point(40, 64);
            this.addCategories_category.Name = "addCategories_category";
            this.addCategories_category.Size = new System.Drawing.Size(264, 22);
            this.addCategories_category.TabIndex = 1;
            this.addCategories_category.TextChanged += new System.EventHandler(this.addCategories_category_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(47, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Category";
            // 
            // AdminAddCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddCategories";
            this.Size = new System.Drawing.Size(1107, 707);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addCategories_clearBtn;
        private System.Windows.Forms.Button addCategories_removeBtn;
        private System.Windows.Forms.Button addCategories_updateBtn;
        private System.Windows.Forms.Button addCategories_addBtn;
        private System.Windows.Forms.TextBox addCategories_category;
        private System.Windows.Forms.Label label1;
    }
}
