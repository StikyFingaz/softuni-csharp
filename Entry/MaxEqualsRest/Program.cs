﻿namespace MaxEqualsRest
{
    public class Program
    {
        public static void Main()
        {
            int inputNums = int.Parse(Console.ReadLine()!);
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < inputNums; i++)
            {
                int num = int.Parse(Console.ReadLine()!);
                sum += num;

                if (num > max)
                {
                    max = num;
                }
            }

            int sumWithoutMax = sum - max;

            if (max == sumWithoutMax)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                int diff = Math.Abs(max - sumWithoutMax);
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {diff}");
            }
        }
    }
}
