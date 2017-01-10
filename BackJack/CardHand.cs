using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardLib;

namespace BackJack
{
    public class CardHand
    {
        private bool onTheGame;
        private bool splited;
        private bool blackJack;
        private bool bust;
        private int cardValue;
        private bool softValue;
        private bool isDouble;
        private int cardsReceived;
        PairState pair;
        Card firstCard;
        Card secondCard;

        public CardHand()
        {
            onTheGame = false;
            blackJack = false;
            bust = false;
            cardValue = 0;
            softValue = false;
            isDouble = false;
            cardsReceived = 0;
            pair = PairState.None;
        }



        public bool OnTheGame
        {
            get
            {
                return onTheGame;
            }
            set
            {
                onTheGame = value;
            }
        }

        public bool IsBlackJack
        {
            get
            {
                return blackJack;
            }
            set
            {
                blackJack = value;
            }
        }

        public bool IsBust
        {
            get
            {
                return bust;
            }
            set
            {
                bust = value;
            }
        }

        public int TotalCardValue
        {
            get
            {
                if ((softValue == true) && (cardValue > 21))
                {
                    softValue = false;
                    cardValue -= 10;
                }
                return cardValue;
            }
            set
            {
                cardValue = value;
            }
        }
        public int CardsReceived
        {
            get
            {
                return cardsReceived;
            }
            set
            {
                cardsReceived = value;
            }
        }
        public Card FirstCard
        {
            get
            {
                return firstCard;
            }
            set
            {
                firstCard = value;
            }
        }
        public Card SecondCard
        {
            get
            {
                return secondCard;
            }
            set
            {
                secondCard = value;
            }
        }

        public bool SoftValue
        {
            get
            {
                return softValue;
            }
            set
            {
                softValue = value;
            }
        }
        public PairState Pair
        {
            get
            {
                return pair;
            }
            set
            {
                pair = value;
            }
        }

        public bool Splited
        {
            get
            {
                return splited;
            }
            set
            {
                splited = value;
            }
        }
        public bool IsDouble
        {
            get
            {
                return isDouble;
            }
            set
            {
                isDouble = value;
            }
        }

        public bool Doubleable()
        {
            return (cardsReceived == 2 && softValue != true);
        }
        public bool Splitable()
        {
            if (splited == false)
            {
                int firstCardValue = ((int)firstCard.CardRank > 10) ? 10 : (int)firstCard.CardRank;
                int secondCardValue = ((int)secondCard.CardRank > 10) ? 10 : (int)secondCard.CardRank;
                if ((cardsReceived == 2) && firstCardValue == secondCardValue)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
