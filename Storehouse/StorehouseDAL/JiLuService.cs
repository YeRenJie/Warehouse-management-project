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
    public class JiLuService
    {
        private static string conStr = ConfigurationManager.ConnectionStrings["ck"].ToString();
        public static int JiLuAdd(JiLu jilu)
        {
            string sql = "insert into jilu(username,goodsid,goodscolor,goodsnum,goodsType) values(@username,@goodsID,@goodsColor,@goodsNum,@goodsType)";
            int iRet;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlParameter[] para ={  
                                        new SqlParameter("@username",jilu.UserName),
                                        new SqlParameter("@goodsID",jilu.GoodsID),
                                        new SqlParameter("@goodsColor",jilu.GoodsColor),
                                        new SqlParameter("@goodsNum",jilu.GoodsNum),                                       
                                        new SqlParameter("@goodsType",jilu.GoodsType)
                             
                                    };
                cmd.Parameters.AddRange(para);
                iRet = cmd.ExecuteNonQuery();
            }
            return iRet;
        }
        #region 获取记录信息
        public static List<JiLu> GetAllshGoods()
        {
            string sql = "select * from jilu";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    List<JiLu> jilu = new List<JiLu>();
                    SqlCommand cmb = new SqlCommand(sql, con);
                    SqlDataReader dr = cmb.ExecuteReader();
                    while (dr.Read())
                    {
                        JiLu jl = new JiLu();
                        jl.GoodsID = Convert.ToString(dr["goodsid"]);
                        jl.GoodsColor = dr["goodscolor"].ToString();
                        jl.GoodsNum = Convert.ToInt32(dr["goodsnum"]);
                        jl.NewDate = Convert.ToDateTime(dr["NewDate"]);
                        jl.UserName = Convert.ToString(dr["username"]);
                        jl.GoodsType = Convert.ToString(dr["goodsType"]);
                        jilu.Add(jl);
                    }
                    return jilu;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}
