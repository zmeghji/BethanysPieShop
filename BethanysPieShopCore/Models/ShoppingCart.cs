using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShopCore.Models
{
    public class ShoppingCart
    {
        private static List<ShoppingCartItem> items = new List<ShoppingCartItem>();
        public static List<ShoppingCartItem> GetItems()
        {
            return items;
        }
        public static void Add(Pie pie, int amount)
        {
            if (items.Any(i => i.Pie.Id == pie.Id))
            {
                items.First(i => i.Pie.Id == pie.Id).Amount += amount;
            }
            else
            {
                items.Add(new ShoppingCartItem
                {
                    Pie = pie,
                    Amount = amount
                });
            }
        }
    }
}
