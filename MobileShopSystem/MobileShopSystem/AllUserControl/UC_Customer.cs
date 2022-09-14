using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using System.Data.SqlClient;

namespace MobileShopSystem.AllUserControl
{
    public partial class UC_Customer : UserControl
    {
        function fn = new function();
        String query;
        public UC_Customer()
        {
            InitializeComponent();
        }

        //Required methods
        public void setComboBox(String query, ComboBox combo)
        {
            SqlDataReader sdr = fn.getForCombo(query);//select model from newMobile
            while(sdr.Read())
            {
                for (int i =0; i<sdr.FieldCount;i++)
                {
                    combo.Items.Add(sdr.GetString(i));
                }
            }


        }

        private void UC_Customer_Enter(object sender, EventArgs e)
        {
            txtCompany.Items.Clear();
            query = "select distinct MobileCompany from newMobiles";
            setComboBox(query, txtCompany);
        }
        //zgjedhja e kompanis nga databaza
        private void txtCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtModel.Items.Clear();
            String MobileCompany = txtCompany.Text;
            query ="select MobileModel from newMobiles where MobileCompany='"+MobileCompany+"'";
            setComboBox(query, txtModel);
        }
        //zgjedhja nga databaza e modelit dhe pjesve tjera te mobilit
        private void txtModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            rectangleShape1.BorderColor = System.Drawing.ColorTranslator.FromHtml("red"); 
            query="select * from newMobiles where MobileModel = '"+txtModel.Text+"'";
            DataSet ds = fn.getData(query);

            ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            cameralabel.Text = ds.Tables[0].Rows[0][6].ToString();
            fingerlabel.Text = ds.Tables[0].Rows[0][7].ToString();
            pricelabel.Text = ds.Tables[0].Rows[0][11].ToString();
        }
        //pjesa e save te saj
        private void btnItem_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "" && txtGender.Text != "" && txtContact.Text != "" && txtEmail.Text != "" && txtAddress.Text != "" && txtCompany.Text != "" && txtModel.Text != "" && txtImei.Text != "")
            {
                String name = txtName.Text;
                String gender = txtGender.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;
                String address = txtAddress.Text;
                String company = txtCompany.Text;
                String model = txtModel.Text;
                String imei = txtImei.Text;

                query = "insert into Customers (MName,MGender,MContact,MEmail,MAddress,MCompany,MModel,MImei) values ('" + name + "','" + gender + "','" + contact + "','" + email + "','" + address + "','" + company + "','" + model + "','" + imei + "')";
                fn.setData(query);
                txtName.Clear();
                txtGender.SelectedIndex = -1;
                txtContact.Clear();
                txtEmail.Clear();
                txtAddress.Clear();
                txtImei.Clear();
            }
            else
            {
                MessageBox.Show("Fill all the Fields.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
