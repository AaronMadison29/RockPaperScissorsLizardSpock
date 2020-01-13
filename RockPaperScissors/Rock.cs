using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Rock : Gesture
    {
        public Rock()
        {
            name = "Rock";
            winsAgainst.Add("Scissors");
            winsAgainst.Add("Lizard");
        }
    }
}
