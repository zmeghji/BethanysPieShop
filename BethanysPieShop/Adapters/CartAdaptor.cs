using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using BethanysPieShop.Utitlities;
using BethanysPieShop.ViewHolders;
using BethanysPieShopCore.Models;

namespace BethanysPieShop.Adapters
{
    public class CartAdapter : RecyclerView.Adapter
    {
        private List<ShoppingCartItem> cartItems { get; set; }
        public CartAdapter()
        {
            cartItems = ShoppingCart.GetItems();
        }
        public override int ItemCount => cartItems.Count;

        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is CartViewHolder cartViewHolder)
            {
                cartViewHolder.PieNameTextView.Text = cartItems[position].Pie.Name;
                cartViewHolder.PieAmountTextView.Text = cartItems[position].Amount.ToString();
                var imageBitmap = ImageService.GetBitmapFromUrl(cartItems[position].Pie.ImageUrl);
                cartViewHolder.PieImageView.SetImageBitmap(imageBitmap);
            }
        }

        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.cart_viewholder, parent, false);
            var cartViewHolder = new CartViewHolder(itemView);
            return cartViewHolder;
        }
    }
}