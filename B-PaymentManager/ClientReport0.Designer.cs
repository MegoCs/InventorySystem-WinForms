namespace B_PaymentManager
{
    partial class ClientReport0
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource8 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ClientReportDataSet0 = new B_PaymentManager.ClientReportDataSet0();
            this.ClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClientsTableAdapter = new B_PaymentManager.ClientReportDataSet0TableAdapters.ClientsTableAdapter();
            this.DataTable1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataTable1TableAdapter = new B_PaymentManager.ClientReportDataSet0TableAdapters.DataTable1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportDataSet0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.ClientsBindingSource;
            reportDataSource8.Name = "DataSet2";
            reportDataSource8.Value = this.DataTable1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource8);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "B_PaymentManager.ClientMainReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(743, 573);
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
            this.DataTable1BindingSource.DataSource = this.ClientReportDataSet0;
            // 
            // DataTable1TableAdapter
            // 
            this.DataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // ClientReport0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 573);
            this.Controls.Add(this.reportViewer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ClientReport0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحة تقرير العميل";
            this.Load += new System.EventHandler(this.ClientReport0_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientReportDataSet0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource ClientsBindingSource;
        private ClientReportDataSet0 ClientReportDataSet0;
        private System.Windows.Forms.BindingSource DataTable1BindingSource;
        private ClientReportDataSet0TableAdapters.ClientsTableAdapter ClientsTableAdapter;
        private ClientReportDataSet0TableAdapters.DataTable1TableAdapter DataTable1TableAdapter;
    }
}