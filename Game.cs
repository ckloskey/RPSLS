using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSSL
{
    class Game
    {
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
                switch (numOfPlayers)
                {
                    case "1":
                        GetUserInput(human, "Player One");
                        playerOne = human;

                        string randomCpuGesture = computer.GetRandomGesture();
                        computer.SetGesture(randomCpuGesture);
                        string cpuGesture = computer.GetGesture();
                        Console.WriteLine(cpuGesture);
                        playerTwo = computer;
                        break;
                    case "2":
                        GetUserInput(human, "Player One");
                        playerOne = human;

                        GetUserInput(human2, "Player Two");
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
            string player1Gesture = player1.GetGesture().ToLower();
            string player2Gesture = player2.GetGesture().ToLower();
            int a = fullList.IndexOf(player1Gesture);
            int b = fullList.IndexOf(player2Gesture);

            int d;
            d = ((5 + a - b) % 5);
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
                Console.WriteLine("Tie");
            }
        }
        public string GetUserInput(Human human, string whichPlayer)
        {
            bool validInput;
            string userInput;
            do
            {
                Console.WriteLine(whichPlayer + " Choose Gesture:");
                userInput = Console.ReadLine();
                validInput = human.GestureValidation(userInput);
            } while (validInput == false);
            human.SetGesture(userInput);
            return userInput;
        }
    }
}
