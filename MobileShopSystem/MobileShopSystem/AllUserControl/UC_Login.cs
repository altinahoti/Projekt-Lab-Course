using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopSystem.AllUserControl
{
    public partial class UC_Login : UserControl
    {
        public UC_Login()
        {
            InitializeComponent();
            ToShowlabel.Visible = false;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
            panel1.Visible = false;
            this.guna2WinProgressIndicator1.Start();
        }
        //pjesa e loginit 
        int abc = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            abc++;
            if(abc ==10)
            {
                abc = 0;
                if (txtUsername.Text == "root" && txtPassword.Text == "root")
                {
                    this.Hide();
                    timer1.Stop();
                }
                else
                {
                    panel1.Visible = true;
                    ToShowlabel.Visible = true;
                    timer1.Stop();
                }
            }
        }

       
    }
}
