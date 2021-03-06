﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using StorehouseModels;
using StorehouseBLL;

namespace Storehouse
{
    public partial class FrmOutBound : Form
    {

        FrmGoodsManager F = new FrmGoodsManager();
        public string userType { set; get; }
        public string userTy { set; get; }
        public bool smai { set; get; }
        public FrmOutBound()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnoutBound_Click(object sender, EventArgs e)
        {
            ck();
        }

        public void ck()
        {

            if (userType.Equals("仓库"))
            {
                StoreHouseGoods gs = new StoreHouseGoods();
                gs.GoodsID = this.txtGoodsID.Text.Trim();
                gs.GoodsColor = this.txtGoodsColor.Text.Trim();
                gs.GoodsNum = Convert.ToInt32(txtGoodsNum.Text.Trim());

                if (GoodsManager.StoreHouseOutbound(gs, smai))
                {
                    JiLu jl = new JiLu();
                    jl.UserName = this.userTy;
                    jl.GoodsID = gs.GoodsID;
                    jl.GoodsColor = gs.GoodsColor;
                    jl.GoodsNum = gs.GoodsNum;
                    jl.GoodsType = smai?"仓库出库零售":"仓库出库批发";
                    string jlu = JiLuManager.JiLuAdd(jl) ? "记录成功" : "记录失败";
                    MessageBox.Show("仓库出库成功！", "提示");
                    MessageBox.Show(jlu, "提示");
                   
                    this.Hide();
                    F.userType = this.userTy;
                  

                }
                else
                {
                    MessageBox.Show("仓库出库失败,请输入值！", "提示");

                }
            }
            if (userType.Equals("店铺"))
            {

                ShopGoods goods = new ShopGoods();
                goods.GoodsID = this.txtGoodsID.Text.Trim();
                goods.GoodsColor = this.txtGoodsColor.Text.Trim();
                goods.GoodsNum = Convert.ToInt32(txtGoodsNum.Text.Trim());


                if (GoodsManager.ShopOutbound(goods, smai))
                {
                    JiLu jl = new JiLu();
                    jl.UserName = this.userTy;
                    jl.GoodsID = goods.GoodsID;
                    jl.GoodsColor = goods.GoodsColor;
                    jl.GoodsNum = goods.GoodsNum;
                    jl.GoodsType = smai ? "店铺出库零售" : "店铺出库批发";
                    string jlu = JiLuManager.JiLuAdd(jl) ? "记录成功" : "记录失败";
                    MessageBox.Show("店铺出库成功！", "提示");
                    MessageBox.Show(jlu, "提示");
                   
                    this.Hide();
                    F.userType = this.userTy;
                   
                   
                }
                else
                {
                    MessageBox.Show("店铺出库失败,请输入值！", "提示");
                }

            }
        }

        private void FrmOutBound_Load(object sender, EventArgs e)
        {
            this.label5.Text = userType;
        }

        private void txtGoodsNum_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
