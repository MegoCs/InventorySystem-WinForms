namespace B_PaymentManager
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.SalesTab = new System.Windows.Forms.TabPage();
            this.AddProductsTab = new System.Windows.Forms.TabPage();
            this.PaymentSearchTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.productGroupCom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.productOldPriceLab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.productAvailableLab = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.productTotalPriceTxt = new System.Windows.Forms.TextBox();
            this.productQuantatyTxt = new System.Windows.Forms.TextBox();
            this.productPriceTxt = new System.Windows.Forms.TextBox();
            this.productCodeTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.productPaidValueTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.StartTab = new System.Windows.Forms.TabPage();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label13 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.clientNameCom = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addNewClientBtn = new System.Windows.Forms.Button();
            this.AddClientTab = new System.Windows.Forms.TabPage();
            this.productsCountLab = new System.Windows.Forms.Label();
            this.billTotalPaidLab = new System.Windows.Forms.Label();
            this.billTotalPriceLab = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.SalesTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.StartTab);
            this.tabControl1.Controls.Add(this.SalesTab);
            this.tabControl1.Controls.Add(this.AddProductsTab);
            this.tabControl1.Controls.Add(this.PaymentSearchTab);
            this.tabControl1.Controls.Add(this.AddClientTab);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 150);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1316, 727);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // SalesTab
            // 
            this.SalesTab.AutoScroll = true;
            this.SalesTab.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.SalesTab.BackColor = System.Drawing.Color.Transparent;
            this.SalesTab.Controls.Add(this.panel1);
            this.SalesTab.Location = new System.Drawing.Point(4, 4);
            this.SalesTab.Name = "SalesTab";
            this.SalesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalesTab.Size = new System.Drawing.Size(1158, 719);
            this.SalesTab.TabIndex = 0;
            this.SalesTab.Text = "مبيعات";
            // 
            // AddProductsTab
            // 
            this.AddProductsTab.AutoScroll = true;
            this.AddProductsTab.BackColor = System.Drawing.Color.Transparent;
            this.AddProductsTab.Location = new System.Drawing.Point(4, 4);
            this.AddProductsTab.Name = "AddProductsTab";
            this.AddProductsTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddProductsTab.Size = new System.Drawing.Size(1158, 719);
            this.AddProductsTab.TabIndex = 1;
            this.AddProductsTab.Text = "اضافة اصناف";
            // 
            // PaymentSearchTab
            // 
            this.PaymentSearchTab.AutoScroll = true;
            this.PaymentSearchTab.BackColor = System.Drawing.Color.Transparent;
            this.PaymentSearchTab.Location = new System.Drawing.Point(4, 4);
            this.PaymentSearchTab.Name = "PaymentSearchTab";
            this.PaymentSearchTab.Size = new System.Drawing.Size(1158, 719);
            this.PaymentSearchTab.TabIndex = 2;
            this.PaymentSearchTab.Text = "بحث الاقساط";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.billTotalPriceLab);
            this.panel1.Controls.Add(this.billTotalPaidLab);
            this.panel1.Controls.Add(this.productsCountLab);
            this.panel1.Controls.Add(this.addNewClientBtn);
            this.panel1.Controls.Add(this.clientNameCom);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.productPaidValueTxt);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.productGroupCom);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.productNameTxt);
            this.panel1.Controls.Add(this.productOldPriceLab);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.productAvailableLab);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.productTotalPriceTxt);
            this.panel1.Controls.Add(this.productQuantatyTxt);
            this.panel1.Controls.Add(this.productPriceTxt);
            this.panel1.Controls.Add(this.productCodeTxt);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1152, 713);
            this.panel1.TabIndex = 63;
            // 
            // productGroupCom
            // 
            this.productGroupCom.FormattingEnabled = true;
            this.productGroupCom.Location = new System.Drawing.Point(612, 68);
            this.productGroupCom.MaxDropDownItems = 20;
            this.productGroupCom.Name = "productGroupCom";
            this.productGroupCom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productGroupCom.Size = new System.Drawing.Size(332, 33);
            this.productGroupCom.TabIndex = 85;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(612, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 34);
            this.label7.TabIndex = 84;
            this.label7.Text = "نوع الصنف";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label12.Location = new System.Drawing.Point(841, 112);
            this.label12.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 34);
            this.label12.TabIndex = 83;
            this.label12.Text = "كود الصنف";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNameTxt
            // 
            this.productNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productNameTxt.Location = new System.Drawing.Point(228, 72);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productNameTxt.Size = new System.Drawing.Size(372, 26);
            this.productNameTxt.TabIndex = 82;
            this.productNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productOldPriceLab
            // 
            this.productOldPriceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productOldPriceLab.Location = new System.Drawing.Point(720, 157);
            this.productOldPriceLab.Name = "productOldPriceLab";
            this.productOldPriceLab.ReadOnly = true;
            this.productOldPriceLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productOldPriceLab.Size = new System.Drawing.Size(113, 26);
            this.productOldPriceLab.TabIndex = 81;
            this.productOldPriceLab.Text = "0.0";
            this.productOldPriceLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(720, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 32);
            this.label1.TabIndex = 80;
            this.label1.Text = "السعر القديم";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(110, 116);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(112, 30);
            this.label9.TabIndex = 79;
            this.label9.Text = "تاربخ اليوم";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productAvailableLab
            // 
            this.productAvailableLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productAvailableLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productAvailableLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productAvailableLab.Location = new System.Drawing.Point(534, 156);
            this.productAvailableLab.Name = "productAvailableLab";
            this.productAvailableLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productAvailableLab.Size = new System.Drawing.Size(64, 26);
            this.productAvailableLab.TabIndex = 78;
            this.productAvailableLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label10.Location = new System.Drawing.Point(534, 114);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label10.Size = new System.Drawing.Size(64, 33);
            this.label10.TabIndex = 77;
            this.label10.Text = "متاح";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker1.Location = new System.Drawing.Point(68, 153);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 26);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(256, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 27);
            this.label8.TabIndex = 73;
            this.label8.Text = "اجمالى البيع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(833, 487);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 27);
            this.label6.TabIndex = 72;
            this.label6.Text = "عدد الاصناف";
            // 
            // productTotalPriceTxt
            // 
            this.productTotalPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productTotalPriceTxt.Location = new System.Drawing.Point(371, 155);
            this.productTotalPriceTxt.Name = "productTotalPriceTxt";
            this.productTotalPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productTotalPriceTxt.Size = new System.Drawing.Size(96, 26);
            this.productTotalPriceTxt.TabIndex = 71;
            this.productTotalPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productQuantatyTxt
            // 
            this.productQuantatyTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productQuantatyTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productQuantatyTxt.Location = new System.Drawing.Point(472, 156);
            this.productQuantatyTxt.Name = "productQuantatyTxt";
            this.productQuantatyTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productQuantatyTxt.Size = new System.Drawing.Size(58, 26);
            this.productQuantatyTxt.TabIndex = 70;
            this.productQuantatyTxt.Text = "0";
            this.productQuantatyTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productPriceTxt
            // 
            this.productPriceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productPriceTxt.Location = new System.Drawing.Point(601, 156);
            this.productPriceTxt.Name = "productPriceTxt";
            this.productPriceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productPriceTxt.Size = new System.Drawing.Size(113, 26);
            this.productPriceTxt.TabIndex = 69;
            this.productPriceTxt.Text = "0.0";
            this.productPriceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productCodeTxt
            // 
            this.productCodeTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productCodeTxt.Location = new System.Drawing.Point(841, 156);
            this.productCodeTxt.Name = "productCodeTxt";
            this.productCodeTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productCodeTxt.Size = new System.Drawing.Size(103, 26);
            this.productCodeTxt.TabIndex = 68;
            this.productCodeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LightGray;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6});
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(69, 186);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowTemplate.ErrorText = "No data here";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 288);
            this.dataGridView1.StandardTab = true;
            this.dataGridView1.TabIndex = 67;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(371, 115);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 31);
            this.label5.TabIndex = 66;
            this.label5.Text = "الاجمالى";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(601, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 33);
            this.label4.TabIndex = 65;
            this.label4.Text = "البيع";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(472, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 32);
            this.label3.TabIndex = 64;
            this.label3.Text = "الكميه";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(228, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(372, 34);
            this.label2.TabIndex = 63;
            this.label2.Text = "اسم الصنف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productPaidValueTxt
            // 
            this.productPaidValueTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productPaidValueTxt.Location = new System.Drawing.Point(228, 156);
            this.productPaidValueTxt.Name = "productPaidValueTxt";
            this.productPaidValueTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productPaidValueTxt.Size = new System.Drawing.Size(130, 26);
            this.productPaidValueTxt.TabIndex = 87;
            this.productPaidValueTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label11.Location = new System.Drawing.Point(228, 116);
            this.label11.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 31);
            this.label11.TabIndex = 86;
            this.label11.Text = "المقدم المدفوع";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTab
            // 
            this.StartTab.BackColor = System.Drawing.Color.Transparent;
            this.StartTab.Location = new System.Drawing.Point(4, 4);
            this.StartTab.Name = "StartTab";
            this.StartTab.Size = new System.Drawing.Size(1158, 719);
            this.StartTab.TabIndex = 3;
            this.StartTab.Text = "البداية";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column1.HeaderText = "اسم الصنف";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "كود الصنف";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "سعر البيع";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "الكمية";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column4.HeaderText = "سعر الكلى";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.HeaderText = "المقدم المدفوع";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label13.Location = new System.Drawing.Point(114, 487);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 27);
            this.label13.TabIndex = 88;
            this.label13.Text = "اجمالى المقدم";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(452, 648);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(332, 38);
            this.saveBtn.TabIndex = 90;
            this.saveBtn.Text = "حفظ البيانات";
            this.saveBtn.UseVisualStyleBackColor = true;
            // 
            // clientNameCom
            // 
            this.clientNameCom.FormattingEnabled = true;
            this.clientNameCom.Location = new System.Drawing.Point(452, 580);
            this.clientNameCom.MaxDropDownItems = 20;
            this.clientNameCom.Name = "clientNameCom";
            this.clientNameCom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.clientNameCom.Size = new System.Drawing.Size(332, 33);
            this.clientNameCom.TabIndex = 92;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(804, 578);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(144, 34);
            this.label14.TabIndex = 91;
            this.label14.Text = "اسم العميل";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addNewClientBtn
            // 
            this.addNewClientBtn.Location = new System.Drawing.Point(69, 574);
            this.addNewClientBtn.Name = "addNewClientBtn";
            this.addNewClientBtn.Size = new System.Drawing.Size(289, 38);
            this.addNewClientBtn.TabIndex = 93;
            this.addNewClientBtn.Text = "اضافة عميل جديد";
            this.addNewClientBtn.UseVisualStyleBackColor = true;
            this.addNewClientBtn.Click += new System.EventHandler(this.addNewClientBtn_Click);
            // 
            // AddClientTab
            // 
            this.AddClientTab.BackColor = System.Drawing.Color.Transparent;
            this.AddClientTab.Location = new System.Drawing.Point(4, 4);
            this.AddClientTab.Name = "AddClientTab";
            this.AddClientTab.Size = new System.Drawing.Size(1158, 719);
            this.AddClientTab.TabIndex = 4;
            this.AddClientTab.Text = "عميل جديد";
            // 
            // productsCountLab
            // 
            this.productsCountLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productsCountLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.productsCountLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.productsCountLab.Location = new System.Drawing.Point(804, 528);
            this.productsCountLab.Name = "productsCountLab";
            this.productsCountLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productsCountLab.Size = new System.Drawing.Size(140, 26);
            this.productsCountLab.TabIndex = 94;
            this.productsCountLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billTotalPaidLab
            // 
            this.billTotalPaidLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billTotalPaidLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.billTotalPaidLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.billTotalPaidLab.Location = new System.Drawing.Point(69, 528);
            this.billTotalPaidLab.Name = "billTotalPaidLab";
            this.billTotalPaidLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billTotalPaidLab.Size = new System.Drawing.Size(153, 26);
            this.billTotalPaidLab.TabIndex = 95;
            this.billTotalPaidLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // billTotalPriceLab
            // 
            this.billTotalPriceLab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.billTotalPriceLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.billTotalPriceLab.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.billTotalPriceLab.Location = new System.Drawing.Point(228, 528);
            this.billTotalPriceLab.Name = "billTotalPriceLab";
            this.billTotalPriceLab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.billTotalPriceLab.Size = new System.Drawing.Size(130, 26);
            this.billTotalPriceLab.TabIndex = 96;
            this.billTotalPriceLab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 733);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة التحكم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.SalesTab.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SalesTab;
        private System.Windows.Forms.TabPage AddProductsTab;
        private System.Windows.Forms.TabPage PaymentSearchTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox productGroupCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.TextBox productOldPriceLab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label productAvailableLab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox productTotalPriceTxt;
        private System.Windows.Forms.TextBox productQuantatyTxt;
        private System.Windows.Forms.TextBox productPriceTxt;
        private System.Windows.Forms.TextBox productCodeTxt;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox productPaidValueTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox clientNameCom;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button addNewClientBtn;
        private System.Windows.Forms.TabPage AddClientTab;
        private System.Windows.Forms.Label billTotalPriceLab;
        private System.Windows.Forms.Label billTotalPaidLab;
        private System.Windows.Forms.Label productsCountLab;
    }
}