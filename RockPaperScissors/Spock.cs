using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Spock : Gesture
    {
        public Spock()
        {
            name = "Spock";
            winsAgainst.Add("Scissors");
            winsAgainst.Add("Rock");
        }

    }
}
