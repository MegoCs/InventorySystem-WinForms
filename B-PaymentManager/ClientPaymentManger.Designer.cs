namespace B_PaymentManager
{
    partial class ClientPaymentManger
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
            this.searchBtn = new System.Windows.Forms.Button();
            this.clientNameComb = new System.Windows.Forms.ComboBox();
            this.clientNationalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.billProductDetailsDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.billsProductDataGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.billsDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billProductDetailsDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsProductDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(550, 97);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(254, 32);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // clientNameComb
            // 
            this.clientNameComb.FormattingEnabled = true;
            this.clientNameComb.Location = new System.Drawing.Point(550, 60);
            this.clientNameComb.Margin = new System.Windows.Forms.Padding(4);
            this.clientNameComb.Name = "clientNameComb";
            this.clientNameComb.Size = new System.Drawing.Size(252, 26);
            this.clientNameComb.TabIndex = 1;
            // 
            // clientNationalTxt
            // 
            this.clientNationalTxt.Location = new System.Drawing.Point(550, 22);
            this.clientNationalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.clientNationalTxt.Name = "clientNationalTxt";
            this.clientNationalTxt.Size = new System.Drawing.Size(252, 24);
            this.clientNationalTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(827, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "الرقم القومى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(833, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم العميل";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.billProductDetailsDataGrid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.billsProductDataGrid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.billsDataGrid);
            this.panel1.Controls.Add(this.clientNationalTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clientNameComb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 511);
            this.panel1.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(316, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "تفاصيل اقساط الصنف";
            // 
            // billProductDetailsDataGrid
            // 
            this.billProductDetailsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billProductDetailsDataGrid.Location = new System.Drawing.Point(14, 255);
            this.billProductDetailsDataGrid.Name = "billProductDetailsDataGrid";
            this.billProductDetailsDataGrid.Size = new System.Drawing.Size(418, 238);
            this.billProductDetailsDataGrid.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(764, 218);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "الاصناف المدونة على الفاتورة";
            // 
            // billsProductDataGrid
            // 
            this.billsProductDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsProductDataGrid.Location = new System.Drawing.Point(439, 255);
            this.billsProductDataGrid.Name = "billsProductDataGrid";
            this.billsProductDataGrid.Size = new System.Drawing.Size(478, 238);
            this.billsProductDataGrid.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "الفواتير الخاصة بالعميل";
            // 
            // billsDataGrid
            // 
            this.billsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billsDataGrid.Location = new System.Drawing.Point(14, 56);
            this.billsDataGrid.Name = "billsDataGrid";
            this.billsDataGrid.Size = new System.Drawing.Size(418, 150);
            this.billsDataGrid.TabIndex = 5;
            // 
            // ClientPaymentManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 511);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClientPaymentManger";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تفاصيل اقساط العملاء";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billProductDetailsDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsProductDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billsDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox clientNameComb;
        private System.Windows.Forms.TextBox clientNationalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView billsDataGrid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView billProductDetailsDataGrid;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView billsProductDataGrid;
        private System.Windows.Forms.Label label3;
    }
}