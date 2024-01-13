namespace DiceGame.Game
{
    public static class Dice
    {
        private static Random generator;
        private static int _generatedNumber;
        private const int DiceSides = 6;

        static Dice()
        {
            generator = new Random();
        }
        public static int Roll()
        {
            return _generatedNumber = generator.Next(1, DiceSides + 1); //upper bound execlusive
        }

    }
}