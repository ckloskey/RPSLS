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
        public int score;
        public List<string> allGestures = new List<string>() { "Rock", "Paper", "Scissors", "Spock", "Lizard" };
        public Player()
        {
        }
        //member methods
        public void SetGesture(string setHumanGesture)
        {
            gestureChosen = setHumanGesture;
        }
        public string GetGesture()
        {
            return gestureChosen;
        }

        public void SetScore(int setScore)
        {
            score = setScore;
        }

        public int GetScore()
        {
           return score;
        }
    }
}
