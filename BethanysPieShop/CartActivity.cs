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

namespace BethanysPieShop
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        private RecyclerView recyclerView;
        private RecyclerView.LayoutManager layoutManager;
        private CartAdapter cartAdaptor;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.cart);
            recyclerView = FindViewById<RecyclerView>(Resource.Id.cartRecyclerView);
            layoutManager = new LinearLayoutManager(this);
            cartAdaptor = new CartAdapter();
            recyclerView.SetAdapter(cartAdaptor);
            recyclerView.SetLayoutManager(layoutManager);

            // Create your application here
        }
    }
}