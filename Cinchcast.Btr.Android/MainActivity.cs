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
			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			//Button button = FindViewById<Button> (Resource.Id.myButton);
			
			//button.Click += delegate {
			//	button.Text = string.Format ("{0} clicks!", count++);
			//};

			ListView lstEpisodes = FindViewById<ListView> (Resource.Id.listViewEpisodes);

			List<EpisodeViewModel> episodes = new List<EpisodeViewModel> ();

			for (int i=0; i < 25; i++) {
				episodes.Add (new EpisodeViewModel(){ Name=  "Episode 1", PublishDate = "Just now"});
				episodes.Add (new EpisodeViewModel(){ Name=  "Episode 2", PublishDate = "15 minutes ago"});
			}

			lstEpisodes.Adapter = new EpisodeAdapter (this, episodes);
		}
	}
}


