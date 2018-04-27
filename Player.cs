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

        string playerGesturing;
        string gestureChosen;
        List<string> allGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        public Player()
        {

        }

        //member methods
        public virtual string GetGesture()
        {
            Console.WriteLine("Choose Gesture:");
            gestureChosen = Console.ReadLine();
            return gestureChosen;
        }

        public virtual void GestureValidation()
        {
            if (allGestures.Contains(gestureChosen, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's all good");
            }
        }
    }
}
