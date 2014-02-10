using System;

namespace FreeXP.Core
{
	public class BasicXP<T> : IXP
	{
		readonly Action<T> _free;
		readonly Action<T> _trap;
		readonly T _thing;

		public BasicXP(T thing, Action<T> free, Action<T> trap)
		{
			_free = free;
			_trap = trap;
			_thing = thing;
		}

		#region IXP implementation

		public void Free()
		{
			if (_free != null) _free(_thing);
		}

		public void Trap()
		{
			if (_trap != null) _trap(_thing);
		}

		#endregion
	}
}

