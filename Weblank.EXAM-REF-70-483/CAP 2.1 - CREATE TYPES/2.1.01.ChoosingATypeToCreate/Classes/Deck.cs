using System;
using System.Collections.Generic;
using System.Linq;

namespace ChoosingATypeToCreate.Classes
{
	public class Deck
	{
		public ICollection<Card> Cards10 { get; private set; }

		public Card this[int index]
		{
			get { return Cards10.ElementAt(index); }
		}

		private int _maximumNumberOfCards;

		public List<Card> Cards { get; set; }

		public Deck(int maximumNumberOfCards)
		{
			this._maximumNumberOfCards = maximumNumberOfCards;
			Cards = new List<Card>();
		}

		public void Print()
		{
			Console.WriteLine("_maximumNumberOfCards: " + this._maximumNumberOfCards.ToString());
		}
	}
}
