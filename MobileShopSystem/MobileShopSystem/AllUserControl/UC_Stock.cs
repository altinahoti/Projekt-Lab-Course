using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopSystem.AllUserControl
{
    
    public partial class UC_Stock: UserControl
    {
        function fn = new function();
        String query;
        public UC_Stock()
        {
            InitializeComponent();
        }

        private void UC_Stock_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobiles";
            DataSet ds= fn.getData(query);
            guna2DataGridView1.DataSource = ds.Tables[0];
        }
        int BId;
        private void guna2DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (guna2DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value !=  null)
            {
                BId = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            query = "select * from newMobiles where MobileId = " + BId + "";
            DataSet ds = fn.getData(query);
            Companylabel.Text = ds.Tables[0].Rows[0][1].ToString();
            Modellabel.Text = ds.Tables[0].Rows[0][2].ToString();
            Ramlabel.Text = ds.Tables[0].Rows[0][3].ToString();
            Internallabel.Text = ds.Tables[0].Rows[0][4].ToString();
            Expandablelabel.Text = ds.Tables[0].Rows[0][5].ToString();
            Displaylabel.Text = ds.Tables[0].Rows[0][6].ToString();
            Cameralabel.Text = ds.Tables[0].Rows[0][7].ToString();
            Fingerprintlabel.Text = ds.Tables[0].Rows[0][8].ToString();
            Simlabel.Text = ds.Tables[0].Rows[0][9].ToString();
            Networklabel.Text = ds.Tables[0].Rows[0][10].ToString();
            Pricelabel.Text = ds.Tables[0].Rows[0][11].ToString();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
