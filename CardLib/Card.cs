using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Card
    {
        private Suit cardSuit;
        private Rank cardRank;
        private string cardName;

        public Suit CardSuit
        {
            get
            {
                return cardSuit;
            }
        }

        public Rank CardRank
        {
            get
            {
                return cardRank;
            }
        }

        public string CardName
        {
            get
            {
                return cardName;
            }
        }

        private Card()
        {
        }

        public Card(Suit suit, Rank rank)
        {
            cardRank = rank;
            cardSuit = suit;
            cardName = cardRank.ToString();
            cardName += cardSuit.ToString();
        }

        public Card Clone()
        {
            Card newCard;
            newCard = new Card(this.CardSuit, this.CardRank);
            return newCard;
        }
    }
}
