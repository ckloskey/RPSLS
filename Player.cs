using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Player
    {
        //member variables
        public string gestureChosen;
        public List<string> allGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        public Player()
        {

        }
        //member methods
        public virtual string SetGesture() => gestureChosen;

    }
}
