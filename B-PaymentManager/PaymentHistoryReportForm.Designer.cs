namespace B_PaymentManager
{
    partial class PaymentHistoryReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource4 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientReportDataSet0 = new B_PaymentManager.ClientReportDataSet0();
            this.ClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsTableAdapter = new B_PaymentManager.ClientReportDataSet0TableAdapters.ClientsTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientPaymentHistoryDataSet = new B_PaymentManager.ClientPaymentHistoryDataSet();
            this.DataTable1TableAdapter = new B_PaymentManager.ClientPaymentHistoryDataSetTableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPaymentHistoryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource3.Name = "PaymentHistoryReportDataSet";
            reportDataSource3.Value = this.DataTable1BindingSource;
            reportDataSource4.Name = "ClientData";
            reportDataSource4.Value = this.ClientsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource4);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "B_PaymentManager.PaymentHistoryReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(715, 608);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            // 
            // ClientReportDataSet0
            // 
            this.ClientReportDataSet0.DataSetName = "ClientReportDataSet0";
            this.ClientReportDataSet0.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ClientsBindingSource
            // 
            this.ClientsBindingSource.DataMember = "Clients";
            this.ClientsBindingSource.DataSource = this.ClientReportDataSet0;
            // 
            // ClientsTableAdapter
            // 
            this.ClientsTableAdapter.ClearBeforeFill = true;
            // 
            // DataTable1BindingSource
            // 
            this.DataTable1BindingSource.DataMember = "DataTable1";
            this.DataTable1BindingSource.DataSource = this.ClientPaymentHistoryDataSet;
            // 
            // ClientPaymentHistoryDataSet
            // 
            this.ClientPaymentHistoryDataSet.DataSetName = "ClientPaymentHistoryDataSet";
            this.ClientPaymentHistoryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // PaymentHistoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 608);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PaymentHistoryReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentHistoryReportForm";
            this.Load += new System.EventHandler(this.PaymentHistoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientPaymentHistoryDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ClientPaymentHistoryDataSet ClientPaymentHistoryDataSet;
        private System.Windows.Forms.BindingSource ClientsBindingSource;
        private ClientReportDataSet0 ClientReportDataSet0;
        private ClientPaymentHistoryDataSetTableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
        private ClientReportDataSet0TableAdapters.ClientsTableAdapter ClientsTableAdapter;
    }
}