using ChoosingATypeToCreate.Classes;
using System;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X09
	{
		// LISTING 2-09 Declaring and using a field
		public MainListing2X09()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X09");
			Console.WriteLine("----------------------------------------------------------------");

			MyClass instance = new MyClass();
			instance.MyInstanceField = "Some New Value";

			Console.ReadLine();
		}
	}
}
