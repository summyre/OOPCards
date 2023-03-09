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
                    //add each newly set value and suit as a card into a list
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
                    //swap a random element with the last "unswapped" item in deck
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
                //split the deck into 2 halves
                packFirst.AddRange(pack.GetRange(0, 26));
                packSecond.AddRange(pack.GetRange(26, 26));
                int i = 0;
                int j = 0;
                while (i != 52)
                {
                    //the cards are alternatively interleaved
                    //set element in position i to the first half's element in position j
                    pack[i] = packFirst[j];
                    i++; //increase i by 1
                    //set element in position i to the second half's element in position j
                    pack[i] = packSecond[j];
                    i++; //increase i by 1
                    j++; //increase j by 1
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
            dealtCards.Clear(); //clears the list of dealt cards
            //if the deck has 0 elements and therefore no cards to be dealt
            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }
            else
            {
                Card topCard = pack[0]; //sets the Card object to the first element of the list
                pack.RemoveAt(0); //removes the card from the list
                dealtCards.Add(topCard); //adds the card to a list of dealt cards
                return topCard;
            }

        }
        public List<Card> dealCard(int amount)
        {
            //Deals the number of cards specified by 'amount'
            dealtCards.Clear(); //clears the list of dealt cards
            //if the deck has 0 elements and therefore no cards to be dealt
            if (pack.Count == 0)
            {
                Console.WriteLine("The deck is empty");
                return null;
            }
            //if the deck has less than the amount stated and so has not enough cards to be dealt
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
                    Card topCard = pack[0]; //sets the Card object to the first element of the list
                    pack.RemoveAt(0); //removes the card from the original deck
                    dealtCards.Add(topCard); //adds the card to a list of dealt cards
                    topCard.Meaning(); //displays what card has been dealt
                }

                return dealtCards;
            }
        }
    }
}
