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
    public partial class ClientPaymentManger : Form
    {
        ConnectionClass conObj;
        int clintID=-1;
        public ClientPaymentManger()
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            FunctionsClass fc = new FunctionsClass();
            clientNameComb.Items.AddRange(FunctionsClass.clientsList.ToArray());
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void initGrid(int client_id)
        {
            conObj.startConnection();
            String sql = "SELECT  Products.product_name , BillDetails.bill_product_price, BillDetails.bill_product_quantaty,BillDetails.bill_product_quantaty * BillDetails.bill_product_price AS TotalPrice , BillDetails.bill_product_paidvalue,SUM(PaymentHistory.paidValue) AS paymentSum,TotalPrice-(paymentSum+BillDetails.bill_product_paidvalue) as rest,BillDetails.bill_id,BillDetails.bill_product_id,Clients.ID,Clients.client_name FROM (((PaymentHistory INNER JOIN Products ON PaymentHistory.product_id = Products.ID) INNER JOIN Clients ON PaymentHistory.client_id = Clients.ID) INNER JOIN BillDetails ON Products.ID = BillDetails.bill_product_id) WHERE (PaymentHistory.client_id = " + client_id+ ") GROUP BY PaymentHistory.bill_id, PaymentHistory.product_id, Products.product_name, Clients.client_name, BillDetails.bill_product_price, BillDetails.bill_product_quantaty, BillDetails.bill_product_paidvalue,BillDetails.bill_product_id, BillDetails.bill_id, Clients.ID";
            conObj.SQLCODE(sql, true);
            DataTable dtNotValid = new DataTable();
            conObj.myAdabter.Fill(dtNotValid);
            detailsGrid.DataSource = dtNotValid;
            GridSetNames();
        }

        private void GridSetNames()
        {
            detailsGrid.Columns[0].HeaderText = "اسم الصنف";
            detailsGrid.Columns[1].HeaderText = "السعر";
            detailsGrid.Columns[2].HeaderText = "الكمية";
            detailsGrid.Columns[3].HeaderText = "السعرالكلى";
            detailsGrid.Columns[4].HeaderText = "المقدم";
            detailsGrid.Columns[5].HeaderText = "مجموع الاقساط";
            detailsGrid.Columns[6].HeaderText = "المتبقى";
            detailsGrid.Columns[7].HeaderText = "رقم الفاتورة";
            detailsGrid.Columns[8].Visible = false;
            detailsGrid.Columns[9].Visible = false;
            detailsGrid.Columns[10].Visible = false;
            detailsGrid.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            clintID = -1;
            if (clientNationalTxt.Text != "")
            {
                try
                {
                    conObj.startConnection();
                    String sql = "select id from clients where client_national_id='" + clientNationalTxt + "'";
                    conObj.SQLCODE(sql, false);
                    if (conObj.myReader.Read())
                    {
                        clintID = conObj.myReader.GetInt32(0);
                        initGrid(clintID);
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات لهذا العميل");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا فى البيانات");
                }
            }
            else
            {
                try
                {
                    if (clientNameComb.SelectedIndex != -1)
                    {
                        clintID = int.Parse((clientNameComb.SelectedItem as ComboBoxItem).value);
                        initGrid(clintID);
                    }
                    else {
                        MessageBox.Show("اسم العميل ليس مسجل");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("اسم العميل ليس مسجل");
                }
             }

        }

        private void clientNationalTxt_MouseClick(object sender, MouseEventArgs e)
        {
            clientNameComb.SelectedText = "";
        }

        private void clientNameComb_MouseClick(object sender, MouseEventArgs e)
        {
            clientNationalTxt.Text = "";
        }

        private void newPayment_Click(object sender, EventArgs e)
        {
            if (clintID!=-1)
            {
                int bID = int.Parse(detailsGrid.SelectedRows[0].Cells[7].Value.ToString());
                int bPid= int.Parse(detailsGrid.SelectedRows[0].Cells[8].Value.ToString());
                String cName = detailsGrid.SelectedRows[0].Cells[10].Value.ToString();
                String pName = detailsGrid.SelectedRows[0].Cells[0].Value.ToString();
                NewPayment newqest = new NewPayment(bID, bPid, clintID, cName, pName);
                newqest.ShowDialog();
                initGrid(clintID);
            }
        }

        private void printedReportBtn_Click(object sender, EventArgs e)
        {
            ClientReport cR = new ClientReport(clintID);
            cR.ShowDialog();
        }
    }
}
