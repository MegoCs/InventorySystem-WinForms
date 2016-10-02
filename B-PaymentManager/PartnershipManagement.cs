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
    public partial class PartnershipManagement : Form
    {
        int selectedPartenerID = -1;
        ConnectionClass dbObj;
        public PartnershipManagement()
        {
            InitializeComponent();
            dbObj = new ConnectionClass();
        }

        private void PartnershipManagement_Load(object sender, EventArgs e)
        {
            ReloadDetailsGrrid();
        }

        private void ReloadDetailsGrrid()
        {
            dbObj.startConnection();
            dbObj.SQLCODE("select id,Partner_Description,partner_name as 'اسم العميل',partner_phone as 'رقم التليفون',partner_address,Partner_Value as 'القيمة المالية',Partner_UpdateDate as 'تاريخ البيانات' from PartnershipManagement", true);
            DataTable partenerDetails = new DataTable();
            dbObj.myAdabter.Fill(partenerDetails);
            partnershipDetailsGrid.DataSource = partenerDetails;
            partnershipDetailsGrid.Columns[0].Visible = false;
            partnershipDetailsGrid.Columns[1].Visible = false;
            partnershipDetailsGrid.Columns[4].Visible = false;
            int totalValue = 0;
            foreach (DataGridViewRow item in partnershipDetailsGrid.Rows)
            {
                totalValue += int.Parse(item.Cells[5].Value.ToString());
            }
            totalMoneyTxt.Text = totalValue.ToString();
        }

        private void showDetailsButtn_Click(object sender, EventArgs e)
        {
            if (partnershipDetailsGrid.SelectedRows.Count > 0 && showDetailsButtn.Text.Contains("عرض"))
            {
                date.Text = partnershipDetailsGrid.SelectedRows[0].Cells[6].Value.ToString();
                name.Text = partnershipDetailsGrid.SelectedRows[0].Cells[2].Value.ToString();
                phone.Text = partnershipDetailsGrid.SelectedRows[0].Cells[3].Value.ToString();
                address.Text = partnershipDetailsGrid.SelectedRows[0].Cells[4].Value.ToString();
                description.Text = partnershipDetailsGrid.SelectedRows[0].Cells[1].Value.ToString();
                moneyValue.Text = partnershipDetailsGrid.SelectedRows[0].Cells[5].Value.ToString();
                selectedPartenerID = int.Parse(partnershipDetailsGrid.SelectedRows[0].Cells[0].Value.ToString());
                showDetailsButtn.Text = "اخفاء التفاصيل";
                saveBtn.Text = "حفظ التعديل";
            }
            else
            {
                resetFields();
            }
        }

        private void resetFields()
        {
            name.Text = "";
            phone.Text = "";
            address.Text = "";
            description.Text = "";
            moneyValue.Text = "";
            selectedPartenerID = -1;
            showDetailsButtn.Text = "عرض التفاصيل";
            saveBtn.Text = "حفظ";

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (name.Text != "" && selectedPartenerID == -1)
                {
                    dbObj.SQLUPDATE("insert into PartnershipManagement (Partner_Name,Partner_Phone,Partner_Address,Partner_Description,Partner_Value,Partner_UpdateDate) values('" + name.Text + "','" + phone.Text + "','" + address.Text + "','" + description.Text + "'," + int.Parse(moneyValue.Text) + ",#" + date.Value.ToString("yyyy / MM / dd") + "#)", true);
                    resetFields();
                }
                else
                {
                    dbObj.SQLUPDATE("update PartnershipManagement set Partner_Name='" + name.Text + "',Partner_Phone='" + phone.Text + "',Partner_Address='" + address.Text + "',Partner_Description='" + description.Text + "',Partner_Value=" + int.Parse(moneyValue.Text) + ",Partner_UpdateDate=#" + date.Value.ToString("yyyy / MM / dd") + "# where id=" + selectedPartenerID + "", true);
                    resetFields();
                }
                ReloadDetailsGrrid();
            }
            catch (Exception ex) {
                MessageBox.Show("خطأ اثناء حفظ البيانات");
            }
            }
    }
}
