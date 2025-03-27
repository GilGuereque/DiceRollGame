// Instantiate Dice roll game object
var DiceRollGuesser = new NumberGuesser();
DiceRollGuesser.DiceRoll();

// Pause game before exiting
Console.WriteLine("\nSorry, your three tries are up. Game over. Press enter to exit program.");
Console.ReadKey();


class NumberGuesser
{
    public int userTries = 0;
    //public string? userGuess { get; private set; }

    public Random random = new Random();

    public int ranNum = 0;
    public void DiceRoll()
    {
        while (userTries < 3)
        {
            Console.WriteLine("\nDice rolled. Guess what number it shows in 3 tries. (Number must be from 1 to 6).");
            bool validInput = int.TryParse(Console.ReadLine(), out int userInt);
            ranNum = random.Next(1, 7);

            // Validate the user input and ensure it is a numerical value between 1 & 6
            if (!validInput || userInt < 1 ||  userInt > 6)
            {
                Console.WriteLine("Sorry, please enter a valid number between 1 & 6. Try again.");
                continue; // Skip to the next iteration if parsing fails or the value is out of range
            }

            // Check the users guess against the random number generated
            if (userInt == ranNum)
            {
                userTries++;
                Console.WriteLine("\nYou win.");
                Console.WriteLine("Press enter to exit game.");
                Console.ReadKey();
                return; // End the method if the user wins
            }
            else if (userInt != ranNum)
            {
                userTries++;
                Console.WriteLine($"\nWrong number. The dice rolled was {ranNum}.");
            }

        }
    }
}

// Not neccessary
class RandonNumberGenerator
{
    public int? diceNumber { get; private set; }

    Random random = new Random();

    public RandonNumberGenerator()
    {
        diceNumber = random.Next(1, 6);
    }
}


// Alternative Solution
var random = new Random();
var dice = new Dice(random);
var guessingGame = new GuessingGame(dice);

bool xxx= guessingGame.Play();
//var diceRollResult = random.Next(1, 7);
//Console.WriteLine(diceRollResult);

Console.ReadKey();

class GuessingGame
{
    private readonly Dice _dice;
    private const int InitialTries = 3;

    public GuessingGame(Dice dice)
    {
        _dice = dice;
    }

    public bool Play()
    { 
        var diceRollResult = _dice.Roll();
        Console.WriteLine(
            $"Dice rolled. Guess what number it shows in {InitialTries} tries.");

        var triesLeft = InitialTries;
        while(triesLeft > 0)
        {
            var guess = ConsoleReader.ReadInteger("Enter a number:");
            if (guess == diceRollResult)
            {
                return true;
            }
            Console.WriteLine("Wrong number.");
            --triesLeft;
        }
        return false;
    }
}

public static class ConsoleReader
{
    public static int ReadInteger(string message)
    {
        int result;
        do
        {
            Console.WriteLine(message);
        }
        while (!int.TryParse(Console.ReadLine(), out result));
        return result;
    }
}

public class Dice
{

    private Random _random = new Random();

    private const int SidesCount = 6; // to account for different sided die

public Dice(Random random)
{
    _random = random;
}

public int Roll()
{
    return _random.Next(1, SidesCount + 1);
}

public void Describe() =>
    Console.WriteLine($"This is a dice with 6 sides");
}