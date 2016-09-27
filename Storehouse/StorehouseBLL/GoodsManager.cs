using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StorehouseDAL;
using StorehouseModels;

namespace StorehouseBLL
{
    public class GoodsManager
    {
        #region 获取仓库货物全部信息
        public static List <StoreHouseGoods> GetAllshGoods(bool smai)
        {
            return GoodsService.GetAllshGoods(smai);
        }
        #endregion

        #region 获取店铺货物全部信息
        public static List<ShopGoods> GetAllShopGoods(bool smai)
        {
            return GoodsService.GetAllShopGoods(smai);
        }
        #endregion

        #region 店铺查询
        public static List<ShopGoods> GetShopGoodsByIdDate(string goodsId, bool smai)
        {
            return GoodsService.GetShopGoodsByIdDate(goodsId,smai);
        }
        #endregion

        #region 仓库查询
        public static List<StoreHouseGoods> GetStoreHouseByIdDate(string goodsId, bool smai)
        {
            return GoodsService.GetStoreHouseByIdDate(goodsId,smai);
        }
        #endregion
        //店铺入库
        public static bool ShopStorage(ShopGoods shopGoods, bool smai)
        {
            if (GoodsService.GetShopGoodsByIdDate(shopGoods.GoodsID, shopGoods.GoodsColor,smai))
            {
                return GoodsService.UpShopStorage(shopGoods,smai) > 0 ? true : false;
            }
            else 
            { 
                return GoodsService.ShopStorage(shopGoods,smai) > 0 ? true : false; 
            }
        }
        //仓库入库
        public static bool StoreHouseStorage(StoreHouseGoods sGoods, bool smai)
        {
            if (GoodsService.GetStoreHouseByIdDate(sGoods.GoodsID, sGoods.GoodsColor,smai))
            {
                return GoodsService.UpStoreHouseGoods(sGoods,smai) > 0 ? true : false;
            }
            else
            {
                return GoodsService.StoreHouseStorage(sGoods,smai) > 0 ? true : false;
            }
            
        }

        #region 仓库出库
        public static bool StoreHouseOutbound(StoreHouseGoods shopGoods, bool smai)
        {
            return GoodsService.StoreHouseOutbound(shopGoods,smai) > 0 ? true : false;
        }
        #endregion

        #region 店铺出库
        public static bool ShopOutbound(ShopGoods shopGoods, bool smai)
        {
            return GoodsService.ShopOutbound(shopGoods,smai) > 0 ? true : false;
        }
        #endregion
    }
}
