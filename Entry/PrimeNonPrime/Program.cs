namespace PrimeNonPrime
{
    public class Program
    {
        public static void Main()
        {
            int sumPrime = 0;
            int sumNonPrime = 0;

            while (true)
            {
                string userInput = Console.ReadLine()!;

                if (userInput == "stop")
                {
                    Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
                    Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrime}");
                    break;
                }

                int userNum = Convert.ToInt32(userInput);
                bool isPrime = true;

                if (userNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                for (int i = 2; i < userNum; i++)
                {
                    if (userNum % i == 0)
                    {
                        sumNonPrime += userNum;
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sumPrime += userNum;
                }
            }
        }
    }
}
