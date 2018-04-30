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
            Console.WriteLine("How many players?");
            numOfPlayers = Console.ReadLine();
            try
            {
                if (numOfPlayers.ToLower() == "one" || numOfPlayers == "1")
                {
                    numOfPlayers = "1";
                }
                else if (numOfPlayers.ToLower() == "two" || numOfPlayers == "2")
                {
                    numOfPlayers = "2";
                }
                else
                {
                    throw new ArgumentException("Please indicate whether '1' or '2' players are playing");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
                RunGame();
                return;
            }
            Player playerOne = new Player();
            Player playerTwo = new Player();
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
                        Console.WriteLine("Player Two chooses: " + cpuGesture);
                        playerTwo = computer;
                        break;
                    case "2":
                        GetUserInput(human, "Player One");
                        playerOne = human;

                        GetUserInput(human2, "Player Two");
                        playerTwo = human2;
                        break;
                    default:
                        return;
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
                ResultsWithVerb(player1Gesture, player2Gesture);
                Console.WriteLine("Player One Wins Round");
            }
            else if (d == 2 || d == 4)
            {
                player2Score++;
                player2.SetScore(player2Score);
                ResultsWithVerb(player1Gesture, player2Gesture);
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

        public void ResultsWithVerb(string firstGesture, string secondGesture)
        {
            if ((firstGesture == "rock" && secondGesture == "scissors") || (firstGesture == "scissors" && secondGesture == "rock"))
            {
                Console.WriteLine("Rock crushes Scissors");
            }
            else if ((firstGesture == "scissors" && secondGesture == "paper") || (firstGesture == "paper" && secondGesture == "scissors"))
            {
                Console.WriteLine("Scissors cuts Paper");
            }
            else if ((firstGesture == "paper" && secondGesture == "rock") || (firstGesture == "rock" && secondGesture == "paper"))
            {
                Console.WriteLine("Paper covers Rock");
            }
            else if ((firstGesture == "rock" && secondGesture == "lizard") || (firstGesture == "lizard" && secondGesture == "rock"))
            {
                Console.WriteLine("Rock crushes Lizard");
            }
            else if ((firstGesture == "lizard" && secondGesture == "spock") || (firstGesture == "spock" && secondGesture == "lizard"))
            {
                Console.WriteLine("Lizard poisons Spock");
            }
            else if ((firstGesture == "spock" && secondGesture == "scissors") || (firstGesture == "scissors" && secondGesture == "spock"))
            {
                Console.WriteLine("Spock smashes Scissors");
            }
            else if ((firstGesture == "scissors" && secondGesture == "lizard") || (firstGesture == "lizard" && secondGesture == "scissors"))
            {
                Console.WriteLine("Scissors decapitates Lizard");
            }
            else if ((firstGesture == "lizard" && secondGesture == "paper") || (firstGesture == "paper" && secondGesture == "lizard"))
            {
                Console.WriteLine("Lizard eats Paper");
            }
            else if ((firstGesture == "rock" && secondGesture == "spock") || (firstGesture == "spock" && secondGesture == "rock"))
            {
                Console.WriteLine("Spock vaporizes Rock");
            }
            else
            {
                Console.WriteLine("Paper disproves Spock");
            }
        }
    }
}
