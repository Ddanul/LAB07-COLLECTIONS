using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LAB07_COLLECTIONS.Classes
{
    public class Deck<T> : IEnumerable
    {

        public T[] cards = new T[5];
        int count = 0;

        public void Add(T card)
        {
            if (count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        public bool Remove(T card)
        {
            for (int i = 0; i < count; i++)
            {
                if (cards[i].Equals(card))
                {
                    for (int j = i; j < cards.Length-1; j++)
                    {
                        cards[j] = cards[j + 1];
                    }
                    count--;
                    Console.WriteLine();
                    Console.WriteLine($"The card was removed.");
                    return true;
                }
            }
            return false;
            
        }

        public List<Card> ReturnSuit(Suit suit)
        {
            List<Card> returnedCards = new List<Card>();

            for (int i = 0; i < count; i++)
            {
                Card card = (Card)Convert.ChangeType(cards[i], typeof(Card));
                if (card.Suit == suit)
                {
                    returnedCards.Add(card);
                }
            }
            return returnedCards;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return cards[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
