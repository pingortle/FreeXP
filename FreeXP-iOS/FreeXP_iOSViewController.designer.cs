// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace FreeXP.iOS
{
	[Register ("FreeXP_iOSViewController")]
	partial class FreeXP_iOSViewController
	{
		[Outlet]
		MonoTouch.UIKit.UISwitch switch1 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch switch2 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch switch3 { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISwitch switch4 { get; set; }

		[Action ("free:")]
		partial void free (MonoTouch.UIKit.UIButton sender);

		[Action ("trap:")]
		partial void trap (MonoTouch.UIKit.UIButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (switch1 != null) {
				switch1.Dispose ();
				switch1 = null;
			}

			if (switch2 != null) {
				switch2.Dispose ();
				switch2 = null;
			}

			if (switch3 != null) {
				switch3.Dispose ();
				switch3 = null;
			}

			if (switch4 != null) {
				switch4.Dispose ();
				switch4 = null;
			}
		}
	}
}
