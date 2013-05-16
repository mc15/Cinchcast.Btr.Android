using System;
using Android.Widget;
using Android.App;
using System.Collections.Generic;
using Android.Views;

namespace Cinchcast.Btr.Android
{
	public class EpisodeAdapter : BaseAdapter<EpisodeViewModel> {

		List<EpisodeViewModel> items;
		Activity context;

		public EpisodeAdapter(Activity context, List<EpisodeViewModel> items)
			: base()
		{
			this.context = context;
			this.items = items;
		}

		public override long GetItemId(int position)
		{
			return position;
		}

		public override EpisodeViewModel this[int position]
		{
			get { return items[position]; }
		}

		public override int Count
		{
			get { return items.Count; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{
			var item = items[position];
			View view = convertView;

			if (view == null) // no view to re-use, create new
				view = context.LayoutInflater.Inflate(Resource.Layout.EpisodeListItem, null);

			view.FindViewById<TextView> (Resource.Id.Text1).Text = item.Name;
			view.FindViewById<TextView>(Resource.Id.Text2).Text = item.PublishDate;

			return view;
		}
	}
}

