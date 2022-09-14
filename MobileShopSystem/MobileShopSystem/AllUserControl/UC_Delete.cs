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
    public partial class UC_Delete : UserControl
    {
        function fn = new function();
        String query;
        public UC_Delete()
        {
            InitializeComponent();
        }

        private void UC_Delete_Enter(object sender, EventArgs e)
        {
            query = "select * from newMobiles";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            query = "select * from newMobiles where MobileCompany like '" + txtSearch.Text + "%' or MobileModel like'"+txtSearch.Text+"%'  ";
            DataSet ds = fn.getData(query);
            DataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(DataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(DataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            query = "delete from newMobiles  where MobileId = "+bid+" ";
            if (MessageBox.Show("Deleting Record of " + bid +" ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                fn.setData(query);
            }
            else
            {
                MessageBox.Show("You Cancellecd the Operation .", "Back <=", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
