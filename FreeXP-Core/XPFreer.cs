using System;
using System.Linq;

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
			_provider.GetRandomXP().Free();
		}

		public void TrapSomething()
		{
			_provider.GetRandomXP().Trap();
		}
	}

	internal static class ThingMixins
	{
		readonly static Random _random = new Random();

		public static IXP GetRandomXP(this IProvideXPsToFree provider)
		{
			return provider.XPs[_random.Next(provider.XPs.Count)];
		}
	}
}
