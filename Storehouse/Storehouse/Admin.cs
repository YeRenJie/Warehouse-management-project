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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
       
        public string userType { set; get; }
    

        private void 后台登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (userType.Equals("总管理员"))
            {
                User user = new User();
                user.Show();
            }
            else 
            {
                MessageBox.Show("后台登陆只支持‘总管理员登陆'","提示");
            }
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

     

        private void 批发管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGoodsManager fgm = new FrmGoodsManager();
            fgm.MdiParent = this;
            fgm.userType = userType;
            fgm.smai = false;
            fgm.Show();
        }

        private void 零售管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSmai fgm = new FrmSmai();
            fgm.MdiParent = this;
            fgm.userType = userType;
            fgm.smai = true;

            fgm.Show();
        }

        private void 查看记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frmckjl fgm = new Frmckjl();
            fgm.MdiParent = this;
           

            fgm.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

        private void 说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
