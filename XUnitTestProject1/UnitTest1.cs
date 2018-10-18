using System;
using Xunit;
using LAB07_COLLECTIONS.Classes;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        /// <summary>
        /// Test to add a card to the deck
        /// </summary>
        [Fact]
        public void CanAddCardToDeck()
        {
            //Arrange
            Deck<Card> deck = new Deck<Card>();
            Card newCard = new Card();

            deck.Add(newCard);

            //Assert
            Assert.Equal(newCard, deck.cards[0]);
        }

        /// <summary>
        /// Test to check getters setters from Card class
        /// </summary>
        [Fact]
        public void CanGetSetFromCardClass()
        {
            //Arrange
            Card card = new Card() { Suit = Suit.Clubs, Value = Value.Ace };

            //Assert
            Assert.Equal("Clubs", card.Suit.ToString());
        }

        /// <summary>
        /// Test to check that card gets removed from deck
        /// </summary>
        [Fact]
        public void CanRemoveCardFromDeck()
        {
            //Arrange
            Card card1 = new Card() { Suit = Suit.Clubs, Value = Value.Ace };
            Card card2 = new Card() { Suit = Suit.Hearts, Value = Value.King };
            Card card3 = new Card() { Suit = Suit.Spades, Value = Value.Five };
            Card card4 = new Card() { Suit = Suit.Diamonds, Value = Value.Seven };
            Card card5 = new Card() { Suit = Suit.Diamonds, Value = Value.Queen };

            Deck<Card> deck = new Deck<Card>();

            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);
            deck.Add(card4);
            deck.Add(card5);

            deck.Remove(card1);

            //Assert
            Assert.Equal(card2, deck.cards[0]);
        }

        /// <summary>
        /// Test to check that card not in deck cannot be removed
        /// </summary>
        [Fact]
        public void DeckDisplaysErrorWhenCardNotInDeckIsRemoved()
        {
            //Arrange
            Card card1 = new Card() { Suit = Suit.Clubs, Value = Value.Ace };
            Card card2 = new Card() { Suit = Suit.Hearts, Value = Value.King };
            Card card3 = new Card() { Suit = Suit.Spades, Value = Value.Five };
            Card card4 = new Card() { Suit = Suit.Diamonds, Value = Value.Seven };
            Card card5 = new Card() { Suit = Suit.Diamonds, Value = Value.Queen };

            Deck<Card> deck = new Deck<Card>();

            deck.Add(card1);
            deck.Add(card2);
            deck.Add(card3);
            deck.Add(card4);

            //Assert
            Assert.False(deck.Remove(card5));
        }
    }
}
