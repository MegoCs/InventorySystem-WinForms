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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchBtn = new System.Windows.Forms.Button();
            this.clientNameComb = new System.Windows.Forms.ComboBox();
            this.clientNationalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.printedReportBtn = new System.Windows.Forms.Button();
            this.newPayment = new System.Windows.Forms.Button();
            this.detailsGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteItemsBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(742, 90);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(254, 32);
            this.searchBtn.TabIndex = 0;
            this.searchBtn.Text = "بحث";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // clientNameComb
            // 
            this.clientNameComb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.clientNameComb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.clientNameComb.FormattingEnabled = true;
            this.clientNameComb.Location = new System.Drawing.Point(742, 53);
            this.clientNameComb.Margin = new System.Windows.Forms.Padding(4);
            this.clientNameComb.Name = "clientNameComb";
            this.clientNameComb.Size = new System.Drawing.Size(252, 26);
            this.clientNameComb.TabIndex = 1;
            this.clientNameComb.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientNameComb_MouseClick);
            // 
            // clientNationalTxt
            // 
            this.clientNationalTxt.Location = new System.Drawing.Point(742, 15);
            this.clientNationalTxt.Margin = new System.Windows.Forms.Padding(4);
            this.clientNationalTxt.Name = "clientNationalTxt";
            this.clientNationalTxt.Size = new System.Drawing.Size(252, 24);
            this.clientNationalTxt.TabIndex = 2;
            this.clientNationalTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.clientNationalTxt_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1019, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "الرقم القومى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1025, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "اسم العميل";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.deleteItemsBtn);
            this.panel1.Controls.Add(this.printedReportBtn);
            this.panel1.Controls.Add(this.newPayment);
            this.panel1.Controls.Add(this.detailsGrid);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.clientNationalTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.searchBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.clientNameComb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 444);
            this.panel1.TabIndex = 5;
            // 
            // printedReportBtn
            // 
            this.printedReportBtn.Location = new System.Drawing.Point(742, 401);
            this.printedReportBtn.Name = "printedReportBtn";
            this.printedReportBtn.Size = new System.Drawing.Size(341, 31);
            this.printedReportBtn.TabIndex = 17;
            this.printedReportBtn.Text = "طباعة هذا التقرير";
            this.printedReportBtn.UseVisualStyleBackColor = true;
            this.printedReportBtn.Click += new System.EventHandler(this.printedReportBtn_Click);
            // 
            // newPayment
            // 
            this.newPayment.Location = new System.Drawing.Point(220, 401);
            this.newPayment.Name = "newPayment";
            this.newPayment.Size = new System.Drawing.Size(127, 31);
            this.newPayment.TabIndex = 16;
            this.newPayment.Text = "دفع قسط";
            this.newPayment.UseVisualStyleBackColor = true;
            this.newPayment.Click += new System.EventHandler(this.newPayment_Click);
            // 
            // detailsGrid
            // 
            this.detailsGrid.AllowUserToAddRows = false;
            this.detailsGrid.AllowUserToDeleteRows = false;
            this.detailsGrid.AllowUserToResizeColumns = false;
            this.detailsGrid.AllowUserToResizeRows = false;
            this.detailsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.detailsGrid.BackgroundColor = System.Drawing.Color.LightGray;
            this.detailsGrid.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.detailsGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.detailsGrid.GridColor = System.Drawing.SystemColors.Control;
            this.detailsGrid.Location = new System.Drawing.Point(13, 139);
            this.detailsGrid.Margin = new System.Windows.Forms.Padding(4);
            this.detailsGrid.MultiSelect = false;
            this.detailsGrid.Name = "detailsGrid";
            this.detailsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.detailsGrid.RowHeadersVisible = false;
            this.detailsGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGrid.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.detailsGrid.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detailsGrid.RowTemplate.DefaultCellStyle.NullValue = null;
            this.detailsGrid.RowTemplate.ErrorText = "No data here";
            this.detailsGrid.RowTemplate.Height = 40;
            this.detailsGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detailsGrid.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.detailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detailsGrid.Size = new System.Drawing.Size(1069, 255);
            this.detailsGrid.StandardTab = true;
            this.detailsGrid.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "الاصناف المدونة على الفاتورة";
            // 
            // deleteItemsBtn
            // 
            this.deleteItemsBtn.Location = new System.Drawing.Point(85, 401);
            this.deleteItemsBtn.Name = "deleteItemsBtn";
            this.deleteItemsBtn.Size = new System.Drawing.Size(129, 31);
            this.deleteItemsBtn.TabIndex = 18;
            this.deleteItemsBtn.Text = "مرتجع";
            this.deleteItemsBtn.UseVisualStyleBackColor = true;
            this.deleteItemsBtn.Click += new System.EventHandler(this.deleteItemsBtn_Click);
            // 
            // ClientPaymentManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 444);
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
            ((System.ComponentModel.ISupportInitialize)(this.detailsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.ComboBox clientNameComb;
        private System.Windows.Forms.TextBox clientNationalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.DataGridView detailsGrid;
        private System.Windows.Forms.Button newPayment;
        private System.Windows.Forms.Button printedReportBtn;
        private System.Windows.Forms.Button deleteItemsBtn;
    }
}