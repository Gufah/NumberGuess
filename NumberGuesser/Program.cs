using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            appInfo(); // shows info about the App

            openingMessage(); 
            
            while (true)
            {
                // Initial correct number
                Random random = new Random();
                int correctNumber = random.Next(1, 10);

                // Initial guessed number
                int guess = 4;

                Console.WriteLine("Guess a number between 1 and 10\n");

                while (guess != correctNumber)
                {
                    // get user unput and JUST INT!
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out guess))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a NUMBER");
                        Console.ResetColor();
                        continue;
                    }
                    guess = Int32.Parse(input);

                    // make sure the number is not greater than 
                    if (guess > 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a NUMBER between 1 to 10");
                    }
                    Console.ResetColor();



                    // is the guess correct?
                    if (guess != correctNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That's not our number \n TRY AGAIN!");
                        Console.ResetColor();
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("RICHTIG");
                Console.ForegroundColor = ConsoleColor.Yellow;

                // Ask user to play again
                Console.WriteLine("Press \"Y\" to play again or \"N\" to end game");
                String input1 = Console.ReadLine().ToUpper();

                if (input1 == "Y")
                {
                    continue;
                }
                return;
            }
        }
        public static void appInfo()
        {
            // set app variables
            string appName = "Guess a Number!";
            string appAuthor = "Gufah";

            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("{0}:\nWritten By {1}\n", appName, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        public static void openingMessage()
        {
            // Ask User's info
            Console.Write("Username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("\nHello {0}, are you ready for the game?\n", userName);
        }
    }
}

