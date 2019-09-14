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
    [Activity(Label = "PieMenuActivity")]
    public class PieMenuActivity : Activity
    {
        private RecyclerView _recyclerView;
        private RecyclerView.LayoutManager _pieLayoutManager;
        private PieAdaptor _pieAdaptor;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu);
            SetupRecylcerView();
        }
        private void SetupRecylcerView()
        {
            //retreive recycler view defined in pie_menu.xml
            _recyclerView = FindViewById<RecyclerView>(Resource.Id.pieRecyclerView);
            //create a layout manager class by passing it this class instance
            _pieLayoutManager = new LinearLayoutManager(this);
            //_pieLayoutManager = new GridLayoutManager(this, 2, GridLayoutManager.Horizontal, false);
            // set the recycler view's layout manager as the one jsut created
            _recyclerView.SetLayoutManager(_pieLayoutManager);
            // instantiate a  pie adaptor class
            _pieAdaptor = new PieAdaptor();
            //set the recyclerview's pie adaptor to the one jsut created
            _recyclerView.SetAdapter(_pieAdaptor);

            _pieAdaptor.ItemClick += (sender, args) =>
            {
                var navigateToPieDetailIntent = new Intent();
                navigateToPieDetailIntent.SetClass(this, typeof(PieDetailActivity));
                navigateToPieDetailIntent.PutExtra("selectedPieId", args);
                StartActivity(navigateToPieDetailIntent);
            };

            // recycler view takes a reference to the layout manager and the adaptor
        }
    }
}