using System;
using FreeXP.Core;
using System.Collections.Generic;
using Android.Widget;
using System.Linq;

namespace FreeXP.Android
{
	public class XPProvider : IProvideXPsToFree
	{
		public XPProvider(IEnumerable<ToggleButton> switches)
		{
			XPs = switches.Select(x => new BasicXP(() => x.Checked = true, () => x.Checked = false)).Cast<IXP>().ToList();
		}

		#region IProvideXPsToFree implementation

		public IList<IXP> XPs { get; private set; }

		#endregion
	}
}

