using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    
    abstract class Player
    {
        public int score = 0;
        public string name;

        public Gesture gestureChoice;
        public Player()
        {

        }

        public abstract void ChooseGesture(List<Gesture> gestures);

    }
}
