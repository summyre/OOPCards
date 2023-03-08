using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
	class Testing
	{
        //test pack initialisation
        Pack pack = new Pack();

        Console.WriteLine("Shuffles");

        //testing Fisher-Yates shuffle
        pack.shuffleCardPack(1);

        //testing Riffle shuffle
        pack.shuffleCardPack(2);

        //testing one deal card
        pack.deal();
        
        //testing multiple deal cards
        pack.dealCard(4);
	}
}
