using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using CardLib;
using System.Threading;
using System.Diagnostics;

namespace BackJack
{
    public delegate void OutPutValueHandler(int box, string value, bool splited = false);
    public delegate void PlayerHandForcedStayHandler();
    public delegate void DisplayOptionsHandler(int box, CardHand playerHand, bool splited = false);
    public delegate void FinishHandHandler();
    public class Dealer
    {
        private Graphics drawing;
        private ShuffleMachine machine;
        private CardHand[] playerHand = new CardHand[10];
        private CardHand dealerHand;
        private int dealTo;
        private CardDrawing cardDrawing;
        private Bet[] playerBet;
        private bool lastBoxFinish;
  
        public event OutPutValueHandler OutPutState;
        public event DisplayOptionsHandler DisplayOptions;
        public event FinishHandHandler FinishHandEvent;
        private Dealer()
        {
        }

        public Dealer(Graphics drawing, ShuffleMachine machine)
        {
            this.drawing = drawing;
            this.machine = machine;
            machine.Start();
            for (int i = 0; i < playerHand.Count(); i++)
            {
                playerHand[i] = new CardHand();
            }
            dealerHand = new CardHand();
            cardDrawing = new CardDrawing(drawing);
            dealTo = 0;
        }

        //initial deal
        public void InitialDeal(Bet[] playerBet)
        {
            this.playerBet = playerBet;
            lastBoxFinish = false;
            bool dealerCardDown = false;
            for (int t = 0; t < 2; t++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (playerBet[i].Playing == true)
                    {
                        //drawMarker(i, "playing");
                        Thread.Sleep(300);
                        Card playerCard = machine.Fetch();
                        cardDrawing.drawCard(playerCard, DrawCardType.Normal, i);
                        countCardValue(playerCard, playerHand[i], i);

                    }
                }
                Thread.Sleep(300);
                if (dealerCardDown == false)
                {
                    Card dealerCard = machine.Fetch();
                    cardDrawing.drawCard(dealerCard, DrawCardType.Normal, 10);
                    countCardValue(dealerCard, dealerHand, 10);     // box 10 is dealer
                    dealerCardDown = true;
                }
            }
            checkTurn();
            
        }
        #region player option implement
        public void Hit(bool splitedAce = false)
        {
            if (splitedAce)
            {
                Card playerCard = machine.Fetch();
                cardDrawing.drawCard(playerCard, DrawCardType.Normal, dealTo);
                countCardValue(playerCard, playerHand[dealTo], dealTo);
            }
            else
            {
                do
                {
                    Card playerCard = machine.Fetch();
                    cardDrawing.drawCard(playerCard, DrawCardType.Normal, dealTo);
                    countCardValue(playerCard, playerHand[dealTo], dealTo);
                }
                while (playerHand[dealTo].TotalCardValue < 12 && playerHand[dealTo].CardsReceived > 2);

                if (playerHand[dealTo].TotalCardValue == 21 || playerHand[dealTo].IsBust == true)
                {
                    Debug.WriteLine("hit stay being called");
                    Stay();
                }
                else
                {
                    //checkTurn();
                    DisplayOptions(dealTo, playerHand[dealTo]);
                }
            }

        }

        public void Stay()
        {
            if ((dealTo == 4 && !playerHand[dealTo].Splited) || dealTo == 9)
                lastBoxFinish = true;

            if (playerHand[dealTo].Splited)
            {
                if (dealTo < 5)
                {
                    dealTo += 5;
                }
                else
                {
                    dealTo -= 4;
                }
            }

            else
            {
                dealTo += 1;             
            }
            if(dealerHand.CardsReceived == 1)
                checkTurn();
            //Debug.WriteLine("dealTo is {0}", dealTo);
            //Debug.WriteLine("playing? {0}", playerBet[dealTo].Playing);
        }

        public void Double()
        {
            Card playerCard = machine.Fetch();
            cardDrawing.drawCard(playerCard, DrawCardType.Double, dealTo);
            playerHand[dealTo].IsDouble = true;
            countCardValue(playerCard, playerHand[dealTo], dealTo);
            //checkTurn();
            Stay();
        }

