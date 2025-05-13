namespace Front_end_for_POS
{
    partial class salesdashboard
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnnewinvoice = new System.Windows.Forms.Button();
            this.btnchangeprice = new System.Windows.Forms.Button();
            this.btnadvancedpayment = new System.Windows.Forms.Button();
            this.btnsalesman = new System.Windows.Forms.Button();
            this.btncustomer = new System.Windows.Forms.Button();
            this.btnshiftclose = new System.Windows.Forms.Button();
            this.btnpayment = new System.Windows.Forms.Button();
            this.btnpettycash = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(16, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Search Your item";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnnewinvoice
            // 
            this.btnnewinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnewinvoice.Location = new System.Drawing.Point(868, 112);
            this.btnnewinvoice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnewinvoice.Name = "btnnewinvoice";
            this.btnnewinvoice.Size = new System.Drawing.Size(152, 28);
            this.btnnewinvoice.TabIndex = 1;
            this.btnnewinvoice.Text = "New Invoice";
            this.btnnewinvoice.UseVisualStyleBackColor = true;
            // 
            // btnchangeprice
            // 
            this.btnchangeprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchangeprice.Location = new System.Drawing.Point(868, 148);
            this.btnchangeprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnchangeprice.Name = "btnchangeprice";
            this.btnchangeprice.Size = new System.Drawing.Size(152, 28);
            this.btnchangeprice.TabIndex = 2;
            this.btnchangeprice.Text = "Change price";
            this.btnchangeprice.UseVisualStyleBackColor = true;
            // 
            // btnadvancedpayment
            // 
            this.btnadvancedpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadvancedpayment.Location = new System.Drawing.Point(868, 183);
            this.btnadvancedpayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadvancedpayment.Name = "btnadvancedpayment";
            this.btnadvancedpayment.Size = new System.Drawing.Size(152, 55);
            this.btnadvancedpayment.TabIndex = 3;
            this.btnadvancedpayment.Text = "Advanced payment";
            this.btnadvancedpayment.UseVisualStyleBackColor = true;
            this.btnadvancedpayment.Click += new System.EventHandler(this.btnadvancedpayment_Click);
            // 
            // btnsalesman
            // 
            this.btnsalesman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsalesman.Location = new System.Drawing.Point(26, 513);
            this.btnsalesman.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsalesman.Name = "btnsalesman";
            this.btnsalesman.Size = new System.Drawing.Size(156, 28);
            this.btnsalesman.TabIndex = 4;
            this.btnsalesman.Text = "Select salesman";
            this.btnsalesman.UseVisualStyleBackColor = true;
            this.btnsalesman.Click += new System.EventHandler(this.btnsalesman_Click);
            // 
            // btncustomer
            // 
            this.btncustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncustomer.Location = new System.Drawing.Point(190, 513);
            this.btncustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btncustomer.Name = "btncustomer";
            this.btncustomer.Size = new System.Drawing.Size(165, 28);
            this.btncustomer.TabIndex = 5;
            this.btncustomer.Text = "Select customer";
            this.btncustomer.UseVisualStyleBackColor = true;
            this.btncustomer.Click += new System.EventHandler(this.btncustomer_Click);
            // 
            // btnshiftclose
            // 
            this.btnshiftclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshiftclose.Location = new System.Drawing.Point(920, 15);
            this.btnshiftclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnshiftclose.Name = "btnshiftclose";
            this.btnshiftclose.Size = new System.Drawing.Size(119, 28);
            this.btnshiftclose.TabIndex = 6;
            this.btnshiftclose.Text = "End Shift";
            this.btnshiftclose.UseVisualStyleBackColor = true;
            this.btnshiftclose.Click += new System.EventHandler(this.btnshiftclose_Click);
            // 
            // btnpayment
            // 
            this.btnpayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpayment.Location = new System.Drawing.Point(868, 437);
            this.btnpayment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpayment.Name = "btnpayment";
            this.btnpayment.Size = new System.Drawing.Size(152, 62);
            this.btnpayment.TabIndex = 7;
            this.btnpayment.Text = "Payment";
            this.btnpayment.UseVisualStyleBackColor = true;
            // 
            // btnpettycash
            // 
            this.btnpettycash.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnpettycash.Location = new System.Drawing.Point(868, 246);
            this.btnpettycash.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnpettycash.Name = "btnpettycash";
            this.btnpettycash.Size = new System.Drawing.Size(152, 28);
            this.btnpettycash.TabIndex = 11;
            this.btnpettycash.Text = "Pettycash allowing";
            this.btnpettycash.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item_name,
            this.Quantity,
            this.Price});
            this.dataGridView1.Location = new System.Drawing.Point(65, 148);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(640, 267);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Item_name
            // 
            this.Item_name.HeaderText = "Item Name";
            this.Item_name.MinimumWidth = 6;
            this.Item_name.Name = "Item_name";
            this.Item_name.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.Width = 125;
            // 
            // salesdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnpettycash);
            this.Controls.Add(this.btnpayment);
            this.Controls.Add(this.btnshiftclose);
            this.Controls.Add(this.btncustomer);
            this.Controls.Add(this.btnsalesman);
            this.Controls.Add(this.btnadvancedpayment);
            this.Controls.Add(this.btnchangeprice);
            this.Controls.Add(this.btnnewinvoice);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "salesdashboard";
            this.Text = "salesdashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnnewinvoice;
        private System.Windows.Forms.Button btnchangeprice;
        private System.Windows.Forms.Button btnadvancedpayment;
        private System.Windows.Forms.Button btnsalesman;
        private System.Windows.Forms.Button btncustomer;
        private System.Windows.Forms.Button btnshiftclose;
        private System.Windows.Forms.Button btnpayment;
        private System.Windows.Forms.Button btnpettycash;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}