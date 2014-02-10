using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeXP.Core
{
	public class XPProvider<T> : IProvideXPsToFree
	{
		public XPProvider(IList<T> stuff, Action<T> free, Action<T> trap)
		{
			XPs = stuff.Select(x => new BasicXP<T>(x, free, trap)).Cast<IXP>().ToList();
		}

		#region IProvideXPsToFree implementation

		public IList<IXP> XPs { get; private set; }

		#endregion
	}
}

