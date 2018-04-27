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
            Random random = new Random(); //random instance -- may have to generate first and then pass for more random results
            randomIndex = RandomNumber(random);          //generates random number 
            gestureChosen = ComputerGesture(randomIndex);
            return gestureChosen;
        }
        private static int RandomNumber(Random random)
        {
            int randomGesture;
           return randomGesture = random.Next(5); //change '5' to list length
        }
        private string ComputerGesture(int random)
        {//call list
            //get n'th index of list
            //return as string
            computerGesture = allGestures.ElementAt(random);
            return computerGesture;
        }
    }
}
