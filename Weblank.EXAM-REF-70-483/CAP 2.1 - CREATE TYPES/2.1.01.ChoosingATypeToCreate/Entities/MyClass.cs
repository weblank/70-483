namespace ChoosingATypeToCreate.Entities
{
	public class MyClass
	{
		public string MyInstanceField;

		public string Concatenate(string valueToAppend)
		{
			return MyInstanceField + valueToAppend;
		}

		public static int MyStaticField = 42;
	}
}
