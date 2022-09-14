using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Iks largimi i faqes - mbyllja e faqes
        private void btnExitt_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // Minimizimi i faqes 
        private void btnMinimize_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
       
        // lidhja mes faqes me pjest tjerat te faqes 
        // nese faqet nuk klikohen atehere kemi faqe te "bardh" nuk shfaq asgje 
        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
   
            uC_AddNewPhone1.Visible = false;
            uC_Customer1.Visible = false;
            uC_Stock1.Visible = false;
            uC_CustomerRecords1.Visible = false;
            uC_Delete1.Visible = false;
            enableDisable(false, false, false);
        }
        // paraqitja e AddNewPhone ne pamje me prekje te buttonit 
        private void btnAddNewPhone_Click(object sender, EventArgs e)
        {
            uC_AddNewPhone1.Visible = true;
            uC_AddNewPhone1.BringToFront();
        }
        // paraqitja e Customers ne pamje me prekje te buttonit 

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            uC_Customer1.Visible = true;
            uC_Customer1.BringToFront();
        }
        // paraqitja e Stock ne pamje me prekje te buttonit 
        private void btnStock_Click(object sender, EventArgs e)
        {
            uC_Stock1.Visible = true;
            uC_Stock1.BringToFront();
        }
        // paraqitja e CustomerRecerdors ne pamje me prekje te buttonit 
        private void btnCustomerRecords_Click(object sender, EventArgs e)
        {
            uC_CustomerRecords1.Visible = true;
            uC_CustomerRecords1.BringToFront();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Panel2.Enabled = false;
            enableDisable(true, true, true);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Panel2.Enabled = true;
            enableDisable(false, false, false);
        }
        // verifikimi i passwordit tek delete 
        public void enableDisable (Boolean txtbox,Boolean btn1,Boolean btn2)
        {
            txtPassword.Visible = txtbox;
            btnVerify.Visible = btn1;
            btnCancel.Visible = btn2;
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(txtPassword.Text =="admin")
            {
                Panel2.Enabled = true;
                uC_Delete1.Visible = true;
                uC_Delete1.BringToFront();
                enableDisable(false, false, false);
                txtPassword.Clear();

            }
            else
            {
                txtPassword.Clear();
                MessageBox.Show("Incorrect");
            }
        }

        private void uC_Login1_VisibleChanged(object sender, EventArgs e)
        {
            panel1.Visible = true;
            btnAddNewPhone.PerformClick();
            
        }
    }
}
