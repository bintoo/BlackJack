using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public class Deck
    {
        private List<Card> cards = new List<Card>(); //Create an List object for storing the cards

        //Initial cards
        public Deck()
        {
            for(int suit = 0; suit < 4; suit++)
            {
                for(int rank = 1; rank <= 13; rank++)
                {
                    cards.Add(new Card((Suit)suit, (Rank)rank));
                    /*if(rank < 9)   //for text
                     cards.Add(new Card((Suit)suit, Rank.Ace));
                    else
                        cards.Add(new Card((Suit)suit, Rank.King));*/
                }
            }
        }

        public List<Card> GetCards()
        {
           return cards;
        }
    }
}
