using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class Testing
	{
        public Testing()
        {
            //test pack initialisation - creates a pack object
            Pack pack = new Pack();

            

            //Calling the shuffleCardPack method
            Console.WriteLine("--Shuffles--");
            //Asks for user input of their choice of shuffle
            Console.WriteLine("What shuffle would you like?");
            
            Console.WriteLine("1. Fisher-Yates shuffle 2. Riffle shuffle 3. No shuffle");
            string shuffleType = Console.ReadLine(); // declares variable as a string and sets it as the user's choice
            
            int shuffleChoice; // declares variable as an integer

            try
            {
                shuffleChoice = int.Parse(shuffleType); // sets and changes the users input into an integer

                if (shuffleChoice == 0 || shuffleChoice >= 4)
                {
                    Console.WriteLine("Invalid shuffle type. Deck has not been shuffled");
                }
                else if (shuffleChoice == 1)
                {
                    //Fisher-Yates shuffle
                    Console.WriteLine("Fisher-Yates shuffle");
                    pack.shuffleCardPack(1); //if user inputs choice 1
                }
                else if (shuffleChoice == 2)
                {
                    //Riffle shuffle
                    Console.WriteLine("Riffle shuffle");
                    pack.shuffleCardPack(2); //if user inputs choice 2
                }
                else if (shuffleChoice == 3)
                {
                    //testing no shuffle
                    Console.WriteLine("No shuffle");
                    pack.shuffleCardPack(3); //if user inputs choice 3
                }
            }
            catch (FormatException) //if user input is not an integer
            {
                Console.WriteLine($"{shuffleType} is not an integer. Deck has not been shuffled");
            }

            //calling the dealing methods

            Console.WriteLine("How many cards do you want to deal?"); //user input amount of cards wanted
            try //exception handling
            {
                int dealAmount = Convert.ToInt32(Console.ReadLine());
                if (dealAmount == 0 || dealAmount > 52) //checks if user has inputted an invalid amount
                {
                    Console.WriteLine("Invalid card amount");
                }
                else if (dealAmount == 1)
                {
                    //dealing one card
                    Console.WriteLine("");
                    var dealt = pack.deal(); //sets the variable so that the card can be outputted later
                    dealt.Meaning(); //displays what card has been dealt
                }
                else if (dealAmount == 2 || dealAmount <= 52)
                {
                    //dealing multiple cards
                    Console.WriteLine("");
                    var mDealt = pack.dealCard(dealAmount);
                }
            }
            catch (FormatException) //if user input is not an integer - cannot be converted from string to integer
            {
                Console.WriteLine("That is not an integer");
            }
       
        }
        
	}
}
