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
    public partial class ClientReport : Form
    {
        int c_id;
        public ClientReport(int d)
        {
            InitializeComponent();
            c_id = d;
        }

        private void ClientReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClientReportDataSet1.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.ClientReportDataSet1.DataTable1,c_id);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
