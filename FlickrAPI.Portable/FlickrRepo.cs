using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlickrAPI.Portable
{
    public class Geoname
    {
        public double lng { get; set; }
        public int geonameId { get; set; }
        public string countrycode { get; set; }
        public string name { get; set; }
        public string fclName { get; set; }
        public string toponymName { get; set; }
        public string fcodeName { get; set; }
        public string wikipedia { get; set; }
        public double lat { get; set; }
        public string fcl { get; set; }
        public int population { get; set; }
        public string fcode { get; set; }
    }

    public class RootObject
    {
        public List<Geoname> geonames { get; set; }
    }
    public class FlickrRepo
    {
        public string reponseJsonString { get; private set; }

        public async Task<Object> FetchWeatherAsync(string url)
        {
            // Create an HTTP web request using the URL:
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(new Uri(url));
            request.ContentType = "application/json";
            request.Method = "GET";

            // Send the request to the server and wait for the response:
            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Get a stream representation of the HTTP web response:
                    Task<HttpResponseMessage> getResponse = httpClient.GetAsync(new Uri("http://api.geonames.org/citiesJSON?north=44.1&south=-9.9&east=-22.4&west=55.2&lang=de&username=demo"));
                    HttpResponseMessage response = await getResponse;
                    reponseJsonString = await response.Content.ReadAsStringAsync();
                    var obj1 = JsonConvert.DeserializeObject<RootObject>(reponseJsonString);

                    return obj1;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
