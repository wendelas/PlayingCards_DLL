using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayingCards
{
    public class Deck
    {
        private List<Card> deck;
        private Random random;

        /// <summary>
        /// Returns how many cards are left in the deck.
        /// </summary>
        public int CardsLeft
        {
            get { return this.deck.Count; }
        }

        /// <summary>
        /// Creates a standart deck of 52 cards with highest rank Ace.
        /// </summary>
        public Deck()
        {
            this.deck = new List<Card>();
            this.random = new Random();

            this.ResetDeck();
        }

        /// <summary>
        /// Creates deck with spesific count of cards starting from spesific rank.
        /// </summary>
        /// <param name="lowestCard">The lowest rank in the deck.</param>
        /// <param name="highestCard">The highest rank in the deck.</param>
        public Deck(int lowestCard, int highestCard)
        {
            this.deck = new List<Card>();
            this.random = new Random();

            if ((highestCard - lowestCard) <= 0) throw new Exception("Incorect values for lowest or highest card.");

            if (lowestCard == 1) GlobalVars.AceRank = 1;
            else GlobalVars.AceRank = 14;

            GlobalVars.LowestCard = lowestCard;
            GlobalVars.HighestCard = highestCard;

            this.ResetDeck();
        }

        /// <summary>
        /// Deal a random card from the deck.
        /// </summary>
        /// <returns>Class Card</returns>
        public Card DealCard()
        {
            if (this.CardsLeft == 0) throw new Exception("You are trying to deal a card but there aren't any cards left in the deck");

            int index = this.random.Next(this.CardsLeft);
            Card card = this.deck[index];

            this.deck.RemoveAt(index);

            return card;
        }

        /// <summary>
        /// Puts all the cards back into the deck.
        /// </summary>
        public void ResetDeck()
        {
            this.deck.Clear();

            for (int a = 0; a < 4; a++)
            {
                for (int b = GlobalVars.LowestCard; b < (GlobalVars.HighestCard + 1); b++)
                {
                    this.deck.Add(new Card(b, a));
                }
            }
        }
    }
}
