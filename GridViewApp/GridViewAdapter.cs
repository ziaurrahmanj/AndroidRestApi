using System.Collections.Generic;
using Android.Graphics;
using Android.Widget;
using Android.App;
using Android.Views;

namespace GridViewApp
{
    public class GridViewAdapter: BaseAdapter
    {
        Activity context;
        List<Bitmap> gridViewtems;

        public GridViewAdapter(Activity context, List<Bitmap> gridViewtems)
        {
            this.context = context;
            this.gridViewtems = gridViewtems;
        }

        public override int Count
        {
            get { return gridViewtems.Count; }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View view = convertView;
            if (view == null)
                view = context.LayoutInflater.Inflate(Resource.Layout.GridViewItemWithImageAndText, null);
            view.FindViewById<ImageView>(Resource.Id.grid_image).SetImageBitmap(gridViewtems[position]);
            view.FindViewById<TextView>(Resource.Id.grid_text).Text = position.ToString();
            return view;

        }
    }
}