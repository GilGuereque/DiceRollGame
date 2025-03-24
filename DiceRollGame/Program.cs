var diceNumbers = new RandonNumberGenerator();

//while (userGuess<> diceNumber && userTries <= 3)


class NumberGuesser
{
    public int userTries = 0;
    public string? userGuess { get; private set; }

    public Random random = new Random();

    public int ranNum = 0;
    public NumberGuesser()
    {
        while (userTries < 3)
        {
            Console.WriteLine("Dice rolled. Guess what number it shows in 3 tries.");
            bool v = int.TryParse(Console.ReadLine(), out int userInt);
            ranNum = random.Next(1, 6);
            if (userInt == ranNum)
            {
                Console.WriteLine("You win.");
                break;
            }
            else if (userInt != ranNum);
            {
                Console.WriteLine("Wrong number");
                continue;
            }
            userTries++;
            if (userTries == 3)
            {
                break;
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