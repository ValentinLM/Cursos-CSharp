// Set up the game
Random random = new();
int secretNumber = random.Next(1, 21);
int maxGuesses = 5;
int guessCount = 0;
bool hasWon = false;

Console.WriteLine("I'm thinking of a number between 1 and 20.");
Console.WriteLine($"You have {maxGuesses} guesses. Good luck!");
// Ask the player to guess

while (guessCount < maxGuesses)
{
    guessCount++;
    Console.Write($"\nGuess #{guessCount}: ");
    bool isValidGuess = int.TryParse(Console.ReadLine(), out int guess);
    if (!isValidGuess)
    {
        Console.WriteLine("Please enter a valid number.");
        guessCount--; // Don't count invalid guesses
        continue;
    }

    int difference = Math.Abs(guess - secretNumber);
    if (difference <= 2 && difference != 0)
    {
        Console.WriteLine("You're very close!");
    }
    else if (difference <= 5 && difference != 0)
    {
        Console.WriteLine("You're close!");
    }

    if (guess == secretNumber)
    {
        Console.WriteLine($"Correct! You got it in {guessCount} guesses.");
        hasWon = true;
        break;
    }
    else if (guess < secretNumber)
    {
        Console.WriteLine("Too low.");
    }
    else
    {
        Console.WriteLine("Too high.");
    }
}

// Check the guess and give feedback
if (!hasWon)
{
    Console.WriteLine($"\nOut of guesses! The number was {secretNumber}.");
}
// Announce the result