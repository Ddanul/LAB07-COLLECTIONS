using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace LAB07_COLLECTIONS.Classes
{
    class Deck<T> : IEnumerable
    {

        T[] cards = new T[5];
        int count = 0;

        public void Add(T card)
        {
            if(count == cards.Length)
            {
                Array.Resize(ref cards, cards.Length * 2);
            }
            cards[count++] = card;
        }

        public void Remove(T card)
        {
            for(int i = 0; i< cards.Length; i++)
            {
                if (cards[i].Equals(card))
                {
                    cards[i] = cards[i + 1];
                    cards[i + 1] = cards[cards.Length - 1];
                    count--;
                }
            }
            Console.WriteLine("Card not in deck.");
        }



        public List<T> ReturnSuit(string suit)
        {
            List<T> returnedCards = new List<T>();
            
            foreach(T card in cards)
            {
                if (card.Suit == suit)
                {
                    returnedCards.Add(card);
                }
            }
            return returnedCards;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i=0; i< count; i++)
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
