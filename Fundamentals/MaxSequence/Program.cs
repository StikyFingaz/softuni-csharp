namespace MaxSequence
{
    public class Program
    {
        public static void Main()
        {
            int[] numbers = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int currentIndex = 0;
            int[] longestStreak = new int[2] { 0, 0 }; // [0, 0] for C# versions 8 and above

            for (int i = 0; i < numbers.Length; i++)
            {
                int count = 0;

                for (int j = currentIndex + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        count += 1;
                    }
                    else
                    {
                        break;
                    }
                }

                if (count > longestStreak[1])
                {
                    longestStreak[0] = currentIndex;
                    longestStreak[1] = count;
                }

                currentIndex += 1;
            }

            int[] streakArray = numbers[
                longestStreak[0]..(longestStreak[0] + longestStreak[1] + 1)
            ];
            Console.Write(string.Join(" ", streakArray));
        }
    }
}
