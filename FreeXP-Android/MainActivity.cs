using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using FreeXP.Core;
using System.Collections.Generic;
using System.Linq;

namespace FreeXP.Android
{
	[Activity(Label = "FreeXP-Android", MainLauncher = true)]
	public class MainActivity : Activity
	{
		XPFreer _freer;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			_freer = new XPFreer(new XPProvider(FindViewById<LinearLayout>(Resource.Id.linearLayout1).GetAllChildren().Cast<ToggleButton>()));

			FindViewById<Button>(Resource.Id.free).Click += delegate {
				_freer.FreeSomething();
			};

			FindViewById<Button>(Resource.Id.trap).Click += delegate {
				_freer.TrapSomething();
			};
		}
	}

	public static class ViewGroupMixins
	{
		public static IEnumerable<View> GetAllChildren(this ViewGroup group)
		{
			for (int i = 0; i < group.ChildCount; i++) {
				yield return group.GetChildAt(i);
			}
		}
	}
}
