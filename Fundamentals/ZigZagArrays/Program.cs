namespace ZigZagArrays
{
    public class Program
    {
        public static void Main()
        {
            int arrayLength = int.Parse(Console.ReadLine()!);
            int[] firstArray = new int[arrayLength];
            int[] secondArray = new int[arrayLength];

            for (int i = 1; i < arrayLength + 1; i++)
            {
                bool isOdd = true;
                if (i % 2 == 0)
                {
                    isOdd = false;
                }

                string[] currentNums = Console.ReadLine()!.Split(" ");
                if (isOdd)
                {
                    firstArray[i - 1] = int.Parse(currentNums[0]);
                    secondArray[i - 1] = int.Parse(currentNums[1]);
                }
                else
                {
                    firstArray[i - 1] = int.Parse(currentNums[1]);
                    secondArray[i - 1] = int.Parse(currentNums[0]);
                }
            }

            Console.Write(string.Join(" ", firstArray));
            Console.WriteLine();
            Console.Write(string.Join(" ", secondArray));
        }
    }
}
