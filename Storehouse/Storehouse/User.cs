using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Storehouse
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            // TODO:  这行代码将数据加载到表“storehouseDataSet1.User”中。您可以根据需要移动或删除它。
            this.userTableAdapter.Fill(this.storehouseDataSet1.User);
            

        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string strValue = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();


            xgUser xguser= new xgUser();
            this.Hide();
            xguser.userId = Convert.ToInt32(strValue);
            xguser.Show();
        }


    }
}
