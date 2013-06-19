using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    /// <summary>
    /// Sort cards first by suit then by Rank.
    /// </summary>
    public class SuitSort : IComparer<Card>
    {
        /// <summary>
        /// Compares the cards
        /// </summary>
        /// <returns>32 bit integer to compare.</returns>
        public int Compare(Card a, Card b)
        {
            if (a.Suit == b.Suit) return a.Rank.CompareTo(b.Rank);
            else return a.Suit.CompareTo(b.Suit);
        }
    }

    /// <summary>
    /// Sort cards first by rank then by suit.
    /// </summary>
    public class RankSort : IComparer<Card>
    {
        /// <summary>
        /// Compares the cards
        /// </summary>
        /// <returns>32 bit integer to compare.</returns>
        public int Compare(Card a, Card b)
        {
            if (a.Rank == b.Rank) return a.Suit.CompareTo(b.Suit);
            else return a.Rank.CompareTo(b.Rank);
        }
    }
}
