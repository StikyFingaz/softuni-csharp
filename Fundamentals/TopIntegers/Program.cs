namespace TopIntegers
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                bool isGreater = true;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] < numbers[j])
                    {
                        isGreater = false;
                    }
                }
                if (isGreater)
                {
                    Console.Write(numbers[i] + " ");
                }
            }
            Console.Write(numbers[^1]);
        }
    }
}
