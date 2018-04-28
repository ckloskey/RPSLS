using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Game
    {
        //gestures must be valid
        string numOfPlayers;

        public Game()
        {
            
        }
        public void RunGame()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Console.WriteLine("How many players?");
            numOfPlayers = Console.ReadLine();
            Human human = new Human();
            CPU computer = new CPU();
            Human human2 = new Human();

            while (playerOne.GetScore() < 2 && playerTwo.GetScore() < 2)
            {
                string userGesture = "";
                switch (numOfPlayers)
                {
                    case "1":
                        Console.WriteLine("Choose Gesture:");
                        userGesture = Console.ReadLine();
                        human.SetGesture(userGesture);
                        human.GestureValidation(human.GetGesture());
                        playerOne = human;

                        string randomCpuGesture = computer.GetRandomGesture();
                        computer.SetGesture(randomCpuGesture);
                        string cpuGesture = computer.GetGesture();
                        Console.WriteLine(cpuGesture);
                        playerTwo = computer;
                        break;
                    case "2":
                        Console.WriteLine("Choose Gesture:");
                        userGesture = Console.ReadLine();
                        human.SetGesture(userGesture);
                        human.GestureValidation(human.GetGesture());
                        playerOne = human;

                        Console.WriteLine("Choose Gesture:");
                        userGesture = Console.ReadLine();
                        human2.SetGesture(userGesture);
                        human2.GestureValidation(human2.GetGesture());
                        playerTwo = human2;
                        break;
                    default:
                        break;
                }
                CompareGestures(playerOne, playerTwo);
                Console.WriteLine("Player One: " + playerOne.GetScore() + " " + "Player Two: " + playerTwo.GetScore());
                Console.ReadKey();
            }
        }

        public void CompareGestures(Player player1, Player player2)
        {
            List<string> fullList = player1.allGestures;
            int player1Score = player1.GetScore();
            int player2Score = player2.GetScore();
            string player1Gesture = player1.GetGesture();
            string player2Gesture = player2.GetGesture();
            int a = fullList.IndexOf(player1Gesture);
            int b = fullList.IndexOf(player2Gesture);

            int d;
            d = ((5 + a - b) % 5);

            //if d == 2 or 4 player1 wins
            if (d == 1 || d == 3)
            {
                player1Score++;
                player1.SetScore(player1Score);
                Console.WriteLine("Player One Wins Round");
            }
            else if (d == 2 || d == 4)
            {
                player2Score++;
                player2.SetScore(player2Score);
                Console.WriteLine("Player Two Wins Round");
            }
            else
            {
                //if d == 0, tie
                Console.WriteLine("Tie");
            }
        }

    }
}
