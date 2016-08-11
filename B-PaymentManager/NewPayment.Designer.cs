namespace B_PaymentManager
{
    partial class NewPayment
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.qestValueText = new System.Windows.Forms.TextBox();
            this.clientNameText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productNameTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.billIDLab = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.clientIDLab = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productIDLab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(23, 114);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(175, 35);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "حفظ";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "اسم العميل";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(23, 77);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(175, 20);
            this.datePicker.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "قيمة القسط";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "التاريخ";
            // 
            // qestValueText
            // 
            this.qestValueText.Location = new System.Drawing.Point(291, 83);
            this.qestValueText.Name = "qestValueText";
            this.qestValueText.Size = new System.Drawing.Size(169, 20);
            this.qestValueText.TabIndex = 16;
            this.qestValueText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clientNameText
            // 
            this.clientNameText.Enabled = false;
            this.clientNameText.Location = new System.Drawing.Point(291, 42);
            this.clientNameText.Name = "clientNameText";
            this.clientNameText.ReadOnly = true;
            this.clientNameText.Size = new System.Drawing.Size(169, 20);
            this.clientNameText.TabIndex = 15;
            this.clientNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "اسم الصنف";
            // 
            // productNameTxt
            // 
            this.productNameTxt.Enabled = false;
            this.productNameTxt.Location = new System.Drawing.Point(23, 37);
            this.productNameTxt.Name = "productNameTxt";
            this.productNameTxt.ReadOnly = true;
            this.productNameTxt.Size = new System.Drawing.Size(175, 20);
            this.productNameTxt.TabIndex = 20;
            this.productNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "رقم الفاتورة";
            // 
            // billIDLab
            // 
            this.billIDLab.Enabled = false;
            this.billIDLab.Location = new System.Drawing.Point(291, 7);
            this.billIDLab.Name = "billIDLab";
            this.billIDLab.ReadOnly = true;
            this.billIDLab.Size = new System.Drawing.Size(54, 20);
            this.billIDLab.TabIndex = 24;
            this.billIDLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(469, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "كود العميل";
            // 
            // clientIDLab
            // 
            this.clientIDLab.Enabled = false;
            this.clientIDLab.Location = new System.Drawing.Point(419, 7);
            this.clientIDLab.Name = "clientIDLab";
            this.clientIDLab.ReadOnly = true;
            this.clientIDLab.Size = new System.Drawing.Size(41, 20);
            this.clientIDLab.TabIndex = 22;
            this.clientIDLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "كود الصنف";
            // 
            // productIDLab
            // 
            this.productIDLab.Enabled = false;
            this.productIDLab.Location = new System.Drawing.Point(157, 6);
            this.productIDLab.Name = "productIDLab";
            this.productIDLab.ReadOnly = true;
            this.productIDLab.Size = new System.Drawing.Size(41, 20);
            this.productIDLab.TabIndex = 26;
            this.productIDLab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NewPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 163);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productIDLab);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.billIDLab);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.clientIDLab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.productNameTxt);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.qestValueText);
            this.Controls.Add(this.clientNameText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewPayment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox qestValueText;
        private System.Windows.Forms.TextBox clientNameText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox productNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox billIDLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox clientIDLab;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox productIDLab;
    }
}