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
using BethanysPieShopCore;
using BethanysPieShopCore.Models;

namespace BethanysPieShop.Adapters
{
    public class PieAdaptor : RecyclerView.Adapter
    {
        private List<Pie> _pies;
        public override int ItemCount => _pies.Count;
        public EventHandler<int> ItemClick;
        public PieAdaptor()
        {
            _pies = new PieRepository().Get();
        }
        public PieAdaptor(Category category)
        {
            _pies = new PieRepository().GetByCategory(category.Name);
        }
        //instantiates data of view holder
        public override void OnBindViewHolder(RecyclerView.ViewHolder holder, int position)
        {
            if (holder is PieViewHolder pieViewHolder)
            {
                pieViewHolder.PieNameTextView.Text = _pies[position].Name;
                var imageBitmap = ImageService.GetBitmapFromUrl(_pies[position].ImageUrl);
                pieViewHolder.PieImageView.SetImageBitmap(imageBitmap);
            }
        }

        // initializes the view holder by creating one using the an view retreived by inflating the passed in parent view group
        public override RecyclerView.ViewHolder OnCreateViewHolder(ViewGroup parent, int viewType)
        {
            var itemView = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.pie_viewholder, parent, false);
            var pieViewHolder = new PieViewHolder(itemView, (position)=> {
                ItemClick?.Invoke(this, _pies[position].Id);
            });
            return pieViewHolder;
        }
    }
}