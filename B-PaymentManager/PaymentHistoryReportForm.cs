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
    public partial class PaymentHistoryReportForm : Form
    {
        int client_id;
        public PaymentHistoryReportForm(int CI)
        {
            InitializeComponent();
            client_id=CI;
        }

        private void PaymentHistoryReportForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ClientPaymentHistoryDataSet.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.ClientPaymentHistoryDataSet.DataTable1, client_id);
            // TODO: This line of code loads data into the 'ClientReportDataSet0.Clients' table. You can move, or remove it, as needed.
            this.ClientsTableAdapter.Fill(this.ClientReportDataSet0.Clients, client_id);

            this.reportViewer1.RefreshReport();
        }
    }
}
