using System;
using System.Collections.Generic;
using System.Linq;
using FreeXP.Core;
using MonoTouch.UIKit;

namespace FreeXP.iOS
{
	public class XPProvider : IProvideXPsToFree
	{
		public XPProvider(IList<UISwitch> switches)
		{
			XPs = switches.Select(x => new BasicXP(() => x.SetState(true, true), () => x.SetState(false, true))).Cast<IXP>().ToList();
		}

		#region IProvideXPsToFree implementation

		public System.Collections.Generic.IList<IXP> XPs { get; private set; }

		#endregion
	}
}
