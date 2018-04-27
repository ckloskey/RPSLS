using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Game
    {
        //runGame method
        //round comparison
        //best of 3 -- round count/score
        //player determines gesture
        //player2/cpu determines gesture
        //gestures must be valid
        //compare gestures
        //score
        //repeat until best of 3

        string numOfPlayers;
        public Game()
        {
            
        }
        public void RunGame()
        {
            Console.WriteLine("How many players?");
           numOfPlayers = Console.ReadLine();

            switch (numOfPlayers)
            {
                case "1":
                    Human player1 = new Human();
                    player1.GestureValidation(player1.SetGesture());
                    CPU player2 = new CPU();
                    Console.WriteLine(player2.SetGesture());
                    Console.ReadKey();
                    break;
                case "2":
                    //player1 = player2 = human
                    break;
            }

        }
    }
}
