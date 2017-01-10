using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BackJack
{
    public class Bet
    {
        bool playing;
        bool splitedBet;
        double mainBet;
        double doubleBet;
        GameResult result;

        public Bet()
        {
            playing = false;
            mainBet = 0;
            doubleBet = 0;
        }

        public double MainBet
        {
            get
            {
                return mainBet;
            }
            set
            {
                mainBet = value;
            }
        }
        public double DoubleBet
        {
            get
            {
                return doubleBet;
            }
            set
            {
                doubleBet = value;
            }
        }


        public GameResult Result
        {
            get
            {
                return result;
            }
            set
            {
                result = value;
            }
        }

        public bool Playing
        {
            get
            {
                return playing;
            }
            set
            {
                playing = value;
            }
        }
        public bool SplitedBet
        {
            get
            {
                return splitedBet;
            }
            set
            {
                splitedBet = value;
            }
        }

        public double CalculatePayout()
        {
            double money = 0;
            switch (result)
            {
                case GameResult.WINBJ:
                    money = mainBet * 2.5;
                    break;
                case GameResult.WIN:
                    money = (mainBet + doubleBet) * 2;
                    break;
                case GameResult.PUSH: 
                    money = mainBet + doubleBet;
                    break;
                case GameResult.LOST:
                    money = 0;
                    break;
                case GameResult.LOSTBJ:
                    if (splitedBet)
                    {
                        money = mainBet + doubleBet;
                    }
                    else if (doubleBet > 0)
                    {
                        money = doubleBet;
                    }
                    else
                    {
                        money = 0;
                    }
                    break;
            }

            return money;
        }

        public string ResultText()
        {
            string resultText;
            if (doubleBet != 0)
                resultText = "$" + mainBet.ToString() + "(" + doubleBet.ToString() + ")";
            else
                resultText = "$" + mainBet.ToString();
            switch (result)
            {
                case GameResult.WIN:
                    resultText = resultText + "+" + (mainBet + doubleBet).ToString();
                    break;

                case GameResult.LOST:
                    resultText = resultText + "-" + (mainBet + doubleBet).ToString();
                    break;

                case GameResult.PUSH:
                    resultText = resultText + "+ 0";
                    break;

                case GameResult.WINBJ:
                    resultText = resultText + "+" + ((mainBet + doubleBet) * 1.5).ToString();
                    break;
                case GameResult.LOSTBJ:
                    if (splitedBet)
                    {
                        resultText = resultText + "- 0";
                    }
                    else if (doubleBet > 0)
                    {
                        resultText = resultText + "-" + mainBet.ToString();
                    }
                    else
                    {
                        resultText = resultText + "-" + (mainBet + doubleBet).ToString();
                    }
                    break;
            }
            return resultText;
        }

    }
}