        public void Split()
        {
            playerBet[dealTo + 5].Playing = true;                  // set box number + 5 = true; which is use for spilt hand;
            playerBet[dealTo + 5].SplitedBet = true;
            playerBet[dealTo + 5].MainBet = playerBet[dealTo].MainBet;
            Card firstCard = playerHand[dealTo].FirstCard.Clone();
            Card secondCard = playerHand[dealTo].SecondCard.Clone();
            playerHand[dealTo] = new CardHand();
            playerHand[dealTo].Splited = true;
            playerHand[dealTo + 5].Splited = true;
            countCardValue(firstCard, playerHand[dealTo], dealTo);
            countCardValue(secondCard, playerHand[dealTo + 5], dealTo + 5);
            cardDrawing.SplitedCard(dealTo, firstCard, secondCard);
            //Debug.WriteLine("{0}--{1}", playerHand[dealTo].TotalCardValue, playerHand[dealTo + 5].TotalCardValue);
            checkTurn();
            
        }
        #endregion
        public void FinishHand()                      
        {
            //Put the used card back to the shuffle machine.
            //This works exactly like skycity casino shuffle machine.
            machine.PutCardBack();
            //reset cards positions and card hand  
            for (int i = 0; i < playerHand.Count(); i++)
            {
                playerHand[i] = new CardHand();
            }

            dealerHand = new CardHand();
            cardDrawing = new CardDrawing(drawing);
            lastBoxFinish = false;
            dealTo = 0;
        }

        public void redraw()
        {
            cardDrawing.RedrawCard();
            //cardDrawing.drawCard(new Card(Suit.Diamond, Rank.Ace), DrawCardType.Double, 4);
        }

        private void dealerGetCards()
        {
            Debug.WriteLine("dealerGetCards being called");
            DisplayOptions(10, dealerHand); //disable options menu
            bool shouldStop = false;
            //if this is deal's first card, check for player state,
            if ((dealerHand.CardsReceived == 1))
            {
                if (isAllBust())   //all player bust, dealer don't need to deal card.
                {
                    shouldStop = true;
                }
                else
                {
                    int numOfBoxPlaying = numOfPlayer(playerBet);
                    int numOfBlackJack = numOfPlayerBJ(playerHand);
                    int numOfBust = numOfPlayerBust(playerHand);
                    //if dealer card not Ace or picture card and only backjack player left
                    if ((dealerHand.TotalCardValue != 11 && dealerHand.TotalCardValue != 10) && ((numOfBlackJack + numOfBust) == numOfBoxPlaying))
                    {
                        shouldStop = true;
                    }
                    //if dealer Ace or picture card and only backJack player left, deal one card
                    else if ((dealerHand.TotalCardValue == 11 || dealerHand.TotalCardValue == 10) && ((numOfBlackJack + numOfBust) == numOfBoxPlaying))
                    {
                        Thread.Sleep(300);
                        Card dealerCard = machine.Fetch();
                        cardDrawing.drawCard(dealerCard, DrawCardType.Normal, 10);
                        countCardValue(dealerCard, dealerHand, 10);
                        shouldStop = true;
                    }
                }
            }
            if (!shouldStop)
            {
                if (!dealerHand.IsBlackJack && !dealerHand.IsBust && (dealerHand.TotalCardValue < 17))
                {
                    do
                    {
                        Thread.Sleep(300);
                        Card dealerCard = machine.Fetch();
                        cardDrawing.drawCard(dealerCard, DrawCardType.Normal, 10);
                        countCardValue(dealerCard, dealerHand, 10);
                    }
                    while (!dealerHand.IsBlackJack && !dealerHand.IsBust && (dealerHand.TotalCardValue < 17));
                }
            }
            payAndTake();           //dealer finish dealing all cards, it's time to calculate result;
        
        }

