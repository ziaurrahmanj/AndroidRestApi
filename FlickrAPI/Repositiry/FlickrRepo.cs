using FlickrNet;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FlickrAPI.Repositiry
{
    public class FlickrRepo
    {
        Flickr flickr = new Flickr("bb0d0ae17b757ba7fbb0f0f275b0faec", "b57f010af76d1c3b");
        public List<String> Search(String tags,int pageNumber)
        {
            PhotoSearchOptions searchOptions = new PhotoSearchOptions();
            searchOptions.Tags=tags;
            searchOptions.Page = pageNumber;
            PhotoCollection photos = flickr.PhotosSearch(searchOptions);
            List<String> bitmapUris = new List<String>();
            foreach (var item in photos)
            {
                bitmapUris.Add(item.Small320Url);
            }
            return  bitmapUris;
        }
        // Gets weather data from the passed URL.
        private async Task<Object> FetchWeatherAsync(string url)
        {
            // Create an HTTP web request using the URL:
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (WebResponse response = await request.GetResponseAsync())
            {
                // Get a stream representation of the HTTP web response:
                using (Stream stream = response.GetResponseStream())
                {
                    var serializer = new JsonSerializer();

                    using (var sr = new StreamReader(stream))
                    using (var jsonTextReader = new JsonTextReader(sr))
                    {
                        return serializer.Deserialize(jsonTextReader);
                    }
                }
            }
        }

    }
}
