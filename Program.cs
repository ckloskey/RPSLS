using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Program
    {
        //number of players determined, then gameplay is initiated
        //player(s) chooses -- cpu gets randomized
        
        //game is best of 3
        static void Main(string[] args)
        { 
            Game game = new Game();
            game.RunGame();
        }
    }
}
