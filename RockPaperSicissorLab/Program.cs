using System;

namespace RockPaperSicissorLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            string systemInput;
            int randomNum;
            string Username;
            string js;
            while (true)
            {



                Console.WriteLine("\nWelcome to the Rock Paper Scissors!");
                Console.Write("\nEnter your name: ");
                Username = Console.ReadLine();
                Console.Write("\nWould you like to play the Jets or the Sharks (j/s)?: ");
                js = Console.ReadLine();
                if (js == "j" || js == "s")
                {

                    Console.Write("\nRock, Paper, or scissors? (R/P/S): ");
                    UserInput = Console.ReadLine();
                    Random rnd = new Random();
                    randomNum = rnd.Next(1, 4);

                    switch (randomNum)
                    {
                        case 1:
                            systemInput = "Rock";
                            Console.WriteLine("Computer chose Rock");
                            if (UserInput == "Rock")
                            {
                                Console.WriteLine("Its a draw");
                            }
                            else if (UserInput == "Paper")
                            {
                                Console.WriteLine("You Loose");
                            }
                            else
                            {
                                Console.WriteLine("Winner Winner CHICKEN DINNER");
                            }
                            break;

                        case 2:
                            systemInput = "Paper";
                            Console.WriteLine("You chose Paper.");
                            if (UserInput == "Paper")
                            {
                                Console.WriteLine("Draw");
                            }
                            else if (UserInput == "Rock")
                            {
                                Console.WriteLine("You lose");
                            }
                            else
                            {
                                Console.WriteLine("You Lose");
                            }
                            break;

                        case 3:
                            systemInput = "Scissors";
                            Console.WriteLine("You chose Scissors");
                            if (UserInput == "Scissors")
                            {
                                Console.WriteLine("draw");
                            }
                            else if (UserInput == "Rock")
                            {
                                Console.WriteLine("You lose");
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                            }
                            break;

                        default:

                            Console.WriteLine("Invalid entry!");
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid Option!");
                }
            }

            


        }

    }
}

