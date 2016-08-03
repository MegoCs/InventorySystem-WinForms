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
    public partial class LoginForm : Form
    {
        int i = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            if (i <= 100)
                progressBar1.Value = i;

            if (i == 140)
            {
                timer1.Stop();
                this.Hide();
            }

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (userNameTxt.Text != "" && userPassTxt.Text != "")
            {
                timer1.Start();
                //check if password is true
                if (true) {
                    
                }
                progressBar1.Value = 0;
            }
        }
    }
}
