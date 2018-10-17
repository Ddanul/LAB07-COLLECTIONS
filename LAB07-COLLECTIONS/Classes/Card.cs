using System;
using System.Collections.Generic;
using System.Text;

namespace LAB07_COLLECTIONS.Classes
{
    public class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }


        public enum Suits
        {
            Spades,
            Clubs,
            Diamonds,
            Hearts
        }

        public enum Values
        {
            Ace = 1,
            Two,
            Three,
            Four,
            Five,
            Six,
            Seven,
            Eight,
            Nine,
            Ten,
            Jack,
            Queen,
            King,
        }
    }
}
