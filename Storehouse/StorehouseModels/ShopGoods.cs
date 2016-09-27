using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StorehouseModels
{
    public class ShopGoods
    {
        public string GoodsID { get; set; }
        public string GoodsColor { get; set; }
        public int GoodsNum { get; set; }
        public DateTime StorageDate { get; set; }
        public DateTime OutboundDate { get; set; }
    }
}
