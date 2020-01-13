using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Paper : Gesture
    {
        public Paper()
        {
            name = "Paper";
            winsAgainst.Add("Rock");
            winsAgainst.Add("Spock");
        }
    }
}
