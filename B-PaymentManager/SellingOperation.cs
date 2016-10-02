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
    public partial class SellingOperation : Form
    {
        private AutoCompleteStringCollection productsListAuto;
        ConnectionClass dbConObj;
        List<BillsProducts> productsList;
        public SellingOperation()
        {
            InitializeComponent();
            dbConObj = new ConnectionClass();
            productsList = new List<BillsProducts>();
            FunctionsClass ss = new FunctionsClass();

        }

        private void SellingOperation_Load(object sender, EventArgs e)
        {
            dbConObj.startConnection();
            InitCombos();
        }

        private void InitCombos()
        {
            try
            {
                productGroupCom_SalesTab.Items.Add("كل الاصناف");
                productGroupCom_SalesTab.SelectedIndex = 0;
                productGroupCom_SalesTab.Items.AddRange(FunctionsClass.groupsList.ToArray());
                clientNameCom_SalesTab.Items.AddRange(FunctionsClass.clientsList.ToArray());

                productsListAuto = new AutoCompleteStringCollection();
                dbConObj.SQLCODE("SELECT product_name from Products ", false);

                while (dbConObj.myReader.Read())
                {
                    productsListAuto.Add(dbConObj.myReader["product_name"].ToString());
                }
                productNameTxt_SalesTab.AutoCompleteCustomSource = productsListAuto;
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تجميع البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void productGroupCom_SalesTab_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (productGroupCom_SalesTab.SelectedIndex != 0)
                {
                    productsListAuto = new AutoCompleteStringCollection();
                    dbConObj.SQLCODE("SELECT product_name from Products where product_group_id=" + (productGroupCom_SalesTab.SelectedItem as ComboBoxItem).value + "", false);
                    while (dbConObj.myReader.Read())
                    {
                        productsListAuto.Add(dbConObj.myReader["product_name"].ToString());
                    }
                    productNameTxt_SalesTab.AutoCompleteCustomSource = productsListAuto;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تجميع البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void productNameTxt_SalesTab_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (productNameTxt_SalesTab.Text != "")
                    {
                        dbConObj.SQLCODE("select * from products where product_name='" + productNameTxt_SalesTab.Text + "'", false);
                        while (dbConObj.myReader.Read())
                        {
                            productAvailableLab_SalesTab.Text = dbConObj.myReader["product_avail_quant"].ToString();
                            productCodeTxt_SalesTab.Text = dbConObj.myReader["id"].ToString();
                            productOldPriceLab_SalesTab.Text = dbConObj.myReader["product_price"].ToString();
                            this.ActiveControl = productPaidValueTxt_SalesTab;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ تجميع البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void productPaidValueTxt_SalesTab_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void UpdateDownLabels()
        {
            try
            {
                productsCountLab_SalesTab.Text = productsList.Count.ToString();
                double paidTotal = 0, priceTotal = 0;
                for (int i = 0; i < productsList.Count; i++)
                {
                    paidTotal += productsList[i].productPaidValue;
                    priceTotal += productsList[i].productTotalPrice;
                }
                billTotalPaidLab_SalesTab.Text = paidTotal.ToString();
                billTotalPriceLab_SalesTab.Text = priceTotal.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void ClearLabs()
        {
            try
            {
                billTotalPaidLab_SalesTab.Text = "0,0";
                billTotalPriceLab_SalesTab.Text = "0,0";
                productsCountLab_SalesTab.Text = "0";
                sellingDataGrid_SalesTab.Rows.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void ClearTextFileds()
        {
            productNameTxt_SalesTab.Text = "";
            productCodeTxt_SalesTab.Text = "0";
            productOldPriceLab_SalesTab.Text = "0";
            productPriceTxt_SalesTab.Text = "0";
            productAvailableLab_SalesTab.Text = "0";
            productQuantatyTxt_SalesTab.Text = "0";
            productTotalPriceTxt_SalesTab.Text = "0";
            productPaidValueTxt_SalesTab.Text = "0";
            this.ActiveControl = productNameTxt_SalesTab;
        }

        private void sellingDataGrid_SalesTab_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                productsList.RemoveAt(e.Row.Index);
                UpdateDownLabels();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void addNewClientBtn_SalesTab_Click(object sender, EventArgs e)
        {
            try
            {
                AddClient addClient = new AddClient();
                addClient.ShowDialog();
                if (addClient.clientName != "" && addClient.clientName != null)
                {
                    clientNameCom_SalesTab.Items.Add(addClient.clientName);
                    clientNameCom_SalesTab.SelectedItem = addClient.clientName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void saveBtn_SalesTab_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = -1, billID = -1;
                String sql = "select id from clients where client_name='" + clientNameCom_SalesTab.SelectedItem.ToString() + "'";
                dbConObj.SQLCODE(sql, false);
                if (dbConObj.myReader.Read())
                {
                    clientID = dbConObj.myReader.GetInt32(0);

                    sql = "insert into bills (bill_date,bill_client_id) values(#" + dateTimePicker1_SalesTab.Value.ToString("yyyy / MM / dd") + "#," + clientID + ")";
                    dbConObj.SQLUPDATE(sql, true);
                    sql = "select max(id) from bills where bill_client_id=" + clientID + "";
                    dbConObj.SQLCODE(sql, false);
                    if (dbConObj.myReader.Read())
                    {
                        billID = dbConObj.myReader.GetInt32(0);

                        for (int i = 0; i < productsList.Count; i++)
                        {
                            sql = @"insert into billDetails (bill_id,bill_product_id,bill_product_quantaty,bill_product_price,bill_product_paidvalue)
                            values (" + billID + "," + productsList[i].productId + "," + productsList[i].productQuant + "," + productsList[i].productPrice + "," + productsList[i].productPaidValue + ")";
                            dbConObj.SQLUPDATE(sql, false);
                        }
                        for (int i = 0; i < productsList.Count; i++)
                        {
                            sql = @"update products set product_avail_quant=product_avail_quant-" + productsList[i].productQuant + " where ID=" + productsList[i].productId + "";
                            dbConObj.SQLUPDATE(sql, false);
                        }
                        for (int i = 0; i < productsList.Count; i++)
                        {
                            sql = "insert into PaymentHistory (bill_id,product_id,client_id,paidValue,payDate) values (" + billID + "," + productsList[i].productId + "," + clientID + ",0,#" + dateTimePicker1_SalesTab.Value.ToString("yyyy / MM / dd") + "#)";
                            dbConObj.SQLUPDATE(sql, i + 1 > productsList.Count);
                        }
                    }
                }
                ClearTextFileds();
                ClearLabs();
                productsList.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] Line " + 257);
            }

        }

        private void productQuantatyTxt_SalesTab_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int q = int.Parse(productQuantatyTxt_SalesTab.Text);
                    int a = int.Parse(productAvailableLab_SalesTab.Text);
                    if (q > a)
                    {
                        this.ActiveControl = productQuantatyTxt_SalesTab;
                        MessageBox.Show("كمية اكبر من المتاح برجاء الانتباه");
                        return;
                    }
                    int p = int.Parse(productPriceTxt_SalesTab.Text)+int.Parse(productOldPriceLab_SalesTab.Text);
                    productTotalPriceTxt_SalesTab.Text = (p * q).ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ");
                    Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ". [" + this.Name + "] Line " + 281);
                }
            }
        }

        private void productTotalPriceTxt_SalesTab_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    productsList.Add(new BillsProducts(productNameTxt_SalesTab.Text, int.Parse(productPriceTxt_SalesTab.Text)+int.Parse(productOldPriceLab_SalesTab.Text), int.Parse(productQuantatyTxt_SalesTab.Text), int.Parse(productTotalPriceTxt_SalesTab.Text), int.Parse(productPaidValueTxt_SalesTab.Text), int.Parse(productCodeTxt_SalesTab.Text)));
                    sellingDataGrid_SalesTab.Rows.Add(productNameTxt_SalesTab.Text, productCodeTxt_SalesTab.Text, (int.Parse(productPriceTxt_SalesTab.Text) + int.Parse(productOldPriceLab_SalesTab.Text)).ToString(), productQuantatyTxt_SalesTab.Text, productTotalPriceTxt_SalesTab.Text, productPaidValueTxt_SalesTab.Text);
                    ClearTextFileds();
                    UpdateDownLabels();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ فى البيانات");
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }
    }
}