namespace InventoryManagementSystem
{
    partial class CashierOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashierOrder));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cashierOrder_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrder_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrder_addBtn = new System.Windows.Forms.Button();
            this.cashierOrder_qty = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.cashierOrder_prodID = new System.Windows.Forms.ComboBox();
            this.cashierOrder_category = new System.Windows.Forms.ComboBox();
            this.cashierOrder_price = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cashierOrder_prodName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cashierOrder_totalPrice = new System.Windows.Forms.Label();
            this.cashierOrder_amount = new System.Windows.Forms.TextBox();
            this.cashierOrder_change = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cashierOrder_payOrders = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.cashierOrder_receipt = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(656, 305);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 35);
            this.label1.TabIndex = 5;
            this.label1.Text = "Available Books";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cashierOrder_clearBtn);
            this.panel1.Controls.Add(this.cashierOrder_removeBtn);
            this.panel1.Controls.Add(this.cashierOrder_addBtn);
            this.panel1.Controls.Add(this.cashierOrder_qty);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cashierOrder_prodID);
            this.panel1.Controls.Add(this.cashierOrder_category);
            this.panel1.Controls.Add(this.cashierOrder_price);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cashierOrder_prodName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(3, 365);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 339);
            this.panel1.TabIndex = 6;
            // 
            // cashierOrder_clearBtn
            // 
            this.cashierOrder_clearBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cashierOrder_clearBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_clearBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierOrder_clearBtn.Location = new System.Drawing.Point(470, 235);
            this.cashierOrder_clearBtn.Name = "cashierOrder_clearBtn";
            this.cashierOrder_clearBtn.Size = new System.Drawing.Size(141, 34);
            this.cashierOrder_clearBtn.TabIndex = 24;
            this.cashierOrder_clearBtn.Text = "CLEAR";
            this.cashierOrder_clearBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_clearBtn.Click += new System.EventHandler(this.cashierOrder_clearBtn_Click);
            // 
            // cashierOrder_removeBtn
            // 
            this.cashierOrder_removeBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cashierOrder_removeBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_removeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierOrder_removeBtn.Location = new System.Drawing.Point(176, 235);
            this.cashierOrder_removeBtn.Name = "cashierOrder_removeBtn";
            this.cashierOrder_removeBtn.Size = new System.Drawing.Size(141, 34);
            this.cashierOrder_removeBtn.TabIndex = 23;
            this.cashierOrder_removeBtn.Text = "REMOVE";
            this.cashierOrder_removeBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_removeBtn.Click += new System.EventHandler(this.cashierOrder_removeBtn_Click);
            // 
            // cashierOrder_addBtn
            // 
            this.cashierOrder_addBtn.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cashierOrder_addBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierOrder_addBtn.Location = new System.Drawing.Point(29, 235);
            this.cashierOrder_addBtn.Name = "cashierOrder_addBtn";
            this.cashierOrder_addBtn.Size = new System.Drawing.Size(141, 34);
            this.cashierOrder_addBtn.TabIndex = 21;
            this.cashierOrder_addBtn.Text = "ADD";
            this.cashierOrder_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrder_addBtn.Click += new System.EventHandler(this.cashierOrder_addBtn_Click);
            // 
            // cashierOrder_qty
            // 
            this.cashierOrder_qty.Location = new System.Drawing.Point(405, 131);
            this.cashierOrder_qty.Name = "cashierOrder_qty";
            this.cashierOrder_qty.Size = new System.Drawing.Size(175, 22);
            this.cashierOrder_qty.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(324, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Quantity";
            // 
            // cashierOrder_prodID
            // 
            this.cashierOrder_prodID.FormattingEnabled = true;
            this.cashierOrder_prodID.Location = new System.Drawing.Point(405, 46);
            this.cashierOrder_prodID.Name = "cashierOrder_prodID";
            this.cashierOrder_prodID.Size = new System.Drawing.Size(162, 24);
            this.cashierOrder_prodID.TabIndex = 8;
            this.cashierOrder_prodID.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_prodID_SelectedIndexChanged);
            // 
            // cashierOrder_category
            // 
            this.cashierOrder_category.FormattingEnabled = true;
            this.cashierOrder_category.Location = new System.Drawing.Point(143, 48);
            this.cashierOrder_category.Name = "cashierOrder_category";
            this.cashierOrder_category.Size = new System.Drawing.Size(121, 24);
            this.cashierOrder_category.TabIndex = 7;
            this.cashierOrder_category.SelectedIndexChanged += new System.EventHandler(this.cashierOrder_category_SelectedIndexChanged);
            // 
            // cashierOrder_price
            // 
            this.cashierOrder_price.AutoSize = true;
            this.cashierOrder_price.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_price.Location = new System.Drawing.Point(184, 169);
            this.cashierOrder_price.Name = "cashierOrder_price";
            this.cashierOrder_price.Size = new System.Drawing.Size(82, 19);
            this.cashierOrder_price.TabIndex = 6;
            this.cashierOrder_price.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(106, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Price(P):";
            // 
            // cashierOrder_prodName
            // 
            this.cashierOrder_prodName.AutoSize = true;
            this.cashierOrder_prodName.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_prodName.Location = new System.Drawing.Point(184, 131);
            this.cashierOrder_prodName.Name = "cashierOrder_prodName";
            this.cashierOrder_prodName.Size = new System.Drawing.Size(82, 19);
            this.cashierOrder_prodName.TabIndex = 4;
            this.cashierOrder_prodName.Text = "Category:";
            this.cashierOrder_prodName.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(55, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Product Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Product ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Category:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(861, 444);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 19);
            this.label10.TabIndex = 27;
            this.label10.Text = "Amount(P):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(844, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 19);
            this.label9.TabIndex = 28;
            this.label9.Text = "Total Price(P):";
            // 
            // cashierOrder_totalPrice
            // 
            this.cashierOrder_totalPrice.AutoSize = true;
            this.cashierOrder_totalPrice.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_totalPrice.Location = new System.Drawing.Point(955, 413);
            this.cashierOrder_totalPrice.Name = "cashierOrder_totalPrice";
            this.cashierOrder_totalPrice.Size = new System.Drawing.Size(40, 19);
            this.cashierOrder_totalPrice.TabIndex = 29;
            this.cashierOrder_totalPrice.Text = "0.00";
            // 
            // cashierOrder_amount
            // 
            this.cashierOrder_amount.Location = new System.Drawing.Point(959, 443);
            this.cashierOrder_amount.Name = "cashierOrder_amount";
            this.cashierOrder_amount.Size = new System.Drawing.Size(115, 22);
            this.cashierOrder_amount.TabIndex = 32;
            this.cashierOrder_amount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cashierOrder_amount_KeyDown);
            // 
            // cashierOrder_change
            // 
            this.cashierOrder_change.AutoSize = true;
            this.cashierOrder_change.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_change.Location = new System.Drawing.Point(955, 468);
            this.cashierOrder_change.Name = "cashierOrder_change";
            this.cashierOrder_change.Size = new System.Drawing.Size(40, 19);
            this.cashierOrder_change.TabIndex = 34;
            this.cashierOrder_change.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(887, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 19);
            this.label13.TabIndex = 33;
            this.label13.Text = "Change:";
            // 
            // cashierOrder_payOrders
            // 
            this.cashierOrder_payOrders.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cashierOrder_payOrders.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_payOrders.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierOrder_payOrders.Location = new System.Drawing.Point(710, 548);
            this.cashierOrder_payOrders.Name = "cashierOrder_payOrders";
            this.cashierOrder_payOrders.Size = new System.Drawing.Size(364, 41);
            this.cashierOrder_payOrders.TabIndex = 35;
            this.cashierOrder_payOrders.Text = "PAY ORDERS";
            this.cashierOrder_payOrders.UseVisualStyleBackColor = false;
            this.cashierOrder_payOrders.Click += new System.EventHandler(this.cashierOrder_payOrders_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(665, 54);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(439, 305);
            this.dataGridView2.TabIndex = 36;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(788, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(190, 35);
            this.label14.TabIndex = 37;
            this.label14.Text = "Books Orders";
            // 
            // cashierOrder_receipt
            // 
            this.cashierOrder_receipt.BackColor = System.Drawing.SystemColors.HotTrack;
            this.cashierOrder_receipt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrder_receipt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cashierOrder_receipt.Location = new System.Drawing.Point(710, 610);
            this.cashierOrder_receipt.Name = "cashierOrder_receipt";
            this.cashierOrder_receipt.Size = new System.Drawing.Size(364, 41);
            this.cashierOrder_receipt.TabIndex = 38;
            this.cashierOrder_receipt.Text = "RECEIPT";
            this.cashierOrder_receipt.UseVisualStyleBackColor = false;
            this.cashierOrder_receipt.Click += new System.EventHandler(this.cashierOrder_receipt_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 19);
            this.label5.TabIndex = 25;
            // 
            // CashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cashierOrder_receipt);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.cashierOrder_payOrders);
            this.Controls.Add(this.cashierOrder_change);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cashierOrder_amount);
            this.Controls.Add(this.cashierOrder_totalPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CashierOrder";
            this.Size = new System.Drawing.Size(1107, 707);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrder_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cashierOrder_prodID;
        private System.Windows.Forms.ComboBox cashierOrder_category;
        private System.Windows.Forms.Label cashierOrder_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label cashierOrder_prodName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cashierOrder_qty;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button cashierOrder_clearBtn;
        private System.Windows.Forms.Button cashierOrder_removeBtn;
        private System.Windows.Forms.Button cashierOrder_addBtn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label cashierOrder_totalPrice;
        private System.Windows.Forms.TextBox cashierOrder_amount;
        private System.Windows.Forms.Label cashierOrder_change;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button cashierOrder_payOrders;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button cashierOrder_receipt;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label label5;
    }
}
