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
    public partial class ProductQuantaty : Form
    {
        private ConnectionClass dbConObj;
        private AutoCompleteStringCollection productsListAuto;

        public ProductQuantaty()
        {
            InitializeComponent();
            dbConObj = new ConnectionClass();
            init();
        }
        private void init() {
            dbConObj.startConnection();
            productGroupCom.Items.Add("كل الاصناف");
            productGroupCom.SelectedIndex = 0;
            productGroupCom.Items.AddRange(FunctionsClass.groupsList.ToArray());

            productsListAuto = new AutoCompleteStringCollection();
            dbConObj.SQLCODE("SELECT product_name from Products ", false);
            try
            {
                while (dbConObj.myReader.Read())
                {
                    productsListAuto.Add(dbConObj.myReader["product_name"].ToString());
                }
                productNameTxt.AutoCompleteCustomSource = productsListAuto;
            }
            catch (Exception ex)
            {

            }
        }
        private void productGroupCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productGroupCom.SelectedIndex != 0)
            {
                productsListAuto = new AutoCompleteStringCollection();
                dbConObj.SQLCODE("SELECT product_name from Products where product_group_id=" + (productGroupCom.SelectedItem as ComboBoxItem).value + "", false);
                try
                {
                    while (dbConObj.myReader.Read())
                    {
                        productsListAuto.Add(dbConObj.myReader["product_name"].ToString());
                    }
                    productNameTxt.AutoCompleteCustomSource = productsListAuto;
                }
                catch (Exception ex)
                {

                }
            }
        }
        private void productNameTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (productNameTxt.Text != "")
                {
                    dbConObj.SQLCODE("select * from products where product_name='" + productNameTxt.Text + "'", false);
                    while (dbConObj.myReader.Read())
                    {
                        oldAvailLab.Text=dbConObj.myReader["product_avail_quant"].ToString();
                        proIdLab.Text=dbConObj.myReader["id"].ToString();
                        priceTxt.Text=dbConObj.myReader["product_price"].ToString();
                        critcalTxt.Text= dbConObj.myReader["product_risk_quant"].ToString();
                    }
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dbConObj.SQLUPDATE("update Products set product_avail_quant=product_avail_quant+"+int.Parse(addAvailTxt.Text)+ ",product_risk_quant="+critcalTxt.Text+ ",product_price="+priceTxt.Text+"", true);
            clearFields();
        }

        private void clearFields()
        {
            productNameTxt.Text = "";
            oldAvailLab.Text = "0";
            addAvailTxt.Text = "0";
            priceTxt.Text = "0";
            critcalTxt.Text = "0";
            proIdLab.Text = "0";
        }
    }
}
