using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Lizard : Gesture
    {
        public Lizard()
        {
            name = "Lizard";
            winsAgainst.Add("Spock");
            winsAgainst.Add("Paper");
        }
    }
}
