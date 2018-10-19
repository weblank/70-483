namespace ChoosingATypeToCreate.Classes
{
	public static class MyExtensions
	{
		public static decimal Discount(this Product product)
		{
			return product.Price * .9M;
		}
	}
}
