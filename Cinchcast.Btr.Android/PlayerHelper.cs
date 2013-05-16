using Android.Media;
using Android.Net;
using Android.App;

namespace Cinchcast.Btr.Android
{
	public class PlayerHelper
	{
		MediaPlayer _player;
		Activity _context;


		public PlayerHelper(Activity context)
		{
			_context = context;
		}

		public void Play(string url)
		{
			if (_player != null)
			{
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

