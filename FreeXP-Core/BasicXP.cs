using System;

namespace FreeXP.Core
{
	public class BasicXP<T> : IXP
	{
		readonly Action<T> _free;
		readonly Action<T> _trap;
		readonly Func<T, XPState> _testState;
		readonly T _thing;

		public BasicXP(T thing, Action<T> free, Action<T> trap, Func<T, XPState> testState)
		{
			_free = free;
			_trap = trap;
			_thing = thing;
			_testState = testState;
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


		public XPState State { get { return _testState(_thing); } }
		#endregion
	}
}

