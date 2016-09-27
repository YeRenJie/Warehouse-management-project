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
    public partial class FrmGoodsManager : Form
    {
        
        public  string UserName;
        //FrmLogin frmLogin = new FrmLogin();
        public string userType { set; get; }
        public bool smai { set; get; }
        public FrmGoodsManager()
        {
            
            InitializeComponent();
           
            
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            FrmStorage frmStorage = new FrmStorage();
            frmStorage.userTy = this.userType;
            frmStorage.userType = "店铺";
            frmStorage.smai = this.smai;
            frmStorage.Show();
        }

        private void btnOutbound_Click(object sender, EventArgs e)
        {
            FrmOutBound frmOutbound = new FrmOutBound();
            frmOutbound.userTy = this.userType;
            frmOutbound.userType = "店铺";
            frmOutbound.smai = this.smai;
            frmOutbound.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
           
        }

        #region 窗口载入
        private void FrmGoodsManager_Load(object sender, EventArgs e)
        {
            //仓库数据绑定
            Goodszr();

        }

        public void Goodszr()
        {
            this.lblUserName.Text = userType;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = GoodsManager.GetAllshGoods(smai);
            //店铺数据绑定
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.DataSource = GoodsManager.GetAllShopGoods(smai);
            

            //按钮设定
            if (userType == "仓库管理员")
            {
                //店铺按钮
                this.btnOutbound.Enabled = false;
                this.btnStorage.Enabled = false;
                //仓库按钮
                this.button1.Enabled = true;
                this.button2.Enabled = true;
            }
            if (userType == "店铺管理员")
            {
                //店铺按钮
                this.btnOutbound.Enabled = true;
                this.btnStorage.Enabled = true;
                //仓库按钮
                this.button1.Enabled = false;
                this.button2.Enabled = false;
            }

            if (userType == "总管理员")
            {
                //店铺按钮
                this.btnOutbound.Enabled = true;
                this.btnStorage.Enabled = true;
                //仓库按钮
                this.button1.Enabled = true;
                this.button2.Enabled = true;
            }

            if (userType == "游客")
            {
                //店铺按钮
                this.btnOutbound.Enabled = false;
                this.btnStorage.Enabled = false;
                //仓库按钮
                this.button1.Enabled = false;
                this.button2.Enabled = false;
            }
        }
        #endregion

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
         FrmStorage frmStorage = new FrmStorage();
         frmStorage.userTy = this.userType;
         frmStorage.userType = "仓库";
            frmStorage.smai = this.smai;
         frmStorage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmOutBound frmOutbound = new FrmOutBound();
            frmOutbound.userTy = this.userType;
            frmOutbound.userType = "仓库";
            frmOutbound.smai = this.smai;
            frmOutbound.ShowDialog();
        }

        private void btnSHSearch_Click(object sender, EventArgs e)
        {

            string goodsId = this.txtGoodsId.Text.Trim();

            this.dataGridView1.DataSource = GoodsManager.GetStoreHouseByIdDate(goodsId, smai);
        }

        private void btnShopSearch_Click(object sender, EventArgs e)
        {
            string goodsId = this.txtGoodsId.Text.Trim();

            this.dataGridView2.DataSource = GoodsManager.GetShopGoodsByIdDate(goodsId, smai);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Goodszr();
        }

        private void txtGoodsId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tcGoodsView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

   

  

       
    }
}
