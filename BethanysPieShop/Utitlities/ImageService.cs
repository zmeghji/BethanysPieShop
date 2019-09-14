using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BethanysPieShop.Utitlities
{
    public class ImageService
    {
        public static Bitmap GetBitmapFromUrl(string url)
        {
            Bitmap image = null;
            using (var webclient = new WebClient())
            {
                var imageBytes = webclient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    image = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }
            return image;
        }
    }
}