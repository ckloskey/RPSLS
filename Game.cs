using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Game
    {
        //round comparison
        //best of 3 -- round count/score
        //gestures must be valid
        //compare gestures
        //score
        //repeat until best of 3

        string numOfPlayers;
        Player playerOne;
        Player playerTwo;
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
                    Human playVsComp1 = new Human();
                    playVsComp1.GestureValidation(playVsComp1.SetGesture());
                    playerOne = playVsComp1;

                    CPU playVsComp2 = new CPU();
                    playerTwo = playVsComp2;
                    Console.WriteLine(playVsComp2.SetGesture());
                    Console.ReadKey();
                    break;
                case "2":
                    Human playerVsplayer1 = new Human();
                    playerVsplayer1.GestureValidation(playerVsplayer1.SetGesture());
                    playerOne = playerVsplayer1;

                    Human playerVsplayer2 = new Human();
                    playerTwo = playerVsplayer2;
                    playerVsplayer2.GestureValidation(playerVsplayer2.SetGesture());
                    break;
            }
            CompareGestures(playerOne, playerTwo);

        }

        public void CompareGestures(Player player1Gesture, Player player2Gesture)
        {
            //get list

            //return index number of string1 and string2
            //if d == 1 or 3 string1 wins
            //if d == 2 or 4 string2 wins
            //if d == 0, tie

            //int d;
            //d = ((5 + player1Gesture - player2Gesture) % 5);
        }
    }
}
