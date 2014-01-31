using System;

namespace FreeXP.Core
{
	public class BasicXP : IXP
	{
		readonly Action _free;
		readonly Action _trap;

		public BasicXP(Action free, Action trap)
		{
			_free = free;
			_trap = trap;
		}

		#region IXP implementation

		public void Free()
		{
			if (_free != null) _free();
		}

		public void Trap()
		{
			if (_trap != null) _trap();
		}

		#endregion
	}
}

