using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Graphics;
using System;
using System.Net;

namespace FlickerApp
{
    [Activity(Label = "FlickerApp", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        GridView gridView;
        List<String> bitmapUris;
        List<Bitmap> gridViewItems;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            gridView = FindViewById<GridView>(Resource.Id.gridView);

            bitmapUris = new List<string>();
            bitmapUris.Add("http://images4.fanpop.com/image/photos/15000000/My-Sample-Pictures-lexi-and-sophie-15061826-1024-768.jpg");
            bitmapUris.Add("http://www.cameraegg.org/wp-content/uploads/2013/08/AF-S-DX-NIKKOR-18-140mm-f-3.5-5.6G-ED-VR-sample-images-1.jpg");
            bitmapUris.Add("http://upload.wikimedia.org/wikipedia/en/5/5d/The_Samples-Outpost.jpg");
            bitmapUris.Add("http://www.1800postcards.com/images/samples/sample_kits2.jpg");

            gridViewItems = GetBitmapImages(bitmapUris);
            gridView.Adapter = new GridViewAdapter(this, gridViewItems);
        }

        List<Bitmap> GetBitmapImages(List<String> bitmapUris)
        {
            List<Bitmap> images = new List<Bitmap>();
            Bitmap image;
            foreach (var uri in bitmapUris)
            {
                image = GetImageBitmapFromUri(uri);
                images.Add(image);
            }
            return images;
        }

        private Bitmap GetImageBitmapFromUri(string uri)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(uri);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }

    }
}

