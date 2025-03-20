
var diceNumbers = new RandonNumberGenerator();

//while (userGuess <> diceNumber && userTries <= 3)


class RandonNumberGenerator
{
    public int diceNumber { get; private set; }
    public int userGuess { get; private set; }

    Random random = new Random();

    public RandonNumberGenerator()
    {
        diceNumber = random.Next(1, 6);
    }
}