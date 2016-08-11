namespace B_PaymentManager
{
    partial class ProductQuantaty
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
            this.productGroupCom = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addAvailTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.critcalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.oldAvailLab = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.proIdLab = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productGroupCom
            // 
            this.productGroupCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.productGroupCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productGroupCom.FormattingEnabled = true;
            this.productGroupCom.Location = new System.Drawing.Point(504, 48);
            this.productGroupCom.MaxDropDownItems = 20;
            this.productGroupCom.Name = "productGroupCom";
            this.productGroupCom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productGroupCom.Size = new System.Drawing.Size(332, 26);
            this.productGroupCom.TabIndex = 89;
            this.productGroupCom.SelectedIndexChanged += new System.EventHandler(this.productGroupCom_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(504, 10);
            this.label7.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(332, 34);
            this.label7.TabIndex = 88;
            this.label7.Text = "نوع الصنف";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productNameTxt
            // 
            this.productNameTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.productNameTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.productNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.productNameTxt.Location = new System.Drawing.Point(504, 130);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.productNameTxt.Size = new System.Drawing.Size(332, 26);
            this.productNameTxt.TabIndex = 86;
            this.productNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.productNameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productNameTxt_KeyDown);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(504, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 34);
            this.label2.TabIndex = 87;
            this.label2.Text = "اسم الصنف";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAvailTxt
            // 
            this.addAvailTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addAvailTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.addAvailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.addAvailTxt.Location = new System.Drawing.Point(45, 18);
            this.addAvailTxt.Name = "addAvailTxt";
            this.addAvailTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addAvailTxt.Size = new System.Drawing.Size(111, 26);
            this.addAvailTxt.TabIndex = 90;
            this.addAvailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // priceTxt
            // 
            this.priceTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.priceTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.priceTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.priceTxt.Location = new System.Drawing.Point(45, 50);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.priceTxt.Size = new System.Drawing.Size(111, 26);
            this.priceTxt.TabIndex = 91;
            this.priceTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // critcalTxt
            // 
            this.critcalTxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.critcalTxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.critcalTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.critcalTxt.Location = new System.Drawing.Point(45, 82);
            this.critcalTxt.Name = "critcalTxt";
            this.critcalTxt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.critcalTxt.Size = new System.Drawing.Size(111, 26);
            this.critcalTxt.TabIndex = 92;
            this.critcalTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 93;
            this.label1.Text = "الكمية الحالية";
            // 
            // oldAvailLab
            // 
            this.oldAvailLab.AutoSize = true;
            this.oldAvailLab.Location = new System.Drawing.Point(310, 31);
            this.oldAvailLab.Name = "oldAvailLab";
            this.oldAvailLab.Size = new System.Drawing.Size(22, 13);
            this.oldAvailLab.TabIndex = 94;
            this.oldAvailLab.Text = "0.0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(195, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "اضافة كمية";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 96;
            this.label5.Text = "السعر";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(197, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "الحد الادنى";
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(154, 130);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(178, 26);
            this.saveBtn.TabIndex = 98;
            this.saveBtn.Text = "حفظ";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // proIdLab
            // 
            this.proIdLab.AutoSize = true;
            this.proIdLab.Location = new System.Drawing.Point(310, 61);
            this.proIdLab.Name = "proIdLab";
            this.proIdLab.Size = new System.Drawing.Size(22, 13);
            this.proIdLab.TabIndex = 100;
            this.proIdLab.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(355, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 99;
            this.label8.Text = "كود الصنف";
            // 
            // ProductQuantaty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 172);
            this.Controls.Add(this.proIdLab);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oldAvailLab);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.critcalTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.addAvailTxt);
            this.Controls.Add(this.productGroupCom);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductQuantaty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductQuantaty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productGroupCom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addAvailTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox critcalTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label oldAvailLab;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label proIdLab;
        private System.Windows.Forms.Label label8;
    }
}