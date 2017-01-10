using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CardLib;
using System.Diagnostics;
using System.Threading;

namespace BackJack
{
    public partial class BlackJackForm : Form
    {
        Graphics drawing;
        ShuffleMachine machine;
        Dealer dealer;
        Bet[] playerBet;       // playerBet state
        Point[] playerMenuLocation = new Point[5];
        int numOfPlayer;      //numOfPlayer, if no player, can not start the game
        double money;         
        double betTemp = 0;   
        int BoxBeingSelect = 0;
        int DoubleOrSplitBeingSelect = 0;
        bool isDouble = false;
        private delegate void OutputBoxStateDelegate(int box, string value, bool splited = false);
        private delegate void DisplayOptionsDelegate(int box, CardHand playerHand, bool splited = false);
        private ShuffleType shuffleType = ShuffleType.Machine;
        private int countingValue = 0;
        public BlackJackForm()
        {
            InitializeComponent();
            drawing = pictureBoxTable.CreateGraphics();
            resetTextBoxes();

            machineShuffeToolStripMenuItem.Checked = true;
            playerMenuLocation[0] = new Point(896, 313);
            playerMenuLocation[1] = new Point(728, 436);
            playerMenuLocation[2] = new Point(482, 476);
            playerMenuLocation[3] = new Point(252, 438);
            playerMenuLocation[4] = new Point(105, 331);
            groupBoxOptions.Visible = false;
            groupBoxBid.Visible = false;
            buttonNext.Visible = false;
            countingBox.Visible = false;
            setButtonBoxBidVisible(false);
            setTextBoxBidArea(false);
            resetGameState();           
        }

        private void resetGameState()
        {
           //buttonStart.Visible = false;           
            playerBet = new Bet[10];
            for (int i = 0; i < playerBet.Count(); i++)
            {
                playerBet[i] = new Bet();
            }
            betTemp = 0;
            numOfPlayer = 0;
            BoxBeingSelect = 0;
            DoubleOrSplitBeingSelect = 0;
            isDouble = false;
        }
        private void pictureBoxTable_Paint(object sender, PaintEventArgs e)
        {
            if(dealer != null)
                dealer.redraw();
        }

        private void displayPlayerOptions(int box, CardHand playerHand, bool splited = false)
        {
            this.Invoke(new DisplayOptionsDelegate(DisplayOptions), box, playerHand, splited);
        }

        private void UpdateCardCounting(List<Card> cards, Card cardToFetch)
        {
            var TotalNumberOfCards = (double)cards.Count();
            var TotalNumberOfBigCards = (double)cards.Count(c => (int)c.CardRank >= 10 || (int)c.CardRank == 1);
            var result = Math.Round((TotalNumberOfBigCards/TotalNumberOfCards)*100, 2).ToString() + "%";
            var cardRank = (int) cardToFetch.CardRank;
            if (cardRank >= 2 && cardRank <= 6)
                countingValue++;
            else if (cardRank == 1 || cardRank >= 10)
                countingValue--;
            countingFaceCardbox.Invoke(new Action<string>(resultText => countingFaceCardbox.Text = resultText), result);
            countingCardLeftBox.Invoke(new Action<string>(resultText => countingCardLeftBox.Text = resultText), TotalNumberOfCards.ToString());
            CountingValueBox.Invoke(new Action<string>(resultText => CountingValueBox.Text = resultText), countingValue.ToString());
        }

        private void DisplayOptions(int box, CardHand playerHand, bool splited = false)
        {
            if (box < 10)
            {
                //Debug.WriteLine("playerHand card value is {0}", playerHand.TotalCardValue);
                DoubleOrSplitBeingSelect = box;
                buttonStay.Enabled = !(playerHand.TotalCardValue < 12);
                buttonDouble.Enabled = (playerHand.Doubleable());
                if (splited == false)
                {
                    //buttonSplit.Enabled = (true);
                    buttonSplit.Enabled = (playerHand.Splitable());
                }
                if (box > 4)
                    box -= 5;
                groupBoxOptions.Location = playerMenuLocation[box];
                groupBoxOptions.Visible = true;                
            }
            else
            {
                groupBoxOptions.Visible = false;
            }
        }

        private void DisplayBidOptions(int box)
        {
            if (box > 4)
                box -= 5;
            textBoxBid.Text = betTemp.ToString();
            groupBoxBid.Location = playerMenuLocation[box];
            groupBoxBid.Visible = true;
        }


