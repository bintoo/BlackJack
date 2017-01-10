using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CardLib;

namespace testLib
{
    class Program
    {
        static void Main(string[] args)
        {
            string first = "Perfect";
            string second = "perfect";
            if (first != second)
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("no");
            }
            /*ShuffeMachine machine = new ShuffeMachine(6);
            machine.Start();
            //machine.Shuffle();
            Console.WriteLine("Press 'a' for getting card");
            string temp = Console.ReadLine();
            while (temp != "c")
            {
                temp = Console.ReadLine();
                if (temp == "a")
                {
                    Card card = machine.Fetch();
                    int value = (int)card.CardRank;
                    Console.WriteLine("The card is {0}", card.CardName);
                    Console.WriteLine("Card rank is {0}", value);
                    //discard.Add(card);
                    machine.CardLeft();
                }
                if (temp == "p")
                {
                    machine.PutCardBack();
                    //discard.RemoveRange(0, discard.Count);
                    Console.WriteLine("Used cards have been put back to the machine.");
                    machine.CardLeft();
                }
            }
            //machine.PutCardBack(discard);
            //
            //machine.ShowCards();
            

            /*List<int> l= new List<int>();
            l.Add(1);
            l.Add(2);
            l.Add(3);

            l.RemoveAt(0);
            Console.WriteLine("l[0] is {0}", l[0]);*/
            Console.ReadKey();
        }
    }
}
