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
    public partial class ProductsShortageReport : Form
    {
        public ProductsShortageReport()
        {
            InitializeComponent();
        }

        private void ProductsShortageReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ProductsShortage.Products' table. You can move, or remove it, as needed.
            this.ProductsTableAdapter.Fill(this.ProductsShortage.Products);

            this.reportViewer1.RefreshReport();
        }
    }
}
