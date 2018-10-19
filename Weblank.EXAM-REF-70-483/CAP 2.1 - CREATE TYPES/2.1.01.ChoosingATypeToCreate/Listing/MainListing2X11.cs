using ChoosingATypeToCreate.Classes;
using System;
using System.Collections.Generic;

namespace ChoosingATypeToCreate.Listing
{
	public class MainListing2X11
	{
		// LISTING 2-11 Adding a constructor to your type
		public MainListing2X11()
		{
			Console.WriteLine("----------------------------------------------------------------");
			Console.WriteLine("MainListing2X11");
			Console.WriteLine("----------------------------------------------------------------");

			List<int> myList = new List<int>() { 1, 3, 5 };
			myList[0] = 1;

			MyClass.MyStaticField = 43;

			Console.WriteLine("MyClass.MyStaticField: "+MyClass.MyStaticField.ToString());

			Deck deck = new Deck(5);
			deck.Print();

			Console.ReadLine();
		}
	}
}
