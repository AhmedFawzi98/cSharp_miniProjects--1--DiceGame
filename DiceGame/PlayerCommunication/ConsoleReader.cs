namespace DiceGame.PlayerCommunication;

public static class ConsoleReader
{
    public static int ReadNumber(string message)
    {
        bool isNumber;
        int guessedNumber = 0;
        do
        {
            Console.WriteLine(message);
            isNumber = int.TryParse(Console.ReadLine(), out int number);
            if (!isNumber)
                Console.WriteLine("Incorrect input");
            else
                guessedNumber = number;
        } while (!isNumber);
        return guessedNumber;
    }
}