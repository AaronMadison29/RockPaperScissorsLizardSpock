using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();

            Player playerOne;
            Player playerTwo;

            do
            {
                string players = newGame.CheckPlayers();
                (playerOne, playerTwo) = newGame.SetPlayers(players);

                newGame.RunGame(playerOne, playerTwo);

                Console.WriteLine("Would you like to play again?(y/n)");
                string running = Console.ReadLine();
                if(running == "y")
                {
                    Console.Clear();
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);

            
        }
    }
}
