namespace EqualSums
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            bool hasEquals = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                int[] leftSlice = new int[] { 0 };
                int[] rightSlice = new int[] { 0 };

                if (i == 0)
                {
                    leftSlice = new int[] { 0 };
                    rightSlice = numbers[1..^0];
                }
                else if (i == numbers.Length - 1)
                {
                    leftSlice = numbers[0..i];
                    rightSlice = new int[] { 0 };
                }
                else
                {
                    leftSlice = numbers[0..i];
                    rightSlice = numbers[(i + 1)..^0];
                }

                leftSum = leftSlice.Sum();
                rightSum = rightSlice.Sum();

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    hasEquals = true;
                }
            }

            if (!hasEquals)
            {
                Console.WriteLine("no");
            }
        }
    }
}
