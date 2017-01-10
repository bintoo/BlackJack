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
    public class CardDrawing
    {
        private Graphics drawing;
        Point[] originalPlayerPos = new Point[10];
        Point[] playerPos = new Point[10];
        private Point dealerPos = new Point(600, 90);                // initial dealer card position
        private Size cardSize = new Size(65, 85);                   // card size

        private List<CardHistory>[] history = new List<CardHistory>[11];
        private CardDrawing()
        {
        }

        public CardDrawing(Graphics drawing)
        {
            this.drawing = drawing;
            originalPlayerPos[0] = new Point(750, 250);
            originalPlayerPos[1] = new Point(650, 310);
            originalPlayerPos[2] = new Point(474, 340);
            originalPlayerPos[3] = new Point(260, 310);
            originalPlayerPos[4] = new Point(140, 200);
            for (int i = 0; i < history.Count(); i++)
            {
                history[i] = new List<CardHistory>();
            }
            resetPos();
        }
        public void drawCard(Card card, DrawCardType type, int boxNum, bool redraw = false)
        {
            if (redraw == false)
            {
                //Debug.WriteLine("Box Number is {0}", boxNum);
                history[boxNum].Add(new CardHistory(card.Clone(), type, boxNum));
            }
            Rectangle cardPost;
            if (boxNum != 10)
            {
                if (boxNum == 0 || boxNum == 5)
                {
                    if (boxNum == 0)
                    {
                        cardPost = new Rectangle(playerPos[0], cardSize);
                        setNextCardPos(ref playerPos[0]);
                    }
                    else
                    {
                        cardPost = new Rectangle(playerPos[5], cardSize);
                        setNextCardPos(ref playerPos[5]);
                    }
                    if (type == DrawCardType.Normal)
                    {
                        drawing.TranslateTransform(120.0F, 660.0F);
                        drawing.RotateTransform(-50f);
                    }
                    else if (type == DrawCardType.Double)
                    {
                        drawing.TranslateTransform(-10.0F, 250.0F);
                        drawing.RotateTransform(-20f);
                    }
                }
                else if (boxNum == 1 || boxNum == 6)
                {
                    if (boxNum == 1)
                    {
                        cardPost = new Rectangle(playerPos[1], cardSize);
                        setNextCardPos(ref playerPos[1]);
                    }
                    else
                    {
                        cardPost = new Rectangle(playerPos[6], cardSize);
                        setNextCardPos(ref playerPos[6]);
                    }
                    if (type == DrawCardType.Normal)
                    {
                        drawing.TranslateTransform(-50.0F, 120.0F);
                        drawing.RotateTransform(-10f);
                    }
                    else if (type == DrawCardType.Double)
                    {
                        drawing.TranslateTransform(130.0F, -230.0F);
                        drawing.RotateTransform(20f);
                    }
                }
                else if (boxNum == 2 || boxNum == 7)
                {
                    if (boxNum == 2)
                    {
                        cardPost = new Rectangle(playerPos[2], cardSize);
                        setNextCardPos(ref playerPos[2]);
                    }
                    else
                    {
                        cardPost = new Rectangle(playerPos[7], cardSize);
                        setNextCardPos(ref playerPos[7]);
                    }
                    if (type == DrawCardType.Double)
                    {
                        drawing.TranslateTransform(130.0F, -150.0F);
                        drawing.RotateTransform(20f);
                    }
                }
                else if (boxNum == 3 || boxNum == 8)
                {
                    if (boxNum == 3)
                    {
                        cardPost = new Rectangle(playerPos[3], cardSize);
                        setNextCardPos(ref playerPos[3]);
                    }
                    else
                    {
                        cardPost = new Rectangle(playerPos[8], cardSize);
                        setNextCardPos(ref playerPos[8]);
                    }
                    if (type == DrawCardType.Normal)
                    {
                        drawing.TranslateTransform(100.0F, -50.0F);
                        drawing.RotateTransform(10f);
                    }
                    else if (type == DrawCardType.Double)
                    {
                        drawing.TranslateTransform(450.0F, -100.0F);
                        drawing.RotateTransform(60f);
                    }

                }
                else if (boxNum == 4 || boxNum == 9)
                {
                    if (boxNum == 4)
                    {
                        cardPost = new Rectangle(playerPos[4], cardSize);
                        setNextCardPos(ref playerPos[4]);
                    }
                    else
                    {
                        cardPost = new Rectangle(playerPos[9], cardSize);
                        setNextCardPos(ref playerPos[9]);
                    }
                    if (type == DrawCardType.Normal)
                    {
                        drawing.TranslateTransform(200.0F, -60.0F);
                        drawing.RotateTransform(40f);
                    }
                    else if (type == DrawCardType.Double)
                    {
                        drawing.TranslateTransform(360.0F, -20.0F);
                        drawing.RotateTransform(80f);
                    }

                }
                else
                {
                    cardPost = new Rectangle(playerPos[2], cardSize);
                }
            }
            else
            {
                cardPost = new Rectangle(dealerPos, cardSize);
                dealerPos.X -= 70;
            }

            string cardName = card.CardName;
            Pen pen = new Pen(Color.Black, 1);
            drawing.SmoothingMode = SmoothingMode.AntiAlias;
            drawing.DrawImage(ImageRes.GetImage(cardName), cardPost);
            drawing.DrawRectangle(pen, cardPost);
            drawing.ResetTransform();
        }
        private void setNextCardPos(ref Point pos)
        {
            pos.X -= 10;
            pos.Y -= 30;
        }

        private void resetPos()
        {
            for (int i = 0; i < originalPlayerPos.Count(); i++)
            {
                if (originalPlayerPos[i] != null)
                {
                    playerPos[i] = new Point(originalPlayerPos[i].X, originalPlayerPos[i].Y);
                }
            }
            dealerPos = new Point(600, 90);
        }

        public void RedrawCard()
        {
            resetPos();
            for (int i = 0; i < history.Count(); i++)
            {
                if (history[i].Count() > 0)
                {
                    foreach (CardHistory hist in history[i])
                    {
                        drawCard(hist.Card, hist.Type, hist.Box, true);
                    }
                }
            }
        }

        public void SplitedCard(int boxNum, Card firstCard, Card secondCard)
        {
            history[boxNum] = new List<CardHistory>();
            originalPlayerPos[boxNum + 5] = new Point(originalPlayerPos[boxNum].X - 40, originalPlayerPos[boxNum].Y);
            originalPlayerPos[boxNum] = new Point(originalPlayerPos[boxNum].X + 40, originalPlayerPos[boxNum].Y);          
            resetPos();
            drawCard(firstCard, DrawCardType.Normal, boxNum);
            drawCard(secondCard, DrawCardType.Normal, boxNum + 5);
            RedrawCard();
        }

    }
    struct CardHistory
    {
        Card card;
        DrawCardType type;
        int box;

        public CardHistory(Card card, DrawCardType type, int box)
        {
            this.card = card;
            this.type = type;
            this.box = box;
        }

        public Card Card
        {
            get
            {
                return card;
            }
        }

        public DrawCardType Type
        {
            get
            {
                return type;
            }
        }

        public int Box
        {
            get
            {
                return box;
            }
        }
    }
}
