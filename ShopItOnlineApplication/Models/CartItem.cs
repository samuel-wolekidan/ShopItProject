using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ShopItOnlineApplication.Models
{
    public class CartItem
    {
        public string Name { get; set; }
        public double Discount { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string ImageName { get; set; }
        public double RemainingCost { get; set; }
        public double ShippingCost { get; set; }
        public DateTime ShippingDate { get; set; }
        public bool Status { get; set; }
        public enum ItemType { StoreItem, ShopItem }
    }
}