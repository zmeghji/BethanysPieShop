using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BethanysPieShop
{
    [Activity(Label = "AboutActivity")]
    public class AboutActivity : Activity
    {
        private Button callButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.about);
            callButton = FindViewById<Button>(Resource.Id.callButton);
            callButton.Click += (sender, args) =>
            {
                var intent = new Intent(Intent.ActionDial);
                intent.SetData(Android.Net.Uri.Parse("tel:+11234567890"));
                intent.AddFlags(ActivityFlags.NewTask);
                StartActivity(intent);
            };
            // Create your application here
        }
    }
}