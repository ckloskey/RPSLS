using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Human : Player
    {
        public Human()
        {

        }
        public override string SetGesture()
        {
            base.SetGesture();
            Console.WriteLine("Choose Gesture:");
            gestureChosen = Console.ReadLine();
            return gestureChosen;
        }

        public void GestureValidation(string gestureToValidate)
        {
            //create error handler for invalid inputs
            if (allGestures.Contains(gestureChosen, StringComparer.OrdinalIgnoreCase))
            {
                Console.WriteLine("It's all good");
            }
        }
    }
}
