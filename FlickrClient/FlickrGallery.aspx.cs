using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FlickrClient
{
    public partial class FlickrGallery : System.Web.UI.Page
    {
        public static int _pageNumber=1;
        FlickrAPI.Repositiry.FlickrRepo flickrRepo = new FlickrAPI.Repositiry.FlickrRepo();
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        public void Search(string tags)
        {
            ////clear
            //Literal1.Text = "";

            //StringBuilder pageLinks = new StringBuilder();           

            //var photoCollection = flickrRepo.Search(tags,_pageNumber);
            
            //Literal1.Text += string.Format("<div>{0} </div>", photoCollection.Pages);


            //foreach (var item in photoCollection)
            //{
            //    var image = String.Format("<img src='{0}' alt='{1}' />", item.Small320Url, item.DateTaken);

            //    Literal1.Text += image;

             
            //}
            //Literal1.Text += pageLinks.ToString();
        }
       
        protected void SearchBtn_Click(object sender, EventArgs e)
        {
            Search(SearchTerm.Text);
        }

        protected void NextPageBtn_Click(object sender, EventArgs e)
        {
            _pageNumber += 1;
            Search(SearchTerm.Text);
        }
    }
}