        private void finishGame()
        {
            string resultText;
            for (int i = 0; i < playerBet.Count(); i++)
            {
                if (playerBet[i].Playing == true)
                {              
                    money += playerBet[i].CalculatePayout();
                    if (i < 5)
                    {
                        resultText = playerBet[i].ResultText();
                        setTextBoxBidAreaText(resultText, i);
                    }
                    else
                    {
                        resultText = playerBet[i].ResultText() + " | " + playerBet[i - 5].ResultText();
                        setTextBoxBidAreaText(resultText, i - 5);

                    }
                    //Debug.WriteLine("i is {0}", i);
                    //Debug.WriteLine("IM here result Text is {0}", resultText);
                }
            }
            textBoxMoney.Text = money.ToString();
            BoxBeingSelect = 0;
            DoubleOrSplitBeingSelect = 0;
            isDouble = false;
            resetGameState();

            if (money == 0)
            {
                MessageBox.Show("GAME OVER");
                Close();
            }
            else
            {
                buttonNext.Visible = true;
            }
        }

        private void resetTextBoxes()
        {
            textBox0.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }


        private void setBoxState(int box, string value, bool splited = false)
        {
            this.Invoke(new OutputBoxStateDelegate(outputBoxState), box, value, splited);
        }
        private void outputBoxState(int box, string value, bool splited = false)
        {
            if (box == 0)
            {
                textBox0.Visible = true;
                textBox0.Text = value;
            }
            else if (box == 1)
            {
                textBox1.Visible = true;
                textBox1.Text = value;
            }
            else if (box == 2)
            {
                textBox2.Visible = true;
                textBox2.Text = value;
            }
            else if (box == 3)
            {
                textBox3.Visible = true;
                textBox3.Text = value;
            }
            else if (box == 4)
            {
                textBox4.Visible = true;
                textBox4.Text = value;
            }
            else if (box == 10)
            {
                textBox5.Visible = true;
                textBox5.Text = value;
            }
        }

        #region Button_Click region
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (numOfPlayer > 0)
            {
                setButtonBoxBidVisible(false);
                //Thread.Sleep(300);
                Thread initialDealThread = new Thread(delegate()
                    {
                        dealer.InitialDeal(playerBet);
                    });
                initialDealThread.Start();
                //dealer.InitialDeal(playerBet);
                buttonStart.Visible = false;

            }
            else
            {
                MessageBox.Show("You must play on at least 1 box");
            }

        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            pictureBoxTable.Refresh();
            dealer.FinishHand();
            for (int i = 1; i <= 6; i++)
            {
                outputBoxState(i, "");
            }
            resetTextBoxes();
            groupBoxOptions.Visible = false;
            buttonStart.Visible = true;
            buttonNext.Visible = false;
            setButtonBoxBidVisible(true);
            setTextBoxBidArea(false);
            //resetGameState();

        }
        private void buttonHit_Click(object sender, EventArgs e)
        {
            dealer.Hit();
        }

        private void buttonStay_Click(object sender, EventArgs e)
        {
            dealer.Stay();
        }

        private void buttonDouble_Click(object sender, EventArgs e)
        {
            isDouble = true;
            betTemp = playerBet[DoubleOrSplitBeingSelect].MainBet;
            DisplayBidOptions(DoubleOrSplitBeingSelect);
            //dealer.Double();
        }

