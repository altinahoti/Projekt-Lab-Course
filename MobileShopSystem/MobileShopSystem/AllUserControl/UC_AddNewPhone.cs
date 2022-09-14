using System;
using System.Windows.Forms;

namespace MobileShopSystem.AllUserControl
{
    public partial class UC_AddNewPhone : UserControl
    {
        function fn = new function();
        String query;
        public UC_AddNewPhone()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCompany.Text != "" && txtModel.Text != "" && txtRam.Text != "" && txtInternal.Text != "" && txtExpandable.Text != "" && txtDisplay.Text != "" && txtCamera.Text != "" && txtFinger.Text != "" && txtSim.Text != "" && txtNetwork.Text != "" && txtPrice.Text != "")
            {
                String MobileCompany = txtCompany.Text;
                String MobileModel = txtModel.Text;
                String MobileRam = txtRam.Text;
                String MobileInternal = txtInternal.Text;
                String MobileExpandable = txtExpandable.Text;
                String MobileDisplay = txtDisplay.Text;
                String MobileCamera = txtCamera.Text;
                String MobileFingerprint = txtFinger.Text;
                String MobileSim = txtSim.Text;
                String MobileNetwork = txtNetwork.Text;
                Int64 MobilePrice = Int64.Parse(txtPrice.Text);
                query = " insert into newMobiles (MobileCompany,MobileModel,MobileRam,MobileInternal,MobileExpandable,MobileDisplay,MobileCamera,MobileFingerprint,MobileSim,MobileNetwork,MobilePrice) values ('" + MobileCompany + "','" + MobileModel + "','" + MobileRam + "','" + MobileInternal + "','" + MobileExpandable + "','" + MobileDisplay + "','" + MobileCamera + "','" + MobileFingerprint + "','" + MobileSim + "','" + MobileNetwork + "','" + MobilePrice + "')";
                fn.setData(query);
                
            }
            else
            {
                MessageBox.Show("Fill All Data", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtCompany.Clear();
            txtModel.Clear();
            txtRam.StartIndex = -1;
            txtInternal.StartIndex = -1;
            txtExpandable.StartIndex = -1;
            txtDisplay.StartIndex = -1;
            txtFinger.StartIndex = -1;
            txtCamera.StartIndex = -1;
            txtSim.StartIndex = -1;
            txtNetwork.StartIndex = -1;
            txtPrice.Clear();
        }

        private void UC_AddNewPhone_Load(object sender, EventArgs e)
        {

        }
    }
}
