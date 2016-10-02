using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace B_PaymentManager
{
    public partial class ConfigForm : Form
    {
        String DataFolderPath;

        public ConfigForm()
        {
            InitializeComponent();
        }

        private void ConfigForm_Load(object sender, EventArgs e)
        {
            LoadPathes();
        }

        private void SaveBackUpData()
        {
            try
            {
                SaveFileDialog SaveFD1 = new SaveFileDialog();
                string FileName = "";
                SaveFD1.FileName = "نسخة بيانات بتاريخ" + DateTime.Now.ToString("dd-mm-yyyy") + ".accdb";
                SaveFD1.Title = "Backup";
                SaveFD1.DefaultExt = "accdb";
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;
                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {
                    FileName = SaveFD1.FileName;
                    System.IO.File.Copy(DataFolderPath + @"\BasemUncle.accdb", FileName, true);
                    MessageBox.Show("تم عمل النسخة !", "نسخة احتياطية", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox2.Text = FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشكله فى الاعدادات");
            }
        }

        private void LoadPathes()
        {
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string dst = (System.IO.Path.GetDirectoryName(executable));
            DataFolderPath = dst + @"\Data";
        }

        private void RestoreDataBackUp()
        {
            try
            {
                OpenFileDialog SaveFD12 = new OpenFileDialog();
                SaveFD12.InitialDirectory = "C:";
                SaveFD12.FileName = "";
                SaveFD12.Title = "Choose Backup file to Restore ";
                SaveFD12.DefaultExt = "accdb";
                SaveFD12.Filter = "Ms-Access Files (*.accdb)|*.accdb";
                SaveFD12.FilterIndex = 1;
                SaveFD12.RestoreDirectory = true;
                if (SaveFD12.ShowDialog() == DialogResult.OK)
                {
                    string src = SaveFD12.FileName;
                    System.IO.File.Copy(src, DataFolderPath + @"\BasemUncle.accdb", true);
                    MessageBox.Show("تم استرجاع البيانات بنجاح !", "Backup Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Text = SaveFD12.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ اثناء تحميل البيانات!" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearDbFile()
        {
            DialogResult dialogResult = MessageBox.Show("هل تريد بدا عملية جديدة برجاء الاختفاظ بنسخه البيانات  قبل بدا فتره جديدة", "تأكيد بدا عملية جديدة الان", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ConnectionClass conObj = new ConnectionClass();
                conObj.startConnection();
                try
                {
                    #region Delete all the prev Data
                    String sql = "delete from aqsat";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from cheques";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from Clients";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from ClientsUnits";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from units";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from first_paids";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from montsben";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from T5sesMoney";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from tanazolat";
                    conObj.SQLUPDATE(sql, false);
                    sql = "delete from transactions where group_id <> 0";
                    conObj.SQLUPDATE(sql, true);
                    #endregion
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطأ اثناء مسح البيانات القديمة !" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void saveBackUpBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { SaveBackUpData(); });
        }

        private void restorDataBackUpBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { RestoreDataBackUp(); });
        }

        private void clearDbFileBtn_Click(object sender, EventArgs e)
        {
            this.Invoke((MethodInvoker)delegate () { ClearDbFile(); });
        }
    }
}
