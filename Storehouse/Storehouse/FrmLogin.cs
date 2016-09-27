using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StorehouseBLL;
using StorehouseModels;

namespace Storehouse
{
    public partial class FrmLogin : Form
    {
        Admin fgm = new Admin();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //User user = new User();
            //user.UserName = this.txtUserName.Text.Trim();
            //user.PassWord = this.txtPwd.Text.Trim();
            //user.UserType = (string)this.cboUsertype.SelectedText;


            if (UserManager.CheckLogin(this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim(), this.cboUsertype.Text))
            {
                MessageBox.Show("登录成功！");
              
                fgm.userType = this.cboUsertype.Text.Trim();
                this.Hide();
                fgm.Show();
            }
            else
            {
                MessageBox.Show("登录失败！");
                return;
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
