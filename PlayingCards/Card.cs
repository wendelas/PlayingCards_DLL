using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    /// <summary>
    /// Provides properties and methods for creating a playing card.
    /// </summary>
    public class Card : IEquatable<Card>
    {
        /// <summary>
        /// Returns the rank of the card.
        /// </summary>
        public int Rank { get; private set; }

        /// <summary>
        /// Returns the suit of the card.
        /// </summary>
        public int Suit { get; private set; }

        /// <summary>
        /// Creates a card with rank and suit.
        /// </summary>
        /// <param name="rank">Value for the Rank property.</param>
        /// <param name="suit">Value for the Suit property</param>
        public Card(int rank, int suit)
        {
            if ((rank < GlobalVars.LowestCard) || (rank > GlobalVars.HighestCard)) 
                throw new Exception("Rank value was incorect");
            else 
                this.Rank = rank;

            if ((suit <= -1) || (suit >= 4)) 
                throw new Exception("Suit value was incorect");
            else 
                this.Suit = suit;
        }

        /// <summary>
        /// Returns a value indicating whether this instance is equal.
        /// </summary>
        /// <param name="other">Class Card</param>
        /// <returns>Bool type</returns>
        public bool Equals(Card other)
        {
            return ((this.Rank == other.Rank) && (this.Suit == other.Suit));
        }

        /// <summary>
        /// Returns string with the rank and the suit of the card.
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            string rank = null;
            string suit = null;

            switch (this.Rank)
            {
                case 10: rank = "T"; break;
                case 11: rank = "J"; break;
                case 12: rank = "Q"; break;
                case 13: rank = "K"; break;
                case 14: rank = "A"; break;
                case 1: rank = "A"; break;

                default: rank = this.Rank.ToString(); break;
            }

            switch (this.Suit)
            {
                case 0: suit = "C"; break;
                case 1: suit = "D"; break;
                case 2: suit = "H"; break;
                case 3: suit = "S"; break;
            }

            return (rank + suit);
        }
    }
}


