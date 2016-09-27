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
    public partial class xgUser : Form
    {
        public xgUser()
        {
            InitializeComponent();
        }
        public  int userId { set; get; }
        private void xgUers_Load(object sender, EventArgs e)
        {
            zairu();
        }
        public void zairu() {


            StorehouseModels.User user = UserManager.GetUserId(userId);
            this.textBox1.Text = user.UserName;
            this.textBox2.Text = user.PassWord;
            this.comboBox1.SelectedText = user.UserType;
            if (user.UserType.Equals("总管理员"))
                this.comboBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StorehouseModels.User user = new StorehouseModels.User();
            user.UserID = userId;
            user.UserName = this.textBox1.Text;
            user.PassWord = this.textBox2.Text;
            user.UserType = this.comboBox1.Text;
            if (UserManager.UpUser(user))
            {
                MessageBox.Show("修改成功！", "提示");
            }
            else 
            {
                MessageBox.Show("修改失败！", "提示");
            }
        }
    }
}
