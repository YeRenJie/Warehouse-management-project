using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using StorehouseModels;

namespace StorehouseDAL
{
    public class UserService
    {
        private static string conStr=ConfigurationManager.ConnectionStrings["ck"].ToString();

        public static User SelectUser(string UserName ,string PassWord, string UserType)
        {
            string sql = string.Format("select * from [User] where UserName='{0}' and UserPwd='{1}' and UserType='{2}'", UserName, PassWord, UserType);
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                User u=null;
                if(dr.Read())
                {
                    u = new User();
                    u.UserName = dr["UserName"].ToString();
                    u.PassWord = (string)dr["UserPwd"];
                    u.UserType = (string)dr["UserType"];
                    u.UserID = (int)dr["UserID"];

                }
                return u;
            }
        }
        public static User GetUserId(int userId)
        {
            string sql = "select * from [User] where UserID=" + userId;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader dr = cmd.ExecuteReader();
                User u = null;
                if (dr.Read())
                {
                    u = new User();
                    u.UserName = dr["UserName"].ToString();
                    u.PassWord = (string)dr["UserPwd"];
                    u.UserType = (string)dr["UserType"];
                    u.UserID = (int)dr["UserID"];

                }
                return u;
            }
        }
        public static int UpUser(User user)
        {
            string sql = "update [User] set UserName='" + user.UserName + "',UserPwd='" + user.PassWord + "',UserType='" + user.UserType + "' where UserID=" + user.UserID;
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                int ret = cmd.ExecuteNonQuery();

                return ret;
            }
        }
    }
}
