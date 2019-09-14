using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace BethanysPieShop
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher =true)]
    public class MainActivity : AppCompatActivity
    {
        private Button _orderButton;
        private Button _viewCart;
        private Button _aboutUsButton;
        private Button _menuWithTabsButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            //var button = FindViewById<Button>(Resource.Id.MyButton);
            //button.Click += (sender, eventArgs) =>
            //{
            //    var toast = Toast.MakeText(this, "A button was clicked", ToastLength.Short);
            //    toast.Show();
            //};
            _orderButton = FindViewById<Button>(Resource.Id.orderButton);
            _orderButton.Click += (sender, args) =>
             {
                 StartActivity(new Intent(this, typeof(PieMenuActivity)));
             };
            _viewCart = FindViewById<Button>(Resource.Id.viewCartButton);
            _viewCart.Click += (sender, args) =>
            {
                StartActivity(new Intent(this, typeof(CartActivity)));
            };
            _aboutUsButton = FindViewById<Button>(Resource.Id.aboutUsButton);
            _aboutUsButton.Click += (sender, args) =>
            {
                StartActivity(new Intent(this, typeof(AboutActivity)));
            };
            _menuWithTabsButton = FindViewById<Button>(Resource.Id.menuWithTabsButton);
            _menuWithTabsButton.Click += (sender, args) =>
            {
                StartActivity(new Intent(this, typeof(PieMenuWithTabsActivity)));
            };
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}