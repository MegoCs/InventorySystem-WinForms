using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_PaymentManager
{
    public partial class GardReport : Form
    {
        public GardReport()
        {
            InitializeComponent();
        }

        private void GardReport_Load(object sender, EventArgs e)
        {
        }

        private void refreshReport_Click(object sender, EventArgs e)
        {
            try{ 
            // TODO: This line of code loads data into the 'GardReportDataSet.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.GardReportDataSet.Products);
            // TODO: This line of code loads data into the 'GardReportDataSet.DataTable2' table. You can move, or remove it, as needed.
            this.DataTable2TableAdapter.Fill(this.GardReportDataSet.DataTable2, date1Picker.Value.ToString("yyyy/MM/dd"), date2Picker.Value.ToString("yyyy/MM/dd"));
            // TODO: This line of code loads data into the 'GardReportDataSet.DataTable3' table. You can move, or remove it, as needed.
            this.DataTable3TableAdapter.Fill(this.GardReportDataSet.DataTable3, date1Picker.Value.ToString("yyyy/MM/dd"), date2Picker.Value.ToString("yyyy/MM/dd"));


            this.reportViewer1.RefreshReport();
        }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ اثناء عرض التقرير");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
                }
}
    }
}
