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
    public partial class ClientReport0 : Form
    {
        int c_id;
        public ClientReport0(int d)
        {
            InitializeComponent();
            c_id = d;


        }

        private void ClientReport0_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'ClientReportDataSet1.DataTable1' table. You can move, or remove it, as needed.

                // TODO: This line of code loads data into the 'ClientReportDataSet0.Clients' table. You can move, or remove it, as needed.
                this.ClientsTableAdapter.Fill(this.ClientReportDataSet0.Clients,c_id);
                // TODO: This line of code loads data into the 'ClientReportDataSet0.DataTable1' table. You can move, or remove it, as needed.
                this.DataTable1TableAdapter.Fill(this.ClientReportDataSet0.DataTable1,c_id);

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
