using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Sumayyah Mohd Azmi 

namespace CMP1903M_A01_2223
{
    class Pack
    {
        //Initialise the card pack here
        public static List<Card> pack = new List<Card>();
        //To split card pack into two
        public static List<Card> packFirst = new List<Card>();
        public static List<Card> packSecond = new List<Card>();
        public static Random random = new Random();
        //Dealt cards
        public static List<Card> dealtCards = new List<Card>();


        public Pack()
        {
            //For every suit, card values are needed
            for (int suit = 1; suit < 5; suit++)
            {
                for (int value = 1; value < 14;  value++)
                {
                    pack.Add(new Card(value, suit));
                }
            }

        }

        public bool shuffleCardPack(int typeOfShuffle)
        {
            //Shuffles the pack based on the type of shuffle
            //Fisher-Yates Shuffle
            if (typeOfShuffle == 1)
            {
                for (int n = pack.Count -1; n > 0; --n)
                {
                    int k = random.Next(n + 1);
                    var temp = pack[n];
                    pack[n] = pack[k];
                    pack[k] = temp;
                }
                Console.WriteLine("SHUFFLED");
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
                Console.WriteLine("SHUFFLED");
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
        public Card deal()
        {
            //Deals one card
            dealtCards.Clear();
            if (pack.Count == 0)
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
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            dealtCards.Clear();
            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }
            else if (pack.Count < amount)
            {
                Console.WriteLine($"There are not enough cards in pack to deal {amount} cards");
                return null;
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    //removes last card from the pack for the specified amount
                    Card topCard = pack[0];
                    pack.RemoveAt(0);
                    dealtCards.Add(topCard);
                    topCard.Meaning();
                }

                return dealtCards;
            }
        }
    }
}
