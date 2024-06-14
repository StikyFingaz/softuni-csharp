namespace Coins
{
    public class Program
    {
        public static void Main()
        {
            int[] coinDenoms = [200, 100, 50, 20, 10, 5, 2, 1];
            double amount = double.Parse(Console.ReadLine()!);
            amount *= 100;
            int totalCoins = 0;

            for (int i = 0; i < coinDenoms.Length; i++)
            {
                int currentCoin = coinDenoms[i];

                if (amount / currentCoin > 0)
                {
                    int numberOfCoins = (int)Math.Floor(amount / currentCoin);
                    totalCoins += numberOfCoins;
                    amount -= currentCoin * numberOfCoins;
                }
            }

            Console.WriteLine(totalCoins);
        }
    }
}
