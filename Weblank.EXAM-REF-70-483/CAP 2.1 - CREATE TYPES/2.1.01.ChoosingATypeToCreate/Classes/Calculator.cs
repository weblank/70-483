namespace ChoosingATypeToCreate.Classes
{
	public class Calculator
	{
		public int Add(int x, int y)
		{
			return x + y;
		}

		public Distance CalculateDistanceTo(Customer customer)
		{
			Distance result = customer.address.distance; // Some difficult calculation that uses customer.Address
			return result;
		}

		public Distance CalculateDistanceTo(Address address)
		{
			Distance result = address.distance; // Some difficult calculation that uses address
			return result;
		}

		public void MyMethod(
			int firstArgument, 
			string secondArgument = "default value",
			bool thirdArgument = false)
		{
		}

		public void MethodWithoutAnyReturnValue()
		{
		}

		public int MethodWithReturnValue()
		{
			return 42;
		}

		public decimal CalculateDiscount(Product p)
		{
			return p.Discount();
		}
	}
}
