// Instantiate Dice roll game object
var DiceRollGuesser = new NumberGuesser();
DiceRollGuesser.DiceRoll();

// Pause game before exiting
Console.WriteLine("Game over. Press enter to exit program.");
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
            bool v = int.TryParse(Console.ReadLine(), out int userInt);
            ranNum = random.Next(1, 6);
            if (userInt == ranNum)
            {
                userTries++;
                Console.WriteLine("You win.");
                Console.WriteLine("Press enter to exit program.");
                Console.ReadKey();
                return;
            }
            else if (userInt != ranNum)
            {
                userTries++;
                Console.WriteLine($"Wrong number. The dice roll was {ranNum}. Guess again:");
                //continue;
            }

        }
    }
}

class RandonNumberGenerator
{
    public int? diceNumber { get; private set; }

    Random random = new Random();

    public RandonNumberGenerator()
    {
        diceNumber = random.Next(1, 6);
    }
}