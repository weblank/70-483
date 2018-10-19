using System;

namespace ChoosingATypeToCreate.Classes
{
	public class ConstructorChaining
	{
		private int _p;

		public ConstructorChaining() : this(3) { }

		public ConstructorChaining(int p)
		{
			this._p = p;
		}

		public void Print()
		{
			Console.WriteLine("_p: " + this._p.ToString());
		}
	}
}
