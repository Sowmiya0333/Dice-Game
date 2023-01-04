using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dicegame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int opponentRandomNum;
            int playerpoints = 0;
            int opponentpoints = 0;
            Random random = new Random();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("press any key to roll the dice.");
                Console.ReadKey();
                playerRandomNum = random.Next(1, 7);
                Console.WriteLine("you rolled a " + playerRandomNum);
    
                opponentRandomNum = random.Next(1, 7);
                Console.WriteLine("Opponent AI rolled a " + opponentRandomNum);

              

                if (playerRandomNum > opponentRandomNum)
                {
                    playerpoints++;
                    Console.WriteLine("you wins this round");
                }
                else if (playerRandomNum < opponentRandomNum)
                {
                    opponentpoints++;
                    Console.WriteLine("AI wins this round");
                }
                else
                {
                    Console.WriteLine("Draw");
                }
                Console.WriteLine("---------");
                Console.Write("your score is :"+playerRandomNum+ " Opponent score is  " +opponentRandomNum+ ".");
                Console.WriteLine();

            }

            Console.WriteLine("---------");
            Console.WriteLine("---------");
          
              if(playerpoints>opponentpoints)
            {
                Console.WriteLine("you wins ");
            }
            else if(playerpoints<opponentpoints)
            {
                Console.WriteLine("AI wins ");
            }
            else
            {
                Console.WriteLine("Draw");
            }

              Console.ReadKey();
          
        }
        
    }
}
