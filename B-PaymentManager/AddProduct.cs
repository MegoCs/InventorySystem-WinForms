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
            if (checkBox1.Checked)
            {
                dbConObj.SQLUPDATE("insert into Groups (group_name) values('"+newGroupsNameTxt_AddProductTab.Text+"')", false);
                FunctionsClass fun = new FunctionsClass();
                groupsNameComb_AddProductTab.Items.Clear();
                groupsNameComb_AddProductTab.Items.AddRange(FunctionsClass.groupsList.ToArray());
                groupsNameComb_AddProductTab.SelectedIndex = groupsNameComb_AddProductTab.Items.Count - 1;
            }
                dbConObj.SQLUPDATE("insert into Products (product_name,product_group_id,product_avail_quant,product_risk_quant,product_price) values ('" + productNameTxt_AddProductTab.Text + "'," + (groupsNameComb_AddProductTab.SelectedItem as ComboBoxItem).value+"," + productQuantatyTxt_AddProductTab.Text + ","+productMinQuantatyTxt_AddProductTab.Text+","+productSellingPriceTxt_AddProductTab.Text+")", true);
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
    }
}
