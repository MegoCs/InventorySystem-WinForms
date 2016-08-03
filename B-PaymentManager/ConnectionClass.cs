﻿using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace B_PaymentManager
{
    class ConnectionClass
    {
        public OleDbConnection myConnection = null;
        public OleDbDataReader myReader = null;
        public OleDbCommand myCommand = null;
        public OleDbDataAdapter myAdabter = null;

        public ConnectionClass() {        
            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);
        }

        public void startConnection() 
        {
            String myConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Data\BasemUncle.accdb";
           
            try
            {
                if(myConnection == null || myConnection.State == System.Data.ConnectionState.Closed)
                myConnection = new OleDbConnection(myConnectionString);                             
            }

            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف الاتصال بقاعدة البيانات" + ex.Message);
            }
        }

        public void SQLCODE(String sql,bool adabter)
        {
            try
            {
                if (!adabter)
                {
                    myCommand = new OleDbCommand(sql, myConnection);
                    if (myConnection.State == 0)
                        myConnection.Open();
                    myReader = myCommand.ExecuteReader();
                }
                else {
                    myAdabter = new OleDbDataAdapter(sql, myConnection);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطأ ف العملية " + ex.Message);
            }
        }

        public void SQLUPDATE(String sql,bool Message)
        {
            try
            {
            myCommand = new OleDbCommand(sql, myConnection);
            if (myConnection.State == 0)
                myConnection.Open();
            myCommand.ExecuteNonQuery();
                if(Message)
                MessageBox.Show("تم حفظ البيانات");
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا ف العملية برجاء اعد المحاولة");
            }
        }

        }
}
