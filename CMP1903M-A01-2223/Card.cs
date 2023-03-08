using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        //Base for the Card class.
        //Value: numbers 1 - 13
        //Suit: numbers 1 - 4

        //Fields
        private int mValue; //main value
        private int mSuit;

        //The 'set' methods for these properties could have some validation
        public int Value 
        {
            get { return mValue; } 
            set
            {
                if ((value < 1) || (value > 13))
                {
                    //exception handling
                    throw new ArithmeticException("Value out of range (1-13)");
                }
                else
                {
                    //set the value
                    mValue = value;
                }
            }
        }

        public int Suit 
        { 
            get { return mSuit; }
            set
            {
                if ((value < 1) || (value > 4))
                {
                    //exception handling
                    throw new ArithmeticException("Value out of range (1-4)");
                }
                else
                {
                    //set the value
                    mSuit = value;
                }
            }
        }

        public Card(int value, int suit)
        {
            mValue = value;
            mSuit = suit;
        }

        //What do the values mean?
        public void Meaning()
        {
            var Values = new Dictionary<int, string>()
            {
                {1, "Ace" },
                {2, "Two" },
                {3, "Three" },
                {4, "Four" },
                {5, "Five" },
                {6, "Six" },
                {7, "Seven" },
                {8, "Eight" },
                {9, "Nine" },
                {10, "Ten" },
                {11, "Jack" },
                {12, "Queen" },
                {13, "King" }
            };

            var Suits = new Dictionary<int, string>()
            {
                {1, "Diamonds" },
                {2, "Spades" },
                {3, "Clubs" },
                {4, "Hearts" }
            };
            Console.WriteLine($"{Values[mValue]} of {Suits[mSuit]} ");
        }
    }
}
