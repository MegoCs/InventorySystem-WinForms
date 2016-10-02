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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.StartTab = new System.Windows.Forms.TabPage();
            this.SalesTab = new System.Windows.Forms.TabPage();
            this.AddProductsTab = new System.Windows.Forms.TabPage();
            this.PaymentTab = new System.Windows.Forms.TabPage();
            this.AddClientTab = new System.Windows.Forms.TabPage();
            this.ProductShortageReportTab = new System.Windows.Forms.TabPage();
            this.GardTab = new System.Windows.Forms.TabPage();
            this.DataSettings = new System.Windows.Forms.TabPage();
            this.PartnerShipSettings = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.PaymentTab);
            this.tabControl1.Controls.Add(this.AddClientTab);
            this.tabControl1.Controls.Add(this.ProductShortageReportTab);
            this.tabControl1.Controls.Add(this.GardTab);
            this.tabControl1.Controls.Add(this.PartnerShipSettings);
            this.tabControl1.Controls.Add(this.DataSettings);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 150);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1033, 492);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // StartTab
            // 
            this.StartTab.BackColor = System.Drawing.Color.Transparent;
            this.StartTab.Location = new System.Drawing.Point(4, 4);
            this.StartTab.Name = "StartTab";
            this.StartTab.Size = new System.Drawing.Size(875, 484);
            this.StartTab.TabIndex = 3;
            this.StartTab.Text = "البداية";
            // 
            // SalesTab
            // 
            this.SalesTab.AutoScroll = true;
            this.SalesTab.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.SalesTab.BackColor = System.Drawing.Color.Transparent;
            this.SalesTab.Location = new System.Drawing.Point(4, 4);
            this.SalesTab.Name = "SalesTab";
            this.SalesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalesTab.Size = new System.Drawing.Size(875, 484);
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
            this.AddProductsTab.Size = new System.Drawing.Size(875, 484);
            this.AddProductsTab.TabIndex = 1;
            this.AddProductsTab.Text = "اضافة اصناف";
            // 
            // PaymentTab
            // 
            this.PaymentTab.AutoScroll = true;
            this.PaymentTab.BackColor = System.Drawing.Color.Transparent;
            this.PaymentTab.Location = new System.Drawing.Point(4, 4);
            this.PaymentTab.Name = "PaymentTab";
            this.PaymentTab.Size = new System.Drawing.Size(875, 484);
            this.PaymentTab.TabIndex = 2;
            this.PaymentTab.Text = "دفع و متابعة الاقساط";
            // 
            // AddClientTab
            // 
            this.AddClientTab.BackColor = System.Drawing.Color.Transparent;
            this.AddClientTab.Location = new System.Drawing.Point(4, 4);
            this.AddClientTab.Name = "AddClientTab";
            this.AddClientTab.Size = new System.Drawing.Size(875, 484);
            this.AddClientTab.TabIndex = 4;
            this.AddClientTab.Text = "عميل جديد";
            // 
            // ProductShortageReportTab
            // 
            this.ProductShortageReportTab.BackColor = System.Drawing.Color.Transparent;
            this.ProductShortageReportTab.Location = new System.Drawing.Point(4, 4);
            this.ProductShortageReportTab.Name = "ProductShortageReportTab";
            this.ProductShortageReportTab.Size = new System.Drawing.Size(875, 484);
            this.ProductShortageReportTab.TabIndex = 5;
            this.ProductShortageReportTab.Text = "تقرير النواقص";
            // 
            // GardTab
            // 
            this.GardTab.BackColor = System.Drawing.Color.Transparent;
            this.GardTab.Location = new System.Drawing.Point(4, 4);
            this.GardTab.Name = "GardTab";
            this.GardTab.Size = new System.Drawing.Size(875, 484);
            this.GardTab.TabIndex = 7;
            this.GardTab.Text = "تقارير الجرد";
            // 
            // DataSettings
            // 
            this.DataSettings.BackColor = System.Drawing.Color.Transparent;
            this.DataSettings.Location = new System.Drawing.Point(4, 4);
            this.DataSettings.Name = "DataSettings";
            this.DataSettings.Size = new System.Drawing.Size(875, 484);
            this.DataSettings.TabIndex = 8;
            this.DataSettings.Text = "اعدادات البيانات";
            // 
            // PartnerShipSettings
            // 
            this.PartnerShipSettings.BackColor = System.Drawing.Color.Transparent;
            this.PartnerShipSettings.Location = new System.Drawing.Point(4, 4);
            this.PartnerShipSettings.Name = "PartnerShipSettings";
            this.PartnerShipSettings.Size = new System.Drawing.Size(875, 484);
            this.PartnerShipSettings.TabIndex = 9;
            this.PartnerShipSettings.Text = "بيانات الشراكه";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 498);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة التحكم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SalesTab;
        private System.Windows.Forms.TabPage AddProductsTab;
        private System.Windows.Forms.TabPage PaymentTab;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.TabPage AddClientTab;
        private System.Windows.Forms.TabPage ProductShortageReportTab;
        private System.Windows.Forms.TabPage GardTab;
        private System.Windows.Forms.TabPage PartnerShipSettings;
        private System.Windows.Forms.TabPage DataSettings;
    }
}