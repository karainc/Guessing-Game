// See https://aka.ms/new-console-template for more information
Main();

void Main()
{
        int minNumber = 1;
        int maxNumber = 100;
        int maxGuesses = 0;

        Console.WriteLine("Welcome to the Number Guessing Game!");
        Console.WriteLine("=====================================");
        Console.WriteLine();

        Console.WriteLine("Choose a difficulty level:");
        Console.WriteLine("1. Easy");
        Console.WriteLine("2. Medium");
        Console.WriteLine("3. Hard");
        Console.WriteLine("4. Cheater");

        int difficultyChoice = GetInput("Enter the difficulty level (1-4):", 1, 4);

        switch (difficultyChoice)
        {
            case 1:
                maxGuesses = 8;
                break;
            case 2:
                maxGuesses = 6;
                break;
            case 3:
                maxGuesses = 4;
                break;
             case 4:
                maxGuesses = 100;
                break;
        }

        Console.WriteLine();
        Console.WriteLine("I'm thinking of a number between {0} and {1}.", minNumber, maxNumber);
        Console.WriteLine("You have {0} guesses to find it. Good luck!", maxGuesses);
        Console.WriteLine();

        Random random = new Random();
        int secretNumber = random.Next(minNumber, maxNumber + 1);

        for (int guessCount = 1; guessCount <= maxGuesses; guessCount++)
        {
            Console.Write("Your guess ({0}/{1}): ", guessCount, maxGuesses);
            int userGuess = GetInput();

            if (userGuess == secretNumber)
            {
                Console.WriteLine("Congratulations! You guessed the correct number.");
                return;
            }
            else if (userGuess < secretNumber)
            {
                Console.WriteLine("Too low!");
            }
            else
            {
                Console.WriteLine("Too high!");
            }
        }

        Console.WriteLine("Sorry, you ran out of guesses. The secret number was: {0}", secretNumber);
    }

    static int GetInput(string prompt = "Enter your guess: ", int minValue = int.MinValue, int maxValue = int.MaxValue)
    {
        int input;

        do
        {
            Console.Write(prompt);
        } while (!int.TryParse(Console.ReadLine(), out input) || input < minValue || input > maxValue);

        return input;
    }

