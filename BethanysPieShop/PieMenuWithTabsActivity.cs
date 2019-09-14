
using Android.App;
using Android.OS;
using Android.Support.V4.View;
using BethanysPieShop.Adapters;

namespace BethanysPieShop
{
    [Activity(Label = "PieMenuWithTabsActivity")]
    public class PieMenuWithTabsActivity : Android.Support.V7.App.AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.pie_menu_tabs);
            var pager = FindViewById<ViewPager>(Resource.Id.piePager);
            var adapter = new CategoryFragmentAdapter(SupportFragmentManager);
            pager.Adapter = adapter;
        }
    }
}