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
            this.SalesTab = new System.Windows.Forms.TabPage();
            this.AddProducts = new System.Windows.Forms.TabPage();
            this.PaymentSearchTab = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.SalesTab);
            this.tabControl1.Controls.Add(this.AddProducts);
            this.tabControl1.Controls.Add(this.PaymentSearchTab);
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(50, 150);
            this.tabControl1.Location = new System.Drawing.Point(2, 7);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1247, 628);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // SalesTab
            // 
            this.SalesTab.AutoScroll = true;
            this.SalesTab.AutoScrollMargin = new System.Drawing.Size(50, 50);
            this.SalesTab.BackColor = System.Drawing.Color.Transparent;
            this.SalesTab.Location = new System.Drawing.Point(4, 4);
            this.SalesTab.Name = "SalesTab";
            this.SalesTab.Padding = new System.Windows.Forms.Padding(3);
            this.SalesTab.Size = new System.Drawing.Size(1089, 620);
            this.SalesTab.TabIndex = 0;
            this.SalesTab.Text = "مبيعات";
            // 
            // AddProducts
            // 
            this.AddProducts.AutoScroll = true;
            this.AddProducts.BackColor = System.Drawing.Color.Transparent;
            this.AddProducts.Location = new System.Drawing.Point(4, 4);
            this.AddProducts.Name = "AddProducts";
            this.AddProducts.Padding = new System.Windows.Forms.Padding(3);
            this.AddProducts.Size = new System.Drawing.Size(1089, 620);
            this.AddProducts.TabIndex = 1;
            this.AddProducts.Text = "اضافة اصناف";
            // 
            // PaymentSearchTab
            // 
            this.PaymentSearchTab.AutoScroll = true;
            this.PaymentSearchTab.BackColor = System.Drawing.Color.Transparent;
            this.PaymentSearchTab.Location = new System.Drawing.Point(4, 4);
            this.PaymentSearchTab.Name = "PaymentSearchTab";
            this.PaymentSearchTab.Size = new System.Drawing.Size(1089, 620);
            this.PaymentSearchTab.TabIndex = 2;
            this.PaymentSearchTab.Text = "بحث الاقساط";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 641);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة التحكم";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage SalesTab;
        private System.Windows.Forms.TabPage AddProducts;
        private System.Windows.Forms.TabPage PaymentSearchTab;
    }
}