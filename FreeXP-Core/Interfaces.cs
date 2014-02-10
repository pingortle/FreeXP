using System;
using System.Collections.Generic;

namespace FreeXP.Core
{
	public interface IProvideXPsToFree
	{
		IList<IXP> XPs { get; }
	}

	public interface IXP
	{
		void Free();
		void Trap();
	}
}
