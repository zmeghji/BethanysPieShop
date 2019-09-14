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
using BethanysPieShop.Adapters;
using BethanysPieShopCore.Models;

namespace BethanysPieShop.Fragments
{
    public class PieCategoryFragment : Android.Support.V4.App.Fragment
    {
        private readonly Category category;

        public PieCategoryFragment(Category category)
        {
            this.category = category;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.pie_menu_fragment, container, false);
            var categoryTextView = view.FindViewById<TextView>(Resource.Id.categoryTextView);
            categoryTextView.Text = category.Name;

            var pieRecyclerView = view.FindViewById<RecyclerView>(Resource.Id.pieRecyclerView);
            var pieLayoutManager = new LinearLayoutManager(this.Context);
            pieRecyclerView.SetLayoutManager(pieLayoutManager);
            var pieAdaptor = new PieAdaptor(category);
            pieAdaptor.ItemClick += (sender, args) =>
            {
                var navigateToPieDetailIntent = new Intent();
                navigateToPieDetailIntent.SetClass(this.Context, typeof(PieDetailActivity));
                navigateToPieDetailIntent.PutExtra("selectedPieId", args);
                StartActivity(navigateToPieDetailIntent);
            };
            pieRecyclerView.SetAdapter(pieAdaptor);
            return view;
        }
    }
}