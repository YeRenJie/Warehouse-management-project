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
    public partial class FrmStorage : Form
    {
        FrmGoodsManager F = new FrmGoodsManager();
        public string userType { set; get; }
        public string userTy { set; get; }
        public bool smai { set; get; }
        public FrmStorage()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            rk();
        }

        private void FrmStorage_Load(object sender, EventArgs e)
        {
            this.label5.Text = userType;
        }
        public void rk() 
        {
        
            if (userType.Equals("仓库"))
            {
                StoreHouseGoods gs = new StoreHouseGoods();
                gs.GoodsID = this.txtGoodsID.Text.Trim();
                gs.GoodsColor = this.txtGoodsColor.Text.Trim();
                gs.GoodsNum = Convert.ToInt32(txtGoodsNum.Text.Trim());
                gs.StorageDate = Convert.ToDateTime(dtpStorageDate.Text.Trim());
                if (GoodsManager.StoreHouseStorage(gs, smai))
                {
                    JiLu jl = new JiLu();
                    jl.UserName = this.userTy;
                    jl.GoodsID = gs.GoodsID;
                    jl.GoodsColor = gs.GoodsColor;
                    jl.GoodsNum = gs.GoodsNum;
                    jl.GoodsType = smai ? "仓库入库零售" : "仓库入库批发"; 
                   string jlu= JiLuManager.JiLuAdd(jl)?"记录成功":"记录失败";
                    MessageBox.Show("仓库入库成功！", "提示");
                    MessageBox.Show(jlu, "提示");
                    FrmGoodsManager F = new FrmGoodsManager();
                    F.userType = this.userTy;
                    this.Hide();
                    
                   
                  
                    
                }
                else 
                {
                    MessageBox.Show("仓库入库失败,请输入正确的值！", "提示");
                }
            }
            if (userType.Equals("店铺"))
            {
            
            ShopGoods goods = new ShopGoods();
            goods.GoodsID = this.txtGoodsID.Text.Trim();
            goods.GoodsColor = this.txtGoodsColor.Text.Trim();
            goods.GoodsNum = Convert.ToInt32(txtGoodsNum.Text.Trim());
            goods.StorageDate = Convert.ToDateTime(dtpStorageDate.Text.Trim());

            if (GoodsManager.ShopStorage(goods,smai))
            {
                JiLu jl = new JiLu();
                jl.UserName = this.userTy;
                jl.GoodsID = goods.GoodsID;
                jl.GoodsColor = goods.GoodsColor;
                jl.GoodsNum = goods.GoodsNum;
                jl.GoodsType = smai ? "店铺入库零售" : "店铺入库批发";
                string jlu = JiLuManager.JiLuAdd(jl) ? "记录成功" : "记录失败";
                MessageBox.Show("店铺入库成功！", "提示");
                MessageBox.Show(jlu, "提示");
             
                F.userType = this.userTy;
                this.Hide();
              
               
            }
            else
            {
                MessageBox.Show("店铺入库失败,请输入正确的值！", "提示");
            }

            }
        }
    }
}