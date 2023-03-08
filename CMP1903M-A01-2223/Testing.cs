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
            //test pack initialisation
            Pack pack = new Pack();

            Console.WriteLine("--Shuffles--");

            //testing Fisher-Yates shuffle
            Console.WriteLine("Fisher-Yates shuffle");
            pack.shuffleCardPack(1);

            //testing Riffle shuffle
            Console.WriteLine("Riffle shuffle");
            pack.shuffleCardPack(2);

            //testing no shuffle
            Console.WriteLine("No shuffle");
            pack.shuffleCardPack(3);

            //testing one deal card
            Console.WriteLine("");
            var dealt = pack.deal();
            dealt.Meaning();

            //testing multiple deal cards
            Console.WriteLine("");
            var mDealt = pack.dealCard(4);
            Console.WriteLine();
        }
        
	}
}
