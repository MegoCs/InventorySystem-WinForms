namespace B_PaymentManager
{
    partial class ConfigForm
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
            this.restorDataBackUpBtn = new System.Windows.Forms.Button();
            this.saveBackUpBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.clearDbFileBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // restorDataBackUpBtn
            // 
            this.restorDataBackUpBtn.Location = new System.Drawing.Point(439, 37);
            this.restorDataBackUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.restorDataBackUpBtn.Name = "restorDataBackUpBtn";
            this.restorDataBackUpBtn.Size = new System.Drawing.Size(100, 38);
            this.restorDataBackUpBtn.TabIndex = 1;
            this.restorDataBackUpBtn.Text = "بحث";
            this.restorDataBackUpBtn.UseVisualStyleBackColor = true;
            this.restorDataBackUpBtn.Click += new System.EventHandler(this.restorDataBackUpBtn_Click);
            // 
            // saveBackUpBtn
            // 
            this.saveBackUpBtn.Location = new System.Drawing.Point(439, 47);
            this.saveBackUpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.saveBackUpBtn.Name = "saveBackUpBtn";
            this.saveBackUpBtn.Size = new System.Drawing.Size(100, 37);
            this.saveBackUpBtn.TabIndex = 0;
            this.saveBackUpBtn.Text = "بحث";
            this.saveBackUpBtn.UseVisualStyleBackColor = true;
            this.saveBackUpBtn.Click += new System.EventHandler(this.saveBackUpBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(32, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 37);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(32, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(383, 36);
            this.textBox2.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.restorDataBackUpBtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(16, 126);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(547, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "استرجاع العمل بنسخة قديمة من البيانات";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(212, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "استرجاع البيانات";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.saveBackUpBtn);
            this.groupBox2.Location = new System.Drawing.Point(16, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(547, 103);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "حفظ نسخة احتياطية من البيانات";
            // 
            // clearDbFileBtn
            // 
            this.clearDbFileBtn.Location = new System.Drawing.Point(16, 225);
            this.clearDbFileBtn.Margin = new System.Windows.Forms.Padding(4);
            this.clearDbFileBtn.Name = "clearDbFileBtn";
            this.clearDbFileBtn.Size = new System.Drawing.Size(547, 53);
            this.clearDbFileBtn.TabIndex = 6;
            this.clearDbFileBtn.Text = "بدأ فترة مالية جديده";
            this.clearDbFileBtn.UseVisualStyleBackColor = true;
            this.clearDbFileBtn.Click += new System.EventHandler(this.clearDbFileBtn_Click);
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 290);
            this.Controls.Add(this.clearDbFileBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfigForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات البيانات";
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button restorDataBackUpBtn;
        private System.Windows.Forms.Button saveBackUpBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button clearDbFileBtn;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
        private System.Windows.Forms.Label label5;
    }
}