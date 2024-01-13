using DiceGame.PlayerCommunication;
namespace DiceGame.Game;

public static class GuessingGame
{
    private static int _correctNumber;
    private static int Tries = 3;
    static GuessingGame()
    {
        _correctNumber = Dice.Roll();
    }
    static public void play()
    {
        Console.WriteLine("----------------------------------------Let's Play a little game!---------------------------------------\n\n");
        Console.WriteLine($"Dice is rolled. Guess what number it shows in {Tries} tries!\n");

        string message = "please, enter a number: ";

        bool isCorrect = false;
        while (Tries-- != 0 && isCorrect == false)
        {
            int guessedNumber = ConsoleReader.ReadNumber(message);

            if (guessedNumber == _correctNumber)
            {
                Console.WriteLine("!!!!!!! You Win !!!!!!!");
                isCorrect = true;
            }
            else
                Console.WriteLine($"Wrong Number!, you have {Tries} chances left\n");
        }
        if (!isCorrect)
            Console.WriteLine("\n *** you lose :( *** ");
    }
}