        private void buttonSplit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("This option is not yet implement");
            betTemp = playerBet[DoubleOrSplitBeingSelect].MainBet;
            if (betTemp > money)
            {
                MessageBox.Show("You don't have enough monet to split. Please hit Cancel to continue");
            }
            else
            {
                money -= betTemp;
                textBoxMoney.Text = money.ToString();
                string text = "$" + playerBet[DoubleOrSplitBeingSelect].MainBet + " -- $" + playerBet[DoubleOrSplitBeingSelect].MainBet;
                setTextBoxBidAreaText(text, DoubleOrSplitBeingSelect);
                pictureBoxTable.Refresh();
                dealer.Split();
            }
        }
        private void buttonBox0_Click(object sender, EventArgs e)
        {
            buttonBox0.Visible = false;
            BoxBeingSelect = 0;
            DisplayBidOptions(0);
            setButtonBoxBidVisible(false);
            buttonStart.Visible = false;
        }
        private void buttonBox1_Click(object sender, EventArgs e)
        {
            buttonBox1.Visible = false;
            BoxBeingSelect = 1;
            DisplayBidOptions(1);
            setButtonBoxBidVisible(false);
            buttonStart.Visible = false;
        }
        private void buttonBox2_Click(object sender, EventArgs e)
        {
            buttonBox2.Visible = false;
            BoxBeingSelect = 2;
            DisplayBidOptions(2);
            setButtonBoxBidVisible(false);
            buttonStart.Visible = false;
        }
        private void buttonBox3_Click(object sender, EventArgs e)
        {
            buttonBox3.Visible = false;
            BoxBeingSelect = 3;
            DisplayBidOptions(3);
            setButtonBoxBidVisible(false);
            buttonStart.Visible = false;
        }
        private void buttonBox4_Click(object sender, EventArgs e)
        {
            buttonBox4.Visible = false;
            BoxBeingSelect = 4;
            DisplayBidOptions(4);
            setButtonBoxBidVisible(false);
            buttonStart.Visible = false;
        }

        private void buttonBuyInOK_Click(object sender, EventArgs e)
        {
            try
            {
                money = Convert.ToInt32(textBoxBuyIn.Text);
                if (money < 100)
                    money = 100;
                else if (money > 3000)
                    money = 3000;
                groupBoxBuyIn.Visible = false;
                startToolStripMenuItem.Enabled = false;
                textBoxMoney.Text = money.ToString();
                setButtonBoxBidVisible(true);
                buttonStart.Visible = true;
                if (shuffleType == ShuffleType.Machine)
                    machine = new ShuffleMachine(4, shuffleType);
                else
                {
                    machine = new ShuffleMachine(8, shuffleType);
                    machine.CardCountingEvent += UpdateCardCounting;
                }
                dealer = new Dealer(drawing, machine);
                dealer.OutPutState += new OutPutValueHandler(setBoxState);
                dealer.DisplayOptions += new DisplayOptionsHandler(displayPlayerOptions);
                dealer.FinishHandEvent += new FinishHandHandler(finishGame);
                settingToolStripMenuItem.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Please input a number between 100~3000");
                textBoxBuyIn.Text = "";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            betTemp += 10;
            textBoxBid.Text = betTemp.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            betTemp += 25;
            textBoxBid.Text = betTemp.ToString();
        }

        private void button100_Click(object sender, EventArgs e)
        {
            betTemp += 100;
            textBoxBid.Text = betTemp.ToString();
        }
        private void buttonReset_Click(object sender, EventArgs e)
        {
            betTemp = 0;
            textBoxBid.Text = betTemp.ToString();
        }

        private void buttonBidOk_Click(object sender, EventArgs e)
        {
            if (betTemp != 0)
            {
                if (isDouble == false)
                {
                    if (betTemp > 500)
                        betTemp = 500;
                    if (betTemp > money)
                        betTemp = money;
                    if (betTemp != 0)
                    {

                        playerBet[BoxBeingSelect].MainBet = betTemp;
                        money -= betTemp;
                        numOfPlayer++;
                        setTextBoxBidAreaText("$" + playerBet[BoxBeingSelect].MainBet.ToString(), BoxBeingSelect);
                        textBoxMoney.Text = money.ToString();
                        playerBet[BoxBeingSelect].Playing = true;
                        betTemp = 0;
                        groupBoxBid.Visible = false;
                        setButtonBoxBidVisible(true);
                        setTextBoxBidArea(true, BoxBeingSelect);
                        buttonStart.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("You need minimum $10 to play");
                    }
                }// end if
                else
                {
                    betTemp = (betTemp > money) ? money : betTemp;
                    betTemp = (betTemp > playerBet[DoubleOrSplitBeingSelect].MainBet) ? playerBet[DoubleOrSplitBeingSelect].MainBet : betTemp;
                    if (betTemp != 0)
                    {
                        playerBet[DoubleOrSplitBeingSelect].DoubleBet = betTemp;
                        money -= betTemp;
                        textBoxMoney.Text = money.ToString();
                        groupBoxBid.Visible = false;

                        string text = "$" + playerBet[DoubleOrSplitBeingSelect].MainBet.ToString() + "(" + playerBet[DoubleOrSplitBeingSelect].DoubleBet.ToString() + ")";
                        if (DoubleOrSplitBeingSelect >= 5)
                        {
                            if (playerBet[DoubleOrSplitBeingSelect - 5].DoubleBet > 0)
                                text += "|$" + playerBet[DoubleOrSplitBeingSelect - 5].MainBet.ToString() + "(" + playerBet[DoubleOrSplitBeingSelect - 5].DoubleBet.ToString() + ")";
                            else
                                text += "|$" + playerBet[DoubleOrSplitBeingSelect - 5].MainBet.ToString();
                        }
 
                        setTextBoxBidAreaText(text, DoubleOrSplitBeingSelect);

                        dealer.Double();
                    }
                    else
                    {
                        MessageBox.Show("You don't have any money to double. Please use cancel to continue");
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select amount of money to bid");
            }
        }
        private void buttonBidCancel_Click(object sender, EventArgs e)
        {
            betTemp = 0;
            groupBoxBid.Visible = false;
            if (isDouble != true)
            {
                setButtonBoxBidVisible(true);
                buttonStart.Visible = true;
            }
        }
        #endregion
        #region set text box region
        private void setButtonBoxBidVisible(bool value)
        {
            if (value)
            {
                if (playerBet[0].Playing == false)
                    buttonBox0.Visible = true;
                if (playerBet[1].Playing == false)
                    buttonBox1.Visible = true;
                if (playerBet[2].Playing == false)
                    buttonBox2.Visible = true;
                if (playerBet[3].Playing == false)
                    buttonBox3.Visible = true;
                if (playerBet[4].Playing == false)
                    buttonBox4.Visible = true;
            }
            else
            {
                buttonBox0.Visible = value;
                buttonBox1.Visible = value;
                buttonBox2.Visible = value;
                buttonBox3.Visible = value;
                buttonBox4.Visible = value;
            }
        }
        private void setTextBoxBidArea(bool value, int? boxNum = null)
        {
            if (boxNum == null)
            {
                textBoxBidArea0.Visible = value;
                textBoxBidArea1.Visible = value;
                textBoxBidArea2.Visible = value;
                textBoxBidArea3.Visible = value;
                textBoxBidArea4.Visible = value;
            }
            else if (boxNum == 0)
                textBoxBidArea0.Visible = value;
            else if (boxNum == 1)
                textBoxBidArea1.Visible = value;
            else if (boxNum == 2)
                textBoxBidArea2.Visible = value;
            else if (boxNum == 3)
                textBoxBidArea3.Visible = value;
            else if (boxNum == 4)
                textBoxBidArea4.Visible = value;

        }
        private void setTextBoxBidAreaText(string text, int boxNum)
        {
            if (boxNum >= 5)
                boxNum -= 5;
            //Size boxSize = new Size(text.Length * 9, 21);
            switch (boxNum)
            {
                case 0:
                    //textBoxBidArea0.Size = boxSize;
                    textBoxBidArea0.Invoke(new Action<string>(result => textBoxBidArea0.Text = result), text);
                    break;
                case 1:
                    textBoxBidArea1.Invoke(new Action<string>(result => textBoxBidArea1.Text = result), text);
                    break;
                case 2:
                    textBoxBidArea2.Invoke(new Action<string>(result => textBoxBidArea2.Text = result), text);
                    break;
                case 3:
                    textBoxBidArea3.Invoke(new Action<string>(result => textBoxBidArea3.Text = result), text);
                    break;
                case 4:
                    textBoxBidArea4.Invoke(new Action<string>(result => textBoxBidArea4.Text = result), text);
                    break;
            }
        }
        #endregion

        private void pictureBoxTable_MouseEnter(object sender, EventArgs e)
        {
            if(dealer != null)
                dealer.redraw();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BlackJack beta 0.11 -- Written by Curtis Zhou for study purpose. \n\n"
                             + "This is an almost full functional game except player can only split once for each box. "
                             + "The rule is 100% following Skycity casion in New Zealand. \n\n"
                             + "Perfect Pair and Insurance functions will be supported in the next version. \n\n"
                             + "(This version may still buggy and any feedbacks will be appreciated.)");
                             
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void handShuffeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shuffleType = ShuffleType.Manual;
            machineShuffeToolStripMenuItem.Checked = false;
            countingBox.Visible = true;
        }

        private void machineShuffeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shuffleType = ShuffleType.Machine;
            handShuffeToolStripMenuItem.Checked = false;
            countingBox.Visible = false;
        }



    }
}
