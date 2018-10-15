using ChoosingATypeToCreate.Classes;
using System;
using System.Collections.Generic;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X12
	{
		// LISTING 2-12 Chaining constructors
		public MainListing2X12()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X12");
			Console.WriteLine("----------------------------------------------------------------");

			ConstructorChaining constructor1 = new ConstructorChaining();
			constructor1.Print();

			ConstructorChaining constructor2 = new ConstructorChaining(5);
			constructor2.Print();

			Console.ReadLine();
		}
	}
}
