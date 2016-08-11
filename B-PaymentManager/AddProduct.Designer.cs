namespace B_PaymentManager
{
    partial class AddProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.changeProductQuant = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupsNameComb_AddProductTab = new System.Windows.Forms.ComboBox();
            this.newGroupsNameTxt_AddProductTab = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.productNameTxt_AddProductTab = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.productMinQuantatyTxt_AddProductTab = new System.Windows.Forms.TextBox();
            this.productQuantatyTxt_AddProductTab = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.productSellingPriceTxt_AddProductTab = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.changeProductQuant);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.saveBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(720, 253);
            this.panel1.TabIndex = 1;
            // 
            // changeProductQuant
            // 
            this.changeProductQuant.Location = new System.Drawing.Point(131, 207);
            this.changeProductQuant.Name = "changeProductQuant";
            this.changeProductQuant.Size = new System.Drawing.Size(194, 33);
            this.changeProductQuant.TabIndex = 34;
            this.changeProductQuant.Text = "اضافة كمية لصنف حالى";
            this.changeProductQuant.UseVisualStyleBackColor = true;
            this.changeProductQuant.Click += new System.EventHandler(this.changeProductQuant_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupsNameComb_AddProductTab);
            this.groupBox3.Controls.Add(this.newGroupsNameTxt_AddProductTab);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.productNameTxt_AddProductTab);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.Location = new System.Drawing.Point(340, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox3.Size = new System.Drawing.Size(360, 190);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "تفاصيل المنتج";
            // 
            // groupsNameComb_AddProductTab
            // 
            this.groupsNameComb_AddProductTab.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.groupsNameComb_AddProductTab.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupsNameComb_AddProductTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupsNameComb_AddProductTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupsNameComb_AddProductTab.FormattingEnabled = true;
            this.groupsNameComb_AddProductTab.Location = new System.Drawing.Point(25, 76);
            this.groupsNameComb_AddProductTab.Name = "groupsNameComb_AddProductTab";
            this.groupsNameComb_AddProductTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupsNameComb_AddProductTab.Size = new System.Drawing.Size(199, 24);
            this.groupsNameComb_AddProductTab.TabIndex = 3;
            // 
            // newGroupsNameTxt_AddProductTab
            // 
            this.newGroupsNameTxt_AddProductTab.ForeColor = System.Drawing.Color.Black;
            this.newGroupsNameTxt_AddProductTab.Location = new System.Drawing.Point(25, 138);
            this.newGroupsNameTxt_AddProductTab.Name = "newGroupsNameTxt_AddProductTab";
            this.newGroupsNameTxt_AddProductTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.newGroupsNameTxt_AddProductTab.Size = new System.Drawing.Size(199, 22);
            this.newGroupsNameTxt_AddProductTab.TabIndex = 5;
            this.newGroupsNameTxt_AddProductTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.newGroupsNameTxt_AddProductTab.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(255, 75);
            this.label18.Name = "label18";
            this.label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label18.Size = new System.Drawing.Size(52, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "المجموعه";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(207, 111);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(96, 20);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "مجموعة جديده";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // productNameTxt_AddProductTab
            // 
            this.productNameTxt_AddProductTab.Location = new System.Drawing.Point(25, 28);
            this.productNameTxt_AddProductTab.Name = "productNameTxt_AddProductTab";
            this.productNameTxt_AddProductTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productNameTxt_AddProductTab.Size = new System.Drawing.Size(199, 22);
            this.productNameTxt_AddProductTab.TabIndex = 1;
            this.productNameTxt_AddProductTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(248, 35);
            this.label20.Name = "label20";
            this.label20.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label20.Size = new System.Drawing.Size(58, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "إسم المنتج";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.productMinQuantatyTxt_AddProductTab);
            this.groupBox1.Controls.Add(this.productQuantatyTxt_AddProductTab);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.productSellingPriceTxt_AddProductTab);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(314, 190);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "السعر والكميه";
            // 
            // productMinQuantatyTxt_AddProductTab
            // 
            this.productMinQuantatyTxt_AddProductTab.Location = new System.Drawing.Point(52, 69);
            this.productMinQuantatyTxt_AddProductTab.Name = "productMinQuantatyTxt_AddProductTab";
            this.productMinQuantatyTxt_AddProductTab.Size = new System.Drawing.Size(124, 22);
            this.productMinQuantatyTxt_AddProductTab.TabIndex = 6;
            this.productMinQuantatyTxt_AddProductTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productQuantatyTxt_AddProductTab
            // 
            this.productQuantatyTxt_AddProductTab.Location = new System.Drawing.Point(52, 32);
            this.productQuantatyTxt_AddProductTab.Name = "productQuantatyTxt_AddProductTab";
            this.productQuantatyTxt_AddProductTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productQuantatyTxt_AddProductTab.Size = new System.Drawing.Size(124, 22);
            this.productQuantatyTxt_AddProductTab.TabIndex = 5;
            this.productQuantatyTxt_AddProductTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(200, 75);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(59, 16);
            this.label21.TabIndex = 9;
            this.label21.Text = "الحد الادنى";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(222, 35);
            this.label22.Name = "label22";
            this.label22.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label22.Size = new System.Drawing.Size(37, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "الكميه";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(208, 112);
            this.label24.Name = "label24";
            this.label24.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label24.Size = new System.Drawing.Size(54, 16);
            this.label24.TabIndex = 6;
            this.label24.Text = "سعر البيع";
            // 
            // productSellingPriceTxt_AddProductTab
            // 
            this.productSellingPriceTxt_AddProductTab.Location = new System.Drawing.Point(52, 109);
            this.productSellingPriceTxt_AddProductTab.Name = "productSellingPriceTxt_AddProductTab";
            this.productSellingPriceTxt_AddProductTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productSellingPriceTxt_AddProductTab.Size = new System.Drawing.Size(124, 22);
            this.productSellingPriceTxt_AddProductTab.TabIndex = 7;
            this.productSellingPriceTxt_AddProductTab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(365, 207);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.saveBtn.Size = new System.Drawing.Size(199, 38);
            this.saveBtn.TabIndex = 30;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 253);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة صنف";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox groupsNameComb_AddProductTab;
        private System.Windows.Forms.TextBox newGroupsNameTxt_AddProductTab;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox productNameTxt_AddProductTab;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox productMinQuantatyTxt_AddProductTab;
        private System.Windows.Forms.TextBox productQuantatyTxt_AddProductTab;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox productSellingPriceTxt_AddProductTab;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button changeProductQuant;
    }
}