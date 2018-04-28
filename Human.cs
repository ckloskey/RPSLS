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
            score = 0;
        }
        public bool GestureValidation(string gestureToValidate)
        {
            //create error handler for invalid inputs
            if (allGestures.Contains(gestureToValidate, StringComparer.OrdinalIgnoreCase))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
