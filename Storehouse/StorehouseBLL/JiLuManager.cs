using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorehouseDAL;
using StorehouseModels;
namespace StorehouseBLL
{
    public class JiLuManager
    {
        public static bool JiLuAdd(JiLu jilu)
        {
           
                return JiLuService.JiLuAdd(jilu) > 0 ? true : false;
          
        }
        public static List<JiLu> GetAllshGoods()
        {
            return JiLuService.GetAllshGoods();
        }
    }
}