        private void checkTurn()
        {
            Debug.WriteLine("-------------------");
            Debug.WriteLine("dealTo at checkTurn start is {0}", dealTo);
            Debug.WriteLine("splited is {0}", playerHand[dealTo].Splited);
            Debug.WriteLine("-------------------");
            if (lastBoxFinish)
            {
                dealerGetCards();
            }
            else if (playerHand[dealTo].Splited == false)
            {
                if (dealTo == 5)
                {
                    //DisplayOptions(dealTo, playerHand[dealTo]);
                    dealerGetCards();
                    return;
                }
                else if (dealTo < 5) 
                {
                    while (playerBet[dealTo].Playing == false || playerHand[dealTo].IsBlackJack || playerHand[dealTo].TotalCardValue == 21)
                    {
                        //Debug.WriteLine("inside checkTurn ,dealTo is {0}", dealTo);
                        //Debug.WriteLine("inside checkTurn playing? {0}", playerBet[dealTo].Playing);
                        dealTo++;
                        Debug.WriteLine("inside checkTurn dealTo is {0}", dealTo);
                        if (dealTo == 5)
                        {
                            //DisplayOptions(dealTo, playerHand[dealTo]);
                            dealerGetCards();
                            return;
                        }
                    }
                    DisplayOptions(dealTo, playerHand[dealTo]);
                }
            }
            else //if splited is true
            {
                if (playerHand[dealTo].CardsReceived == 1 && playerHand[dealTo].TotalCardValue == 11) //splied cards are Aces
                {
                    Debug.WriteLine("Ace auto Hit being called and dealTo is {0}", dealTo);
                    Hit(true);
                    Debug.WriteLine("Ace auto Hit finish");
                    Stay();
                    return;
                }
                else if (playerHand[dealTo].CardsReceived == 1 && playerHand[dealTo].TotalCardValue != 11)
                {
                    Debug.WriteLine("NONE Ace auto Hit being called and dealTo is {0}", dealTo);
                    Hit();
                }
                if (dealerHand.CardsReceived == 1) //bug Hot fix 
                {
                    DisplayOptions(dealTo, playerHand[dealTo]);
                }
            }
            Debug.WriteLine("-------------------");
            Debug.WriteLine("dealTo at checkTurn end is {0}", dealTo);
            Debug.WriteLine("-------------------");
        }
            
        private void payAndTake()
        {
            for (int i = 0; i < playerHand.Count(); i++)
            {
                if (playerBet[i].Playing == true)
                {
                    GameResult result = getResult(dealerHand, playerHand[i]);
                    playerBet[i].Result = result;
                    if (i < 5)
                    {
                        OutPutState(i, result.ToString());
                    }
                    else
                    {
                        string state = result.ToString() + " | " + playerBet[i - 5].Result.ToString();
                        OutPutState(i - 5, state);
                    }
                }

            }
            FinishHandEvent();
        }

        private void countCardValue(Card card, CardHand playerHand, int box)
        {
            string state = "";
            int value = (int)card.CardRank;
            playerHand.OnTheGame = true;
            //If this is first card for this player, 
            //Save this card for pair checking
            if (playerHand.CardsReceived < 1)
            {
                playerHand.FirstCard = card.Clone();
            }
            else if (playerHand.CardsReceived == 1)
            {
                playerHand.SecondCard = card.Clone();
            }

            if (value > 10) //All Picture cards count for value 10
            {
                value = 10;
            }

            //Ace can be value 1 or 11 depend on the total value of the hand;
            if (value == 1 && (playerHand.TotalCardValue + 11) <= 21)
            {
                value = 11;
                playerHand.SoftValue = true;
            }

            playerHand.TotalCardValue += value;
            playerHand.CardsReceived += 1;

            if (playerHand.TotalCardValue > 21) //if total greater then 21, bust
            {
                playerHand.IsBust = true;
                playerHand.OnTheGame = false;
            }

            if (playerHand.CardsReceived == 2 && playerHand.TotalCardValue == 21) //first 2 cards 21, this is BlackJack
            {
                if (playerHand.Splited == false)
                {
                    playerHand.IsBlackJack = true;
                }
            }

            // Check the state of the player up to the current card.
            if (playerHand.IsBlackJack == true)
            {
                state = "BJ";
            }
            else if (playerHand.IsBust == true)
            {
                state = "Bust";
            }
            else
            {
                state = playerHand.TotalCardValue.ToString();
            }
            // if this is the second card, check for pair
            if (playerHand.Splited == false)
            {
                if (playerHand.CardsReceived == 2)
                {
                    PairState pairState = checkPair(playerHand.FirstCard, card);
                    if (pairState != PairState.None)
                    {
                        playerHand.Pair = pairState;
                        //state = state + " " + pairState + " Pair";
                    }

                }
            }
            if (box < 5 || box == 10)
            {
                OutPutState(box, state);
            }
            else if (box >= 5 && box < 10)
            {
                if (this.playerHand[box - 5].IsBust)
                    state += " -- " + "BUST";
                else
                state += " -- " + this.playerHand[box - 5].TotalCardValue;
                OutPutState(box - 5, state);
            }
        }

