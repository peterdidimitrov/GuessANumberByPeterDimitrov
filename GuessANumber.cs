namespace GuessANumber
{
    using System;

    internal class GuessANumber
    {
        static void Main(string[] args)
        {
            //Initialize "random" to shuffle computer's choice
            Random ramdomNumber = new Random();
            int endNumber = 101;
            int counterWin = 0;
            int computerNumber = ramdomNumber.Next(1, endNumber + counterWin * 100);

            //Initialize "level" to increase later the difficulty
            int level = 1;

            //Initializing the start count of tries
            int counter = 10;

            while (true)
            {
                //Decreasing the tries
                counter--;

                //Displaying the current level:
                Console.Write($"Guess a number Level {level}(1-{100 + counterWin * 100}): ");

                string playerInput = Console.ReadLine();

                //Initializing the variable, which finde if input is true or false
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                //Displaying result
                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        counterWin++;
                        level++;
                        Console.WriteLine("You guessed it!");
                        Console.WriteLine("Do you want to play again?");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        string playersChoice = Console.ReadLine();
                        Console.ResetColor();

                        //The user has to decide to play again or to quit the game
                        if (playersChoice == "Yes" || playersChoice == "yes"
                        || playersChoice == "y" || playersChoice == "Y")
                        {
                            //Restarting the program
                            counter = 10;
                            computerNumber = ramdomNumber.Next(1, endNumber + counterWin * 100);
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else if (playerNumber > computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Too High");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Too Low");
                        Console.ResetColor();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input.");
                    Console.ResetColor();
                }
                if (counter != 0)
                {
                    Console.WriteLine($"You have {counter} more tries.");
                }
                else
                {
                    Console.WriteLine("Sorry, you did not guess the number!");

                    Console.WriteLine("Do you want to play again?");

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string playersChoice = Console.ReadLine();
                    Console.ResetColor();

                    //The user has to decide to play again or to quit the game
                    if (playersChoice == "Yes" || playersChoice == "yes"
                    || playersChoice == "y" || playersChoice == "Y")
                    {
                        //Restarting the program
                        counter = 10;
                        counterWin = 0;
                        level = 1;
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }
    }
}
