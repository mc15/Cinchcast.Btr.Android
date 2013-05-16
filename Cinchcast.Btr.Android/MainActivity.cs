using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Cinchcast.Btr.Android
{
	[Activity (Label = "BlogTalkRadio", MainLauncher = true)]
	public class Activity1 : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature(WindowFeatures.NoTitle);
			SetContentView (Resource.Layout.Main);

			ListView lstEpisodes = FindViewById<ListView> (Resource.Id.listViewEpisodes);

			List<EpisodeViewModel> episodes = new List<EpisodeViewModel> ();

			for (int i=0; i < 25; i++) {
				DateTime publishDate = DateTime.Now.AddDays (-i);

				episodes.Add (new EpisodeViewModel(){ Name=  "Episode " + (i + 1).ToString(), PublishDate = publishDate.ToShortDateString()  });
			}

			lstEpisodes.Adapter = new EpisodeAdapter (this, episodes);
		}
	}
}


