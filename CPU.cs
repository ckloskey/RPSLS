using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class CPU : Player
    {
        string computerGesture;
        int randomIndex;
        public override string SetGesture()
        {
            base.SetGesture();
            Random random = new Random(); //may have to generate first in game class and then pass for more random results
            randomIndex = RandomNumber(random);
            gestureChosen = ComputerGesture(randomIndex);
            return gestureChosen;
        }
        private int RandomNumber(Random random)
        {
            int randomGesture;
           return randomGesture = random.Next(allGestures.Count);
        }
        private string ComputerGesture(int random)
        {
            computerGesture = allGestures.ElementAt(random);
            return computerGesture;
        }
    }
}
