using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Player
    {
        public string gestureChosen;
        public int score;
        public List<string> allGestures = new List<string>() { "rock", "paper", "scissors", "spock", "lizard" };
        public Player()
        {
        }
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
