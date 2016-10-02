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
            loadOldGroups();
        }

        private void loadOldGroups()
        {
            groupsNameComb_AddProductTab.Items.Clear();
            groupsNameComb_AddProductTab.Items.AddRange(FunctionsClass.groupsList.ToArray());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            dbConObj.startConnection();
            try
            {
                //do some insert stuff
                if (productNameTxt_AddProductTab.Text != "" && productQuantatyTxt_AddProductTab.Text != "" && productMinQuantatyTxt_AddProductTab.Text != "" && productSellingPriceTxt_AddProductTab.Text != "")
                {
                    if (checkBox1.Checked)
                    {
                        if (!FunctionsClass.groupsList.Any(x => x.Text == newGroupsNameTxt_AddProductTab.Text))
                        {
                            dbConObj.SQLUPDATE("insert into Groups (group_name) values('" + newGroupsNameTxt_AddProductTab.Text + "')", false);
                        }
                        int groupId = -1;
                        dbConObj.SQLCODE("select id from Groups where group_name='" + newGroupsNameTxt_AddProductTab.Text + "'", false);
                        while (dbConObj.myReader.Read())
                        {
                            groupId = int.Parse(dbConObj.myReader[0].ToString());
                            FunctionsClass.groupsList.Add(new ComboBoxItem()
                            {
                                Text = newGroupsNameTxt_AddProductTab.Text,
                                value = groupId.ToString()
                            });
                            loadOldGroups();
                        }
                        dbConObj.SQLUPDATE("insert into Products (product_name,product_group_id,product_avail_quant,product_risk_quant,product_price) values ('" + productNameTxt_AddProductTab.Text + "'," + groupId + "," + productQuantatyTxt_AddProductTab.Text + "," + productMinQuantatyTxt_AddProductTab.Text + "," + productSellingPriceTxt_AddProductTab.Text + ")", true);
                    }
                    else
                    {

                        dbConObj.SQLUPDATE("insert into Products (product_name,product_group_id,product_avail_quant,product_risk_quant,product_price) values ('" + productNameTxt_AddProductTab.Text + "'," + (groupsNameComb_AddProductTab.SelectedItem as ComboBoxItem).value + "," + productQuantatyTxt_AddProductTab.Text + "," + productMinQuantatyTxt_AddProductTab.Text + "," + productSellingPriceTxt_AddProductTab.Text + ")", true);
                    }
                    productNameTxt_AddProductTab.Text = "";
                    productQuantatyTxt_AddProductTab.Text = "";
                    productMinQuantatyTxt_AddProductTab.Text = "";
                    productSellingPriceTxt_AddProductTab.Text = "";
                    checkBox1.Checked = false;
                    checkBox1_CheckedChanged(null, null);
                }
                else
                {
                    MessageBox.Show("برجاء اتمام البيانات");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء اضافه البيانات", ex.Message);
                Logger.WriteLog("[" + DateTime.Now + "] " + ex.Message + ".");
            }
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            loadOldGroups();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            newGroupsNameTxt_AddProductTab.Visible = checkBox1.Checked;
            groupsNameComb_AddProductTab.Visible = !checkBox1.Checked;
        }

        private void changeProductQuant_Click(object sender, EventArgs e)
        {
            ProductQuantaty proQ = new ProductQuantaty();
            proQ.ShowDialog();
        }
    }
}
