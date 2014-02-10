using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace FreeXP.Core
{
	public class XPFreer
	{
		readonly IProvideXPsToFree _provider;

		public XPFreer(IProvideXPsToFree provider)
		{
			_provider = provider;
		}

		public void FreeSomething()
		{
			_provider.GetRandomXPOfStateOrDefault(XPState.Trapped).Free();
		}

		public void TrapSomething()
		{
			_provider.GetRandomXPOfStateOrDefault(XPState.Free).Trap();
		}
	}

	internal static class ThingMixins
	{
		readonly static Random _random = new Random();
		readonly static IXP _dummyXP = new BasicXP<object>(default(object), NoOp.Action<object>, NoOp.Action<object>, x => XPState.Free);

		public static IXP GetRandomXP(this IProvideXPsToFree provider)
		{
			return provider.XPs[_random.Next(provider.XPs.Count)];
		}

		public static IXP GetRandomXPOfStateOrDefault(this IProvideXPsToFree provider, XPState state)
		{
			IEnumerable<IXP> xpsOfState = provider.XPs.Where(x => x.State == state);
			return xpsOfState.ElementAtOrDefault(_random.Next(xpsOfState.Count())) ?? _dummyXP;
		}
	}
}

namespace System
{
	public static class NoOp
	{
		public static void Action() {}
		public static void Action<T>(T o) {}
	}
}
