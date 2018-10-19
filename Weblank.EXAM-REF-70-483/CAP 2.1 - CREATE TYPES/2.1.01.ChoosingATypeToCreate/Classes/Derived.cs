namespace ChoosingATypeToCreate.Classes
{
	public class Derived : Base
	{
		public override int MyMethod()
		{
			return base.MyMethod() * 2;
		}
	}
}
