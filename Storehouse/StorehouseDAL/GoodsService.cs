using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorehouseModels;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace StorehouseDAL
{
    public class GoodsService
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["ck"].ToString();

        #region 获取仓库货物全部信息
        public static List<StoreHouseGoods> GetAllshGoods(bool smai)
        {
            string sql = "";
            if (smai)
            {
                sql = "select * from smstorehouseGoods where GoodsNum>0";
            }
            else 
            {
                 sql = "select * from storehouseGoods where GoodsNum>0";
            }
            
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    List<StoreHouseGoods> shGoods = new List<StoreHouseGoods>();
                    SqlCommand cmb = new SqlCommand(sql, con);
                    SqlDataReader dr = cmb.ExecuteReader();
                    while (dr.Read())
                    {
                        StoreHouseGoods shGood = new StoreHouseGoods();
                        shGood.GoodsID = Convert.ToString(dr["GoodsID"]);
                        shGood.GoodsColor = dr["GoodsColor"].ToString();
                        shGood.GoodsNum = Convert.ToInt32(dr["GoodsNum"]);
                        shGood.OutboundDate = Convert.ToDateTime(dr["OutboundDate"]);
                        shGood.StorageDate = Convert.ToDateTime(dr["StorageDate"]);
                        shGoods.Add(shGood);
                    }
                    return shGoods;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        #region 获取店铺货物全部信息
        public static List<ShopGoods> GetAllShopGoods(bool smai)
        {
            string sql = "";
            if (smai)
            {
                 sql = "select * from smshopGoods where GoodsNum>0";
            }
            else 
            {
                 sql = "select * from shopGoods where GoodsNum>0";
            }
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    List<ShopGoods> sGoods = new List<ShopGoods>();
                    SqlCommand cmb = new SqlCommand(sql, con);
                    SqlDataReader dr = cmb.ExecuteReader();
                    while (dr.Read())
                    {
                        ShopGoods sGood = new ShopGoods();
                        sGood.GoodsID = Convert.ToString(dr["GoodsID"]);
                        sGood.GoodsColor = dr["GoodsColor"].ToString();
                        sGood.GoodsNum = Convert.ToInt32(dr["GoodsNum"]);
                        sGood.OutboundDate = Convert.ToDateTime(dr["OutboundDate"]);
                        sGood.StorageDate = Convert.ToDateTime(dr["StorageDate"]);
                        sGoods.Add(sGood);
                    }
                    return sGoods;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        #region 店铺查询
        public static List<ShopGoods> GetShopGoodsByIdDate(string goodsId,bool smai)
        {
            string sql = "";
            if (smai)
            {
                sql = "select * from smShopGoods where GoodsId like '%" + goodsId + "%'";
            }
            else 
            {
                sql = "select * from ShopGoods where GoodsId like '%" + goodsId + "%'";
            }
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                List<ShopGoods> sGoods = new List<ShopGoods>();
        
                SqlCommand cmd = new SqlCommand(sql, con);
             
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ShopGoods sGood = new ShopGoods();
                    sGood.GoodsID = Convert.ToString(dr["GoodsID"]);
                    sGood.GoodsColor = dr["GoodsColor"].ToString();
                    sGood.GoodsNum = Convert.ToInt32(dr["GoodsNum"]);
                    sGood.OutboundDate = Convert.ToDateTime(dr["OutboundDate"]);
                    sGood.StorageDate = Convert.ToDateTime(dr["StorageDate"]);
                    sGoods.Add(sGood);
                }
                return sGoods;
            }
        }
        public static bool GetShopGoodsByIdDate(string goodsId,string color,bool smai)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select");
            sb.Append(" *");
            sb.Append(" from");
            if (smai)
            {
                sb.Append(" smShopGoods");
            }
            else
            {
                sb.Append(" ShopGoods");
            }
            
            sb.Append(" where");
            sb.Append(" GoodsID=@goodsId and GoodsColor=@GoodsColor ");

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                
                SqlParameter[] para ={
                                        new SqlParameter("@goodsId",goodsId),
                                        new SqlParameter("@GoodsColor",color)
                                    };
                SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                cmd.Parameters.AddRange(para);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                }
                return false;
            }
        }
        #endregion

        #region 仓库查询
        public static List<StoreHouseGoods> GetStoreHouseByIdDate(string goodsId,bool smai)
        {
            string sql = "";
            if (smai)
            {
                sql = "select * from smStorehouseGoods where GoodsId like '%" + goodsId + "%'";
            }
            else 
            {
                sql = "select * from StorehouseGoods where GoodsId like '%" + goodsId + "%'";

            }
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                List<StoreHouseGoods> sGoods = new List<StoreHouseGoods>();
             
             
                SqlCommand cmd = new SqlCommand(sql, con);
          
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StoreHouseGoods sGood = new StoreHouseGoods();
                    sGood.GoodsID = Convert.ToString(dr["GoodsID"]);
                    sGood.GoodsColor = dr["GoodsColor"].ToString();
                    sGood.GoodsNum = Convert.ToInt32(dr["GoodsNum"]);
                    sGood.OutboundDate = Convert.ToDateTime(dr["OutboundDate"]);
                    sGood.StorageDate = Convert.ToDateTime(dr["StorageDate"]);
                    sGoods.Add(sGood);
                }
                return sGoods;
            }
        }
        public static bool GetStoreHouseByIdDate(string goodsId, string color, bool smai)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("select");
            sb.Append(" *");
            sb.Append(" from");
            if (smai)
            {
                sb.Append(" smStorehouseGoods");
            }
            else 
            {
                sb.Append(" StorehouseGoods");
            }
            sb.Append(" where");
            sb.Append(" GoodsID=@goodsId and GoodsColor=@GoodsColor");

            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlParameter[] para ={
                                        new SqlParameter("@goodsId",goodsId),
                                        new SqlParameter("@GoodsColor",color)
                                    };
                SqlCommand cmd = new SqlCommand(sb.ToString(), con);
                cmd.Parameters.AddRange(para);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    return true;
                    
                }
                return false;
            }
        }
        #endregion

        #region 店铺入库
        public static int ShopStorage(ShopGoods shopGoods,bool smai)
        {
            string sql = "";
            if (smai)
            {
               sql = "insert into smShopGoods(GoodsID,GoodsColor,GoodsNum) values(@goodsID,@goodsColor,@goodsNum)";
            }
            else 
            {
               sql = "insert into ShopGoods(GoodsID,GoodsColor,GoodsNum) values(@goodsID,@goodsColor,@goodsNum)";
            }
                int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={
                                        new SqlParameter("@goodsID",shopGoods.GoodsID),
                                        new SqlParameter("@goodsColor",shopGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",shopGoods.GoodsNum),
                             
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }
        //更新店铺
        public static int UpShopStorage(ShopGoods shopGoods,bool smai) 
        {
            string sql = "";
            if (smai)
            {
                 sql = "update smShopGoods  set GoodsNum=GoodsNum+@goodsNum,StorageDate=@storageDate where GoodsID=@goodsID AND GoodsColor=@GoodsColor";

            }
            else
            {
                 sql = "update ShopGoods  set GoodsNum=GoodsNum+@goodsNum,StorageDate=@storageDate where GoodsID=@goodsID AND GoodsColor=@GoodsColor";

            }
            int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={
                                        new SqlParameter("@goodsID",shopGoods.GoodsID),
                                         new SqlParameter("@GoodsColor",shopGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",shopGoods.GoodsNum)
                                       
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }
        #endregion

        #region 仓库入库
        public static int StoreHouseStorage(StoreHouseGoods sGoods,bool smai)
        {

            string sql = "";
            if (smai)
            {
                 sql = "insert into smStoreHouseGoods(GoodsID,GoodsColor,GoodsNum) values(@goodsID,@goodsColor,@goodsNum)";
            }
            else
            {
                 sql = "insert into StoreHouseGoods(GoodsID,GoodsColor,GoodsNum) values(@goodsID,@goodsColor,@goodsNum)";
            } 
            int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={
                                        new SqlParameter("@goodsID",sGoods.GoodsID),
                                        new SqlParameter("@goodsColor",sGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",sGoods.GoodsNum)
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }

        //更新仓库
        public static int UpStoreHouseGoods(StoreHouseGoods shopGoods, bool smai)
        {
            
            string sql = "";
            if (smai)
            {
                sql = "update smStoreHouseGoods  set GoodsNum=GoodsNum+@goodsNum,StorageDate=@storageDate  where GoodsID=@goodsID  AND GoodsColor=@GoodsColor";
            }
            else
            {
                sql = "update StoreHouseGoods  set GoodsNum=GoodsNum+@goodsNum,StorageDate=@storageDate  where GoodsID=@goodsID  AND GoodsColor=@GoodsColor";
            } 
            
            int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={
                                        new SqlParameter("@goodsID",shopGoods.GoodsID), 
                                        new SqlParameter("@goodsColor",shopGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",shopGoods.GoodsNum),
                                        new SqlParameter("@storageDate",shopGoods.StorageDate)
                                       
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }
        #endregion

        #region 仓库出库
        public static int StoreHouseOutbound(StoreHouseGoods shopGoods, bool smai)
        {
            try
            {
                string sql = "";
                if (smai)
                {
                     sql = "update smStoreHouseGoods  set GoodsNum=GoodsNum-@goodsNum  where GoodsID=@goodsID  AND GoodsColor=@GoodsColor";
                }
                else
                {
                     sql = "update StoreHouseGoods  set GoodsNum=GoodsNum-@goodsNum  where GoodsID=@goodsID  AND GoodsColor=@GoodsColor";
                } 
                int iRet;
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlParameter[] para ={
                                        new SqlParameter("@goodsID",shopGoods.GoodsID), 
                                        new SqlParameter("@goodsColor",shopGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",shopGoods.GoodsNum),
                                       // new SqlParameter("@storageDate",shopGoods.StorageDate)
                                       
                                    };
                    cmd.Parameters.AddRange(para);
                    iRet = cmd.ExecuteNonQuery();
                }
                return iRet;
            }
            catch (Exception)
            {
                return -1;
            }
        }
        #endregion

        #region 店铺出库
        public static int ShopOutbound(ShopGoods shopGoods, bool smai)
        {
            string sql = "";
            if (smai)
            {
                 sql = "update smShopGoods  set GoodsNum=GoodsNum-@goodsNum where GoodsID=@goodsID AND GoodsColor=@GoodsColor";
            }
            else
            {
                sql = "update ShopGoods  set GoodsNum=GoodsNum-@goodsNum where GoodsID=@goodsID AND GoodsColor=@GoodsColor";
            } 
            int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={
                                        new SqlParameter("@goodsID",shopGoods.GoodsID),
                                         new SqlParameter("@GoodsColor",shopGoods.GoodsColor),
                                        new SqlParameter("@goodsNum",shopGoods.GoodsNum)
                                       
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }
        #endregion
    }
}
