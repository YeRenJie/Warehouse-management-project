using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using StorehouseDAL;
using StorehouseModels;

namespace StorehouseBLL
{
    public class UserManager
    {
        //查询登录用户
        public static User SelectUser(string UserName, string PassWord, string Userype)
        {
            return UserService.SelectUser(UserName ,PassWord, Userype);
        }
        public static User GetUserId(int userId)
        {
           return UserService.GetUserId(userId);
        }
        public static bool UpUser(User user)
        {
            return UserService.UpUser(user) > 0 ? true : false;
        }
        //验证登录
        public static bool CheckLogin(string UserName, string PassWord, string Userype)
        {
            User u = SelectUser(UserName, PassWord, Userype);
            if (u != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
