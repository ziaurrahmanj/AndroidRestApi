using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Json;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using FlickrAPI;
using FlickrAPI.Portable;

namespace App1
{
    [Activity(Label = "App1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // Get the latitude/longitude EditBox and button resources:
            EditText latitude = FindViewById<EditText>(Resource.Id.latText);
            EditText longitude = FindViewById<EditText>(Resource.Id.longText);
            Button button = FindViewById<Button>(Resource.Id.getWeatherButton);
            // Get our button from the layout resource,
            // and attach an event to it
            // Button button = FindViewById<Button>(Resource.Id.MyButton);

            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };

            // When the user clicks the button ...
            button.Click += async (sender, e) =>
            {

                // Get the latitude and longitude entered by the user and create a query.
                //string url = "http://api.geonames.org/findNearByWeatherJSON?lat=" +
                //             latitude.Text +
                //             "&lng=" +
                //             longitude.Text +
                //             "&username=demo";
                string url = "https://api.flickr.com/services/rest/?method=flickr.photos.search&api_key=bb0d0ae17b757ba7fbb0f0f275b0faec&tags=india&format=json&callback=?";

                // Fetch the weather information asynchronously, 
                // parse the results, then update the screen:

                FlickrRepo repo = new FlickrRepo();
                
                var json = await repo.FetchWeatherAsync(url);
                // ParseAndDisplay (json);
            };
        }

       
    }
}

