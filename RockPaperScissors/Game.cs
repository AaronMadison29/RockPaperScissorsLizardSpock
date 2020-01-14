using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Game
    {
        List<Gesture> gestureList = new List<Gesture>();
        public Game()
        {
            Gesture rock = new Rock();
            Gesture paper = new Paper();
            Gesture scissors = new Scissors();
            Gesture lizard = new Lizard();
            Gesture spock = new Spock();


            gestureList.Add(rock);
            gestureList.Add(paper);
            gestureList.Add(scissors);
            gestureList.Add(lizard);
            gestureList.Add(spock);

        }

        public string CheckPlayers()
        {
            Console.WriteLine("How many players?: ");
            string players = Console.ReadLine();
            if(players == "0" || players == "1" || players == "2")
            {
                return players;
            }
            else
            {
                Console.WriteLine("Please enter a valid option");
                return CheckPlayers();
            }
        }

        public (Player, Player) SetPlayers(string players)
        {
            while (true)
            {
                

                if (players == "2")
                {
                    Console.WriteLine("What is player one's name?");
                    string playerName = Console.ReadLine();
                    Player playerOne = new Human(playerName);
                    Console.WriteLine("What is player two's name?");
                    playerName = Console.ReadLine();
                    Player playerTwo = new Human(playerName);
                    return (playerOne, playerTwo);
                }
                else if (players == "1")
                {
                    Random ran = new Random();
                    Console.WriteLine("What is your name?");
                    string playerName = Console.ReadLine();
                    Player playerOne = new Human(playerName);
                    Player playerTwo = new Computer(ran, 1);
                    return (playerOne, playerTwo);
                }
                else if (players == "0")
                {
                    Random ran = new Random();
                    
                    Player playerOne = new Computer(ran, 1);
                    Player playerTwo = new Computer(ran, 2);
                    Console.WriteLine();
                    return (playerOne, playerTwo);
                }
            }
        }

        public Player CheckWinner(Player playerOne, Player playerTwo)
        {
            if(playerOne.gestureChoice == playerTwo.gestureChoice)
            {
                return null;
            }
            else if(playerOne.gestureChoice.winsAgainst.Contains(playerTwo.gestureChoice.name))
            {
                Console.Clear();
                Console.WriteLine(playerOne.name + "(" + playerOne.gestureChoice.name + ")" + " beat " + playerTwo.name + "(" + playerTwo.gestureChoice.name + ")");
                playerOne.score++;
                return playerOne;
            }
            else
            {
                Console.Clear();
                Console.WriteLine(playerTwo.name + "(" + playerTwo.gestureChoice.name + ")" + " beat " + playerOne.name + "(" + playerOne.gestureChoice.name + ")");
                playerTwo.score++;
                return playerTwo;
            }
        }

        public void RunGame(Player playerOne, Player playerTwo)
        {
            Player winner;
            do
            {
                Console.Clear();
                Console.Write("Score: " + playerOne.name + ": " + playerOne.score);
                Console.WriteLine(" " + playerTwo.name + ": " + playerTwo.score);
                playerOne.ChooseGesture(gestureList);

                Console.Clear();
                Console.Write("Score: " + playerOne.name + ": " + playerOne.score);
                Console.WriteLine(" " + playerTwo.name + ": " + playerTwo.score);
                playerTwo.ChooseGesture(gestureList);

                winner = CheckWinner(playerOne, playerTwo);

                if (winner is null)
                {
                    Console.WriteLine(playerTwo.name + "(" + playerTwo.gestureChoice.name + ")" + " tied " + playerOne.name + "(" + playerOne.gestureChoice.name + ")\n");
                    Console.WriteLine("Press enter to start next round.");
                    Console.ReadLine();
                }
                else if (winner.score == 2)
                {
                    Console.WriteLine("\n" + winner.name + " is the winner!\n");
                    break;
                }
                else
                {
                    Console.WriteLine("Press enter to start next round.");
                    Console.ReadLine();
                    continue;
                }
            } while (true);
        }
    }
}
