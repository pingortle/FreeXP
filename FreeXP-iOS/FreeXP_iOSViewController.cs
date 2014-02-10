using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using FreeXP.Core;

namespace FreeXP.iOS
{
	public partial class FreeXP_iOSViewController : UIViewController
	{
		XPFreer _freer;

		public FreeXP_iOSViewController() : base("FreeXP_iOSViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			_freer = new XPFreer(
				new XPProvider<UISwitch>(
					new[] { switch1, switch2, switch3, switch4 },
					x => x.SetState(true, true),
					x => x.SetState(false, true)));
		}

		partial void free(MonoTouch.UIKit.UIButton sender)
		{
			_freer.FreeSomething();
		}

		partial void trap(MonoTouch.UIKit.UIButton sender)
		{
			_freer.TrapSomething();
		}
	}
}
