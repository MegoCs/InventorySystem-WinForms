﻿using System;
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
    public partial class AddClient : Form
    {
        ConnectionClass dbConObj;
        public AddClient()
        {
            InitializeComponent();
            dbConObj = new ConnectionClass();
        }

        private void saveBtn_AddClientTab_Click(object sender, EventArgs e)
        {
            dbConObj.startConnection();
            String sql = "insert into Clients (client_name,client_phone,client_address,client_national_id) values ('"+clientNameTxt_AddClientTab.Text+ "','" + clientPhoneTxt_AddClientTab.Text + "','" + clientAddressTxt_AddClientTab.Text + "','" + clientNationalIdTxt_AddClientTab.Text + "') ";
            dbConObj.SQLUPDATE(sql,true);
            FunctionsClass ex = new FunctionsClass();
            clientNameTxt_AddClientTab.Text = "";
            clientAddressTxt_AddClientTab.Text = "";
            clientPhoneTxt_AddClientTab.Text = "";
            clientNationalIdTxt_AddClientTab.Text = "";
        }
    }
}