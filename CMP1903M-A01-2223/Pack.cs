using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        public static List<Card> pack = new List<Card>();
        //To split card pack into two
        public static List<Card> packFirst = new List<Card>();
        public static List<Card> packSecond = new List<Card>();
        public Random random;
        //Dealt cards
        public static List<Card> dealtCards = new List<Card>();


        public Pack()
        {
            //Initialise the card pack here
            pack = new List<Card>();
            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 1; value < 14;  value++)
                {
                    pack.Add(new Card(value, suit));
                }
            }
            Random random = new Random();

        }

        public static bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Fisher-Yates Shuffle
            if (typeOfShuffle == 1)
            {
                int n = pack.Length;
                for (int i = 0; i < (n-1); i++)
                {
                    int r = i + random.Next(n-1);
                    Card t = pack[r];
                    pack[r] = pack[i];
                    pack[i] = t;
                }
                return true;
            }

            //Riffle Shuffle
            else if (typeOfShuffle == 2) 
            {
                packFirst.AddRange(pack.GetRange(0, 26));
                packSecond.AddRange(pack.GetRange(26, 26));
                int i = 0;
                int j = 0;
                while (i != 52)
                {
                    pack[i] = packFirst[j];
                    i++;
                    pack[i] = packSecond[j];
                    i++;
                    j++;
                }
                return true;
            }

            //No shuffle
            else if (typeOfShuffle == 3)
            {
                Console.WriteLine("Pack has not been shuffled");
                return true;
            }

            else { return false; } //Exception

        }
        public static Card deal()
        {
            //Deals one card
            dealtCards.Clear();
            if (pack.Length == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }
            else
            {
                Card topCard = pack[0];
                pack.RemoveAt(0);
                dealtCards.Add(topCard);
                return topCard;
            }

        }
        public static List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            dealtCards.clear();
            if (pack.Length == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }
            else if (pack.Length < amount)
            {
                Console.WriteLine($"There are not enough cards in pack to deal {amount} cards");
                return null;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    Card topCard = pack[0];
                    pack.RemoveAt(0);
                    dealtCards.Add(topCard);
                }
                return dealtCards;
            }
        }
    }
}
