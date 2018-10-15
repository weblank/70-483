using ChoosingATypeToCreate.Entities;
using System;
using System.Collections.Generic;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X10
	{
		// LISTING 2-10 Creating a collection such as a Deck class
		public MainListing2X10()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X10");
			Console.WriteLine("----------------------------------------------------------------");

			List<int> myList = new List<int>() { 1, 3, 5 };
			myList[0] = 1;

			MyClass.MyStaticField = 43;

			Console.WriteLine("MyClass.MyStaticField: "+MyClass.MyStaticField.ToString());

			Console.ReadLine();
		}
	}
}
