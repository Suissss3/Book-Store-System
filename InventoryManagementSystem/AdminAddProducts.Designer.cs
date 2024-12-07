namespace InventoryManagementSystem
{
    partial class AdminAddProducts
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addProducts_clearBtn = new System.Windows.Forms.Button();
            this.addProducts_removeBtn = new System.Windows.Forms.Button();
            this.addProducts_updateBtn = new System.Windows.Forms.Button();
            this.addProducts_addBtn = new System.Windows.Forms.Button();
            this.addProducts_importBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.addProducts_imageView = new System.Windows.Forms.PictureBox();
            this.addProducts_status = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.addProducts_stock = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addProducts_category = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addProducts_price = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addProducts_prodName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addProducts_prodID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(12, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 341);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 32);
            this.label2.TabIndex = 2;
            this.label2.Text = "All Books";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 316);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.addProducts_clearBtn);
            this.panel2.Controls.Add(this.addProducts_removeBtn);
            this.panel2.Controls.Add(this.addProducts_updateBtn);
            this.panel2.Controls.Add(this.addProducts_addBtn);
            this.panel2.Controls.Add(this.addProducts_importBtn);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.addProducts_status);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.addProducts_stock);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.addProducts_category);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.addProducts_price);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addProducts_prodName);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.addProducts_prodID);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(12, 366);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1092, 341);
            this.panel2.TabIndex = 1;
            // 
            // addProducts_clearBtn
            // 
            this.addProducts_clearBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProducts_clearBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProducts_clearBtn.Location = new System.Drawing.Point(462, 235);
            this.addProducts_clearBtn.Name = "addProducts_clearBtn";
            this.addProducts_clearBtn.Size = new System.Drawing.Size(141, 34);
            this.addProducts_clearBtn.TabIndex = 20;
            this.addProducts_clearBtn.Text = "CLEAR";
            this.addProducts_clearBtn.UseVisualStyleBackColor = false;
            this.addProducts_clearBtn.Click += new System.EventHandler(this.addProducts_clearBtn_Click);
            // 
            // addProducts_removeBtn
            // 
            this.addProducts_removeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProducts_removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_removeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProducts_removeBtn.Location = new System.Drawing.Point(315, 235);
            this.addProducts_removeBtn.Name = "addProducts_removeBtn";
            this.addProducts_removeBtn.Size = new System.Drawing.Size(141, 34);
            this.addProducts_removeBtn.TabIndex = 19;
            this.addProducts_removeBtn.Text = "REMOVE";
            this.addProducts_removeBtn.UseVisualStyleBackColor = false;
            this.addProducts_removeBtn.Click += new System.EventHandler(this.addProducts_removeBtn_Click);
            // 
            // addProducts_updateBtn
            // 
            this.addProducts_updateBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProducts_updateBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_updateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProducts_updateBtn.Location = new System.Drawing.Point(168, 235);
            this.addProducts_updateBtn.Name = "addProducts_updateBtn";
            this.addProducts_updateBtn.Size = new System.Drawing.Size(141, 34);
            this.addProducts_updateBtn.TabIndex = 18;
            this.addProducts_updateBtn.Text = "UPDATE";
            this.addProducts_updateBtn.UseVisualStyleBackColor = false;
            this.addProducts_updateBtn.Click += new System.EventHandler(this.addProducts_updateBtn_Click);
            // 
            // addProducts_addBtn
            // 
            this.addProducts_addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProducts_addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProducts_addBtn.Location = new System.Drawing.Point(21, 235);
            this.addProducts_addBtn.Name = "addProducts_addBtn";
            this.addProducts_addBtn.Size = new System.Drawing.Size(141, 34);
            this.addProducts_addBtn.TabIndex = 17;
            this.addProducts_addBtn.Text = "ADD";
            this.addProducts_addBtn.UseVisualStyleBackColor = false;
            this.addProducts_addBtn.Click += new System.EventHandler(this.addProducts_addBtn_Click);
            // 
            // addProducts_importBtn
            // 
            this.addProducts_importBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.addProducts_importBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProducts_importBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addProducts_importBtn.Location = new System.Drawing.Point(839, 200);
            this.addProducts_importBtn.Name = "addProducts_importBtn";
            this.addProducts_importBtn.Size = new System.Drawing.Size(200, 34);
            this.addProducts_importBtn.TabIndex = 1;
            this.addProducts_importBtn.Text = "IMPORT";
            this.addProducts_importBtn.UseVisualStyleBackColor = false;
            this.addProducts_importBtn.Click += new System.EventHandler(this.addProducts_importBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel3.Controls.Add(this.addProducts_imageView);
            this.panel3.Location = new System.Drawing.Point(839, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 163);
            this.panel3.TabIndex = 16;
            // 
            // addProducts_imageView
            // 
            this.addProducts_imageView.Location = new System.Drawing.Point(17, 8);
            this.addProducts_imageView.Name = "addProducts_imageView";
            this.addProducts_imageView.Size = new System.Drawing.Size(165, 140);
            this.addProducts_imageView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.addProducts_imageView.TabIndex = 0;
            this.addProducts_imageView.TabStop = false;
            // 
            // addProducts_status
            // 
            this.addProducts_status.FormattingEnabled = true;
            this.addProducts_status.Items.AddRange(new object[] {
            "Available",
            "Not Available"});
            this.addProducts_status.Location = new System.Drawing.Point(161, 191);
            this.addProducts_status.Name = "addProducts_status";
            this.addProducts_status.Size = new System.Drawing.Size(174, 24);
            this.addProducts_status.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(85, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // addProducts_stock
            // 
            this.addProducts_stock.Location = new System.Drawing.Point(161, 157);
            this.addProducts_stock.Name = "addProducts_stock";
            this.addProducts_stock.Size = new System.Drawing.Size(174, 22);
            this.addProducts_stock.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(91, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Stock:";
            // 
            // addProducts_category
            // 
            this.addProducts_category.FormattingEnabled = true;
            this.addProducts_category.Location = new System.Drawing.Point(161, 87);
            this.addProducts_category.Name = "addProducts_category";
            this.addProducts_category.Size = new System.Drawing.Size(174, 24);
            this.addProducts_category.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Category:";
            // 
            // addProducts_price
            // 
            this.addProducts_price.Location = new System.Drawing.Point(161, 123);
            this.addProducts_price.Name = "addProducts_price";
            this.addProducts_price.Size = new System.Drawing.Size(174, 22);
            this.addProducts_price.TabIndex = 8;
            this.addProducts_price.TextChanged += new System.EventHandler(this.addProducts_price_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Price(P):";
            // 
            // addProducts_prodName
            // 
            this.addProducts_prodName.Location = new System.Drawing.Point(161, 57);
            this.addProducts_prodName.Name = "addProducts_prodName";
            this.addProducts_prodName.Size = new System.Drawing.Size(174, 22);
            this.addProducts_prodName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Product Name:";
            // 
            // addProducts_prodID
            // 
            this.addProducts_prodID.Location = new System.Drawing.Point(161, 22);
            this.addProducts_prodID.Name = "addProducts_prodID";
            this.addProducts_prodID.Size = new System.Drawing.Size(174, 22);
            this.addProducts_prodID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Product ID:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // AdminAddProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdminAddProducts";
            this.Size = new System.Drawing.Size(1107, 707);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addProducts_imageView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addProducts_prodName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addProducts_prodID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox addProducts_stock;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox addProducts_category;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addProducts_price;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox addProducts_imageView;
        private System.Windows.Forms.ComboBox addProducts_status;
        private System.Windows.Forms.Button addProducts_importBtn;
        private System.Windows.Forms.Button addProducts_clearBtn;
        private System.Windows.Forms.Button addProducts_removeBtn;
        private System.Windows.Forms.Button addProducts_updateBtn;
        private System.Windows.Forms.Button addProducts_addBtn;
    }
}
