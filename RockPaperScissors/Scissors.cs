using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Scissors : Gesture
    {
        public Scissors()
        {
            name = "Scissors";
            winsAgainst.Add("Paper");
            winsAgainst.Add("Lizard");
        }
    }
}
