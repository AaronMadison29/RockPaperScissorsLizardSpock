using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Human : Player
    {
        

        
        public Human(string name)
        {
            this.name = name;
        }
        public override void ChooseGesture(List<Gesture> gestures)
        {
            do
            {
                Console.WriteLine("\nWhich gesture whould " + name + " like to make?");
                foreach (Gesture gesture in gestures)
                {
                    Console.WriteLine(gesture.name);
                }
                string input = Console.ReadLine();
                Console.WriteLine();
                

                foreach (Gesture gesture in gestures)
                {
                    if (gesture.name == input)
                    {
                        gestureChoice = gesture;
                        break;
                    }
                }
                if(input == "")
                {
                    Console.WriteLine("Please enter a valid option");
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
