namespace ChoosingATypeToCreate.Classes
{
	public class MyClass<T> where T : class, new()
	{
		T MyProperty { get; set; }

		public MyClass()
		{
			MyProperty = new T();
		}

		public void MyGenericMethod<T>()
		{
			T defaultValue = default(T);
		}
	}
}
