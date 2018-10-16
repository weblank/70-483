namespace ChoosingATypeToCreate.Classes
{
	public class Derived2 : Base
	{
		public sealed override int MyMethod()
		{
			return base.MyMethod() * 2;
		}
	}
}
