namespace B_PaymentManager
{
    partial class GardReport
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GardReportDataSet = new B_PaymentManager.GardReportDataSet();
            this.DataTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshReport = new System.Windows.Forms.Button();
            this.date2Picker = new System.Windows.Forms.DateTimePicker();
            this.date1Picker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ProductsTableAdapter = new B_PaymentManager.GardReportDataSetTableAdapters.ProductsTableAdapter();
            this.DataTable2TableAdapter = new B_PaymentManager.GardReportDataSetTableAdapters.DataTable2TableAdapter();
            this.DataTable3TableAdapter = new B_PaymentManager.GardReportDataSetTableAdapters.DataTable3TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GardReportDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsBindingSource
            // 
            this.ProductsBindingSource.DataMember = "Products";
            this.ProductsBindingSource.DataSource = this.GardReportDataSet;
            // 
            // GardReportDataSet
            // 
            this.GardReportDataSet.DataSetName = "GardReportDataSet";
            this.GardReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable2BindingSource
            // 
            this.DataTable2BindingSource.DataMember = "DataTable2";
            this.DataTable2BindingSource.DataSource = this.GardReportDataSet;
            // 
            // DataTable3BindingSource
            // 
            this.DataTable3BindingSource.DataMember = "DataTable3";
            this.DataTable3BindingSource.DataSource = this.GardReportDataSet;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.refreshReport);
            this.panel1.Controls.Add(this.date2Picker);
            this.panel1.Controls.Add(this.date1Picker);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 44);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "اختيار فترة لحساب الاقساط ";
            // 
            // refreshReport
            // 
            this.refreshReport.Location = new System.Drawing.Point(14, 10);
            this.refreshReport.Name = "refreshReport";
            this.refreshReport.Size = new System.Drawing.Size(75, 23);
            this.refreshReport.TabIndex = 10;
            this.refreshReport.Text = "عرض";
            this.refreshReport.UseVisualStyleBackColor = true;
            this.refreshReport.Click += new System.EventHandler(this.refreshReport_Click);
            // 
            // date2Picker
            // 
            this.date2Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date2Picker.Location = new System.Drawing.Point(128, 12);
            this.date2Picker.Name = "date2Picker";
            this.date2Picker.Size = new System.Drawing.Size(113, 20);
            this.date2Picker.TabIndex = 8;
            // 
            // date1Picker
            // 
            this.date1Picker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date1Picker.Location = new System.Drawing.Point(321, 14);
            this.date1Picker.Name = "date1Picker";
            this.date1Picker.Size = new System.Drawing.Size(113, 20);
            this.date1Picker.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(450, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "من";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "الي";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.reportViewer1);
            this.panel2.Location = new System.Drawing.Point(12, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(735, 564);
            this.panel2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.ProductsBindingSource;
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.DataTable2BindingSource;
            reportDataSource3.Name = "DataSet3";
            reportDataSource3.Value = this.DataTable3BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "B_PaymentManager.Gard.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(735, 564);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ProductsTableAdapter
            // 
            this.ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable2TableAdapter
            // 
            this.DataTable2TableAdapter.ClearBeforeFill = true;
            // 
            // DataTable3TableAdapter
            // 
            this.DataTable3TableAdapter.ClearBeforeFill = true;
            // 
            // GardReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "GardReport";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقرير الجرد";
            this.Load += new System.EventHandler(this.GardReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GardReportDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable3BindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker date2Picker;
        private System.Windows.Forms.DateTimePicker date1Picker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button refreshReport;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ProductsBindingSource;
        private GardReportDataSet GardReportDataSet;
        private System.Windows.Forms.BindingSource DataTable2BindingSource;
        private System.Windows.Forms.BindingSource DataTable3BindingSource;
        private GardReportDataSetTableAdapters.ProductsTableAdapter ProductsTableAdapter;
        private GardReportDataSetTableAdapters.DataTable2TableAdapter DataTable2TableAdapter;
        private GardReportDataSetTableAdapters.DataTable3TableAdapter DataTable3TableAdapter;
    }
}