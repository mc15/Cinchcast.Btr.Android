using Android.Media;
using Android.Net;
using Android.App;

namespace Cinchcast.Btr.Android
{
	public class PlayerHelper
	{
		MediaPlayer _player;
		Activity _context;
		string _currentUrl = null;

		public PlayerHelper(Activity context)
		{
			_context = context;
		}

		public void Play(string url)
		{
			// If the url sent is the same we pause or start the current player.
			if (_currentUrl == url) {
				if (_player.IsPlaying) {
					_player.Pause ();
				} else {
					_player.Start ();
				}
			} else {
				// IF the url is not the same, then we must reset the current player and load the new url.
				_currentUrl = url;
				if (_player != null) {
					_player.Pause ();
					_player.Release ();
					_player.Dispose ();
				}

				//Uri uri = Uri.Parse("http://www.blogtalkradio.com/craptasticallyhorrific/2013/05/16/sledgecast-death-tolls-1st-time.mp3");
				Uri uri = Uri.Parse(url);
				_player = MediaPlayer.Create (_context, uri);
				_player.Start ();
			}
		}
	
	}
}

