using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Computer : Player
    {
        Random ran;
        public Computer(Random ranIn, int compNum)
        {
            ran = ranIn;
            name = "Computer" + compNum;
        }

        public override void ChooseGesture(List<Gesture> gestures)
        {
            int random = ran.Next(gestures.Count());
            gestureChoice = gestures[random];
        }
    }
}
