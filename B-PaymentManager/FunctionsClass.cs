using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace B_PaymentManager
{

     class FunctionsClass
    {
        public static List<ComboBoxItem> clientsList = new List<ComboBoxItem>();
        public static List<ComboBoxItem> groupsList = new List<ComboBoxItem>();

        static private ConnectionClass dbConObj = new ConnectionClass();

        public FunctionsClass() {
            ClientsData();
            GroupsData();
        }

        private void ClientsData()
        {
            clientsList.Clear();
            dbConObj.startConnection();
            String sql = "select id,client_name from Clients";
            dbConObj.SQLCODE(sql, false);
            while (dbConObj.myReader.Read())
            {
                clientsList.Add(new ComboBoxItem
                {
                    Text = dbConObj.myReader[1].ToString(),
                    value = dbConObj.myReader[0].ToString()
                });
            }
        }
        private void GroupsData()
        {
            groupsList.Clear();
            dbConObj.startConnection();
            String sql = "select id,group_name from groups";
            dbConObj.SQLCODE(sql, false);
            while (dbConObj.myReader.Read())
            {
                groupsList.Add(new ComboBoxItem
                {
                    Text = dbConObj.myReader[1].ToString(),
                    value = dbConObj.myReader[0].ToString()
                });
            }
        }

    }
}
