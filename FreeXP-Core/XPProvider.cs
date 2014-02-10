using System;
using System.Collections.Generic;
using System.Linq;

namespace FreeXP.Core
{
	public class XPProvider<T> : IProvideXPsToFree
	{
		public XPProvider(IList<T> stuff, Action<T> free, Action<T> trap, Func<T, XPState> testState)
		{
			XPs = stuff.Select(x => new BasicXP<T>(x, free, trap, testState)).Cast<IXP>().ToList();
		}

		#region IProvideXPsToFree implementation

		public IList<IXP> XPs { get; private set; }

		#endregion
	}
}

