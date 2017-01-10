using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CardLib
{
    public delegate void CardCountingHandler(List<Card> cards,Card cardTofetch);
    public class ShuffleMachine
    {
        private List<Card> cards = new List<Card>();  //main deck
        private List<Card> usedCards = new List<Card>(); //Cards that have been used
        private List<Card> cardsToFetch = new List<Card>(); //Card that sitting at the port for fetching
        private string machineType;
        private int numOfDecks;
        private ShuffleType shuffleType;
        public event CardCountingHandler CardCountingEvent;

        private ShuffleMachine()
        {
        }

        public ShuffleMachine(int Decks,ShuffleType shuffleType, string type = "BACKJACK")
        {
            this.shuffleType = shuffleType;
            machineType = type;
            if (Decks <= 0)
            {
                numOfDecks = 1;
            }
            else
            {
                numOfDecks = Decks;
            }

            for (int i = 0; i < numOfDecks; i++)
            {
                Deck newDeck = new Deck();
                cards.AddRange(newDeck.GetCards());
            }
        }

        private void transferCards()
        {
            if (cards.Count < 20)
            {
                PutCardBack();
            }
            for (int i = 0; i < 20; i++)
            {
                //Moving 20 cars to the port of the machine and ready for fetch
                cardsToFetch.Add(cards[0].Clone());
                cards.RemoveAt(0);           //cards will be removed from the main deck once they are transfered to the port.              
            }
        }

        private void Shuffle()
        {
            int numOfCards = cards.Count;
 
            List<Card> temp = new List<Card>();
            Random ran = new Random();
            bool[] isDone = new bool[numOfCards];

            //Copy the cards to a temp List
            foreach (Card c in cards)
            {
                temp.Add(c.Clone());
            }

            foreach (Card t in temp)
            {
                int ranNum = ran.Next(0, numOfCards);
                while(isDone[ranNum] == true)
                {
                    ranNum = ran.Next(0, numOfCards);
                }
                cards.RemoveAt(ranNum);
                cards.Insert(ranNum, t.Clone());
                isDone[ranNum] = true;
            }

        }

        public void Start()
        {
            Shuffle();
            if(shuffleType == ShuffleType.Machine)
                transferCards();
        }

        public void PutCardBack()
        {
            if (this.shuffleType == ShuffleType.Machine)
            {
                for (int i = 0; i < usedCards.Count; i++)
                {
                    cards.Add(usedCards[i].Clone());
                }
                //cards.AddRange(usedCards);
                usedCards.RemoveRange(0, usedCards.Count);
                Shuffle();
            }
        }

        public Card Fetch()
        {
            if (shuffleType == ShuffleType.Machine)
            {
                if (cardsToFetch.Count == 0)
                {
                    transferCards();
                }
                Card card = cardsToFetch[0].Clone();
                usedCards.Add(card);
                cardsToFetch.RemoveAt(0);
                return card;
            }
            else
            {
                Card card = cards[0].Clone();
                usedCards.Add(card);
                cards.RemoveAt(0);
                
                if (CardCountingEvent != null)
                    CardCountingEvent(cards,card);
                return card;
            }

        }

        public void ShowCards()
        {
            int i = 0;
            foreach (Card c in cards)
            {
                Console.WriteLine(" ");
                Console.WriteLine(c.CardName);
                i++;
            }

            Console.WriteLine("Total number of cards is {0}", i);
        }

        public void CardLeft()
        {
            Console.WriteLine("Num of card in main is {0}, and num of cards in port is {1}", cards.Count, cardsToFetch.Count);
            Console.WriteLine("Total is {0}", cards.Count + cardsToFetch.Count);
        }

    }
}
