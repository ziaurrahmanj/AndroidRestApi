using System;
using Android.Views;
using Android.Widget;
using Java.Lang;
using Android.Content;

namespace ReaderApp
{
    public  class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(context);

            i.SetImageResource(thumbIds[position]);
            i.LayoutParameters = new Gallery.LayoutParams(150, 100);
            i.SetScaleType(ImageView.ScaleType.FitXy);

            return i;
        }

        // references to our images
        int[] thumbIds = {
            Resource.Drawable.sample_1,
            Resource.Drawable.sample_2
     };
    }
}