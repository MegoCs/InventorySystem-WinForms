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
    public partial class SellingOperation : Form
    {
        public SellingOperation()
        {
            InitializeComponent();
        }

        private void cancelCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
