using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class CPU : Player
    {
        public CPU()
        {
            score = 0;
        }
        public string GetRandomGesture()
        {
            Random random = new Random();
            int randomNumber = random.Next(allGestures.Count);
            string randomGesture = allGestures.ElementAt(randomNumber);
            return randomGesture;
        }
    }
}
