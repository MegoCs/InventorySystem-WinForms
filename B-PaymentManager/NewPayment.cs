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
    public partial class NewPayment : Form
    {
        ConnectionClass conObj;
        public NewPayment(int billId,int productId,int clientId,String clientName,String productName)
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            billIDLab.Text = billId.ToString();
            clientNameText.Text = clientName;
            productNameTxt.Text = productName;
            productIDLab.Text = productId.ToString();
            clientIDLab.Text = clientId.ToString();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (qestValueText.Text != "")
            {
                try {
                    conObj.startConnection();
                    String sql = "insert into PaymentHistory (bill_id,product_id,client_id,paidValue,payDate) values (" + billIDLab.Text + "," + productIDLab.Text + "," + clientIDLab.Text + "," + qestValueText.Text + ",#" + datePicker.Value.ToString("yyyy / MM / dd") + "#)";
                    conObj.SQLUPDATE(sql, true);
                    qestValueText.Text = "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ فى ادخال البيانات");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
                }
            }
        }
    }
}
