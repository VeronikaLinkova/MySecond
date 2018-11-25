using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] Suits = new string[] { "Spades", "Hearts", "Clubs", "Diamonds" };
            string[] CardsValue = new String[13];
            for (int i = 0; i < 9; i++)
            {
                CardsValue[i] = (i + 2).ToString();
            }
            CardsValue[9] = "J";
            CardsValue[10] = "Q";
            CardsValue[11] = "K";
            CardsValue[12] = "A";

            Card[] DeckOfCards = new Card[54];
            int f = 0;
            foreach (string element in Suits)
            {
                foreach (string element2 in CardsValue)
                {
                    DeckOfCards[f] = new Card(element, element2);
                    f++;
                }
            }

            DeckOfCards[52] = new Card("Red", "Joker");
            DeckOfCards[53] = new Card("Black", "Joker");

            
            Random RandomObj = new Random();
            int RandomValue;

            for (f = 0; f < 54; f++)
            {
                RandomValue = RandomObj.Next(53);
                Card c = DeckOfCards[f];
                Card c2 = DeckOfCards[RandomValue];
                DeckOfCards[f] = c2;
                DeckOfCards[RandomValue] = c;
            }

                        
            int y = 0;
            int j = 0;
            Console.WriteLine("Введите количество игроков:");
            int n = Convert.ToInt32(Console.ReadLine());
            Card[][] Mass = new Card[n][];
            while (y<n)
            {
                Card[] Cards = new Card[5];
                for (j=0; j < 5; j++)
                {
                    Card x = DeckOfCards[j+5*y];
                    Cards[j] = DeckOfCards[j + 5 * y]; 
                    Console.WriteLine(x.CardSuit + " " + x.CardValue);

                }
                y++;
                Console.WriteLine();

                Mass[y-1] = Cards;
            }

            for (int i = 0; i < Mass.Length; i++)
            {
                for (int k = 0; k < Mass[i].Length; k++)
                {
                    Card x = Mass[i][k];
                    //Console.Write($"{x.CardSuit + " " + x.CardValue} \t");
                }               
            }

            Console.ReadKey();           

        }        
        
    }
}
