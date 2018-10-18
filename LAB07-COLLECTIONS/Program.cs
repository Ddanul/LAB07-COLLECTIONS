using System;
using System.Collections.Generic;
using LAB07_COLLECTIONS.Classes;

namespace LAB07_COLLECTIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Card card1 = new Card() { Suit = Suit.Clubs, Value = Value.Ace };
            Card card2 = new Card() { Suit = Suit.Hearts, Value = Value.King };
            Card card3 = new Card() { Suit = Suit.Spades, Value = Value.Five};
            Card card4 = new Card() { Suit = Suit.Diamonds, Value = Value.Seven };
            Card card5 = new Card() { Suit = Suit.Diamonds, Value = Value.Queen };

            Deck<Card> deck = new Deck<Card>();

            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);
            deck.Add(card4);
            deck.Add(card5);

            Print(deck);

            deck.Remove(card1);

            Print(deck);

            var filteredDeck = deck.ReturnSuit(Suit.Diamonds);

            PrintSuits(filteredDeck);
        }

        static void Print(Deck<Card> deck)
        {
            Console.WriteLine();
            foreach (Card card in deck)
            {
                if(card != null)
                {
                    Console.WriteLine($"{card.Value} of {card.Suit}");
                }
                else { Console.WriteLine("null"); }
                
            }
        }

        static void PrintSuits(List<Card> deck)
        {
            Console.WriteLine();
            foreach(Card card in deck)
            {
                Console.WriteLine($"{card.Value} of {card.Suit}");
            }
        }
    }
}
