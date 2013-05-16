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
		private PlayerHelper player;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			RequestWindowFeature(WindowFeatures.NoTitle);
			SetContentView (Resource.Layout.Main);

			player = new PlayerHelper (this);

			ListView lstEpisodes = FindViewById<ListView> (Resource.Id.listViewEpisodes);
			lstEpisodes.ItemClick += (object sender, AdapterView.ItemClickEventArgs e) => { OnEpisodeClicked(sender, e); };

			List<EpisodeViewModel> episodes = new List<EpisodeViewModel> ();

			for (int i=0; i < 25; i++) {
				DateTime publishDate = DateTime.Now.AddDays (-i);

				episodes.Add (new EpisodeViewModel(){ Name=  "Episode " + (i + 1).ToString(), PublishDate = publishDate.ToShortDateString()  });
			}

			lstEpisodes.Adapter = new EpisodeAdapter (this, episodes);
		}

		private void OnEpisodeClicked(object sender, AdapterView.ItemClickEventArgs e){
			player.Play ("http://www.blogtalkradio.com/craptasticallyhorrific/2013/05/16/sledgecast-death-tolls-1st-time.mp3");
		}
	}
}


