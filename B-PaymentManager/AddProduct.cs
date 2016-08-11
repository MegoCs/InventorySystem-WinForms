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
    public partial class AddProduct : Form
    {
        ConnectionClass dbConObj;
        public AddProduct()
        {
            InitializeComponent();
            dbConObj = new ConnectionClass();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dbConObj.startConnection();
            //do some insert stuff
            if (productNameTxt_AddProductTab.Text != "" && productQuantatyTxt_AddProductTab.Text != "" && productMinQuantatyTxt_AddProductTab.Text != "" && productSellingPriceTxt_AddProductTab.Text != "")
            {
                if (checkBox1.Checked)
                {
                    dbConObj.SQLUPDATE("insert into Groups (group_name) values('" + newGroupsNameTxt_AddProductTab.Text + "')", false);
                    FunctionsClass fun = new FunctionsClass();
                    int groupId = -1;
                    dbConObj.SQLCODE("select id from Groups where group_name='" + newGroupsNameTxt_AddProductTab.Text + "'", false);
                    while (dbConObj.myReader.Read())
                    {
                        groupId = int.Parse(dbConObj.myReader[0].ToString());   
                    }
                    dbConObj.SQLUPDATE("insert into Products (product_name,product_group_id,product_avail_quant,product_risk_quant,product_price) values ('" + productNameTxt_AddProductTab.Text + "'," + groupId + "," + productQuantatyTxt_AddProductTab.Text + "," + productMinQuantatyTxt_AddProductTab.Text + "," + productSellingPriceTxt_AddProductTab.Text + ")", true);
                }
                else
                {

                    dbConObj.SQLUPDATE("insert into Products (product_name,product_group_id,product_avail_quant,product_risk_quant,product_price) values ('" + productNameTxt_AddProductTab.Text + "'," + (groupsNameComb_AddProductTab.SelectedItem as ComboBoxItem).value + "," + productQuantatyTxt_AddProductTab.Text + "," + productMinQuantatyTxt_AddProductTab.Text + "," + productSellingPriceTxt_AddProductTab.Text + ")", true);
                }
            }
            else {
                MessageBox.Show("برجاء اتمام البيانات");
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            groupsNameComb_AddProductTab.Items.AddRange(FunctionsClass.groupsList.ToArray());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                newGroupsNameTxt_AddProductTab.Visible = checkBox1.Checked;
                groupsNameComb_AddProductTab.Visible = !checkBox1.Checked;

            }
        }

        private void changeProductQuant_Click(object sender, EventArgs e)
        {
            ProductQuantaty proQ = new ProductQuantaty();
            proQ.ShowDialog();
        }
    }
}
