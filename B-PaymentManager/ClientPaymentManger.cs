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
        int clientIdInt=-1;
        public ClientPaymentManger()
        {
            InitializeComponent();
            conObj = new ConnectionClass();
            FunctionsClass fc = new FunctionsClass();
            clientNameComb.Items.AddRange(FunctionsClass.clientsList.ToArray());
        }

        private void initGrid(int client_id)
        {

            conObj.startConnection();
            try{
                String sql = "delete from TempData";
                conObj.SQLUPDATE(sql, false);

                sql = "SELECT PaymentHistory.client_id AS id, PaymentHistory.bill_id, PaymentHistory.product_id AS bill_product_id, SUM(PaymentHistory.paidValue) AS paymentSum, Products.product_name FROM(PaymentHistory INNER JOIN Products ON PaymentHistory.product_id = Products.ID) WHERE (PaymentHistory.client_id = "+ client_id + ") GROUP BY PaymentHistory.client_id, PaymentHistory.bill_id, PaymentHistory.product_id, Products.product_name";
                conObj.SQLCODE(sql,false);
                while (conObj.myReader.Read())
                {
                    sql = "insert into TempData (product_name,id,bill_id,bill_product_id,paymentSum) values ('" + conObj.myReader["product_name"] + "'," + conObj.myReader["id"]+","+ conObj.myReader["bill_id"] + ","+conObj.myReader["bill_product_id"] +","+ conObj.myReader["paymentSum"] + ")";
                    conObj.SQLUPDATE(sql, false);
                }
                sql = "SELECT BillDetails.bill_id, Clients.client_name, BillDetails.bill_product_id, BillDetails.bill_product_quantaty, BillDetails.bill_product_price, BillDetails.bill_product_paidvalue, BillDetails.bill_product_price* BillDetails.bill_product_quantaty AS TotalPrice, Clients.ID FROM((BillDetails INNER JOIN Bills ON BillDetails.bill_id = Bills.ID) INNER JOIN Clients ON Bills.bill_client_id = Clients.ID) WHERE(Clients.ID =  " + client_id + ")";
                conObj.SQLCODE(sql, false);
                while (conObj.myReader.Read())
                {
                    sql = "update TempData set client_name='"+ conObj.myReader["client_name"] + "',bill_product_price=" + conObj.myReader["bill_product_price"] + " , bill_product_paidValue=" + conObj.myReader["bill_product_paidValue"] + ",bill_product_quantaty=" + conObj.myReader["bill_product_quantaty"] + ",TotalPrice=" + conObj.myReader["TotalPrice"] + " where (ID=" + conObj.myReader["ID"] + " and bill_product_id=" + conObj.myReader["bill_product_id"] + " and bill_id=" + conObj.myReader["bill_id"] + ")";
                    conObj.SQLUPDATE(sql, false);
                }
                    sql = "update TempData set rest=TotalPrice-(paymentSum+bill_product_paidValue)";
                    conObj.SQLUPDATE(sql, false);

                sql = "select * from TempData";
                conObj.SQLCODE(sql, true);
            DataTable dtNotValid = new DataTable();
            conObj.myAdabter.Fill(dtNotValid);
            detailsGrid.DataSource = dtNotValid;
            GridSetNames();
        }
                catch (Exception ex) {
                    MessageBox.Show("خطأ اثناء اضافه البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
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
            clientIdInt = -1;
            if (clientNationalTxt.Text != "")
            {
                try
                {
                    conObj.startConnection();
                    String sql = "select id from clients where client_national_id='" + clientNationalTxt + "'";
                    conObj.SQLCODE(sql, false);
                    if (conObj.myReader.Read())
                    {
                        clientIdInt = conObj.myReader.GetInt32(0);
                        initGrid(clientIdInt);
                    }
                    else
                    {
                        MessageBox.Show("لا توجد بيانات لهذا العميل");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا فى البيانات");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] Line " + 80);
                }
            }
            else
            {
                try
                {
                    if (clientNameComb.SelectedIndex != -1)
                    {
                        clientIdInt = int.Parse((clientNameComb.SelectedItem as ComboBoxItem).value);
                        initGrid(clientIdInt);
                    }
                    else {
                        MessageBox.Show("اسم العميل ليس مسجل");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("اسم العميل ليس مسجل");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] Line " + 99);
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
            try{ 
            if (clientIdInt!=-1)
            {
                int bID = int.Parse(detailsGrid.SelectedRows[0].Cells[7].Value.ToString());
                int bPid= int.Parse(detailsGrid.SelectedRows[0].Cells[8].Value.ToString());
                String cName = detailsGrid.SelectedRows[0].Cells[10].Value.ToString();
                String pName = detailsGrid.SelectedRows[0].Cells[0].Value.ToString();
                NewPayment newqest = new NewPayment(bID, bPid, clientIdInt, cName, pName);
                newqest.ShowDialog();
                    this.Invoke((MethodInvoker)delegate () { initGrid(clientIdInt); });
                }
        }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ ف اختيار البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] Line " + 132);
            }
        }

        private void printedReportBtn_Click(object sender, EventArgs e)
        {
            if (clientIdInt != -1)
            {
                ClientReport0 cR = new ClientReport0(clientIdInt);
                cR.ShowDialog();
            }
            else {
                MessageBox.Show("لم يتم اختيار البيانات");
            }
        }

        private void deleteItemsBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (clientIdInt != -1)
                {
                    int bID = int.Parse(detailsGrid.SelectedRows[0].Cells[7].Value.ToString());
                    int bPid = int.Parse(detailsGrid.SelectedRows[0].Cells[8].Value.ToString());
                    DialogResult dialogResult = MessageBox.Show("تأكيد حذف بيانات الصنف من الفاتورة", "تأكيد", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        String sql = "delete from BillDetails where bill_id="+bID+ " and bill_product_id="+bPid+"";
                        conObj.SQLUPDATE(sql, false);

                        sql = "delete from PaymentHistory where bill_id=" + bID + " and product_id=" + bPid + " and client_id="+ clientIdInt + "";
                        conObj.SQLUPDATE(sql, true);

                        initGrid(clientIdInt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف اختيار البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". ["+this.Name + "] Line "+170);
            }
        }
    }
}