        private PairState checkPair(Card firstCard, Card secondCard)
        {
            if (firstCard.CardRank == secondCard.CardRank)
            {
                if (firstCard.CardSuit == secondCard.CardSuit)
                {
                    return PairState.Perfect;
                }
                else if (
                        (firstCard.CardSuit == Suit.Club) && (secondCard.CardSuit == Suit.Spade)
                        || (firstCard.CardSuit == Suit.Spade) && (secondCard.CardSuit == Suit.Club)
                        || (firstCard.CardSuit == Suit.Heart) && (secondCard.CardSuit == Suit.Diamond)
                        || (firstCard.CardSuit == Suit.Diamond) && (secondCard.CardSuit == Suit.Heart)
                       )
                {
                    return PairState.Color;
                }
                else
                {
                    return PairState.Max;
                }
            }
            else
            {
                return PairState.None;
            }
        }

        private GameResult getResult(CardHand dealerHand, CardHand playerHand)
        {
            GameResult result;
            if (playerHand.IsBust)
            {
                if (dealerHand.IsBlackJack)
                {
                    result = GameResult.LOSTBJ;
                }
                else
                {
                    result = GameResult.LOST;
                }
            }
            else if (dealerHand.IsBust)
            {
                if (playerHand.IsBlackJack)
                {
                    result = GameResult.WINBJ;
                }
                else
                {
                    result = GameResult.WIN;
                }
            }
            else if (dealerHand.IsBlackJack)            //if dealer is BJ
            {
                if (playerHand.IsBlackJack)       // if player is BJ then push
                {
                    result = GameResult.PUSH;
                }
                else
                {
                    result = GameResult.LOSTBJ;
                }
            }
            else if (playerHand.IsBlackJack)
            {
                if (dealerHand.IsBlackJack)
                {
                    result = GameResult.PUSH;
                }
                else
                {
                    result = GameResult.WINBJ;
                }
            }
            else
            {
                if (playerHand.TotalCardValue > dealerHand.TotalCardValue)
                {
                    result = GameResult.WIN;
                }
                else if (playerHand.TotalCardValue < dealerHand.TotalCardValue)
                {
                    result = GameResult.LOST;
                }
                else
                {
                    result = GameResult.PUSH;
                }
            }
            return result;
        }
        #region Player state calculate
        private int numOfPlayer(Bet [] playerBet)
        {
            int num = 0;
            for (int i = 0; i < playerBet.Count(); i++)
            {
                if (playerBet[i].Playing == true)
                    num++;
            }
            return num;
        }
        private int numOfPlayerBJ(CardHand[] players)
        {
            int bj = 0;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].IsBlackJack == true)
                {
                    bj++;
                }
            }
            return bj;
        }
        private int numOfPlayerBust(CardHand[] players)
        {
            int num = 0;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].IsBust == true)
                {
                    num++;
                }
            }
            return num;
        }
        private bool isAllBust()
        {
            return (numOfPlayerBust(playerHand) == numOfPlayer(playerBet));
        }
        #endregion





    }
}
