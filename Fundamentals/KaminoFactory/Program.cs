namespace KaminoFactory
{
    public class Program
    {
        public static void Main()
        {
            int seqLength = int.Parse(Console.ReadLine()!);
            int[] bestStreak = new int[] { 0, 0, 0, 0 }; // [input num, start, count, sum]
            int[] bestSample = new int[seqLength];
            int streakCount = 1;

            while (true)
            {
                string input = Console.ReadLine()!;
                int[] currentSeq = new int[seqLength];
                int currentIndex = 0;
                int[] currentStreak = new int[] { streakCount, 0, 0, 0 }; // [input num, start, count, sum]

                if (input == "Clone them!")
                {
                    Console.WriteLine(
                        $"Best DNA sample {bestStreak[0]} with sum: {bestStreak[3]}."
                    );
                    Console.Write(string.Join(" ", bestSample));
                    break;
                }

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] != '!')
                    {
                        currentSeq[currentIndex] = int.Parse(input[i].ToString());
                        currentIndex += 1;
                    }
                }

                currentIndex = 0;
                currentStreak[3] = currentSeq.Sum();

                for (int i = 0; i < currentSeq.Length; i++)
                {
                    int count = 0;

                    for (int j = i + 1; j < currentSeq.Length; j++)
                    {
                        if (currentSeq[i] == currentSeq[j])
                        {
                            count += 1;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count > currentStreak[2])
                    {
                        currentStreak[1] = currentIndex;
                        currentStreak[2] = count;
                    }

                    currentIndex += 1;
                }

                if (currentStreak[2] > bestStreak[2])
                {
                    Array.Copy(currentStreak, bestStreak, 4);
                    Array.Copy(currentSeq, bestSample, seqLength);
                }
                else if (currentStreak[2] == bestStreak[2])
                {
                    if (currentStreak[1] < bestStreak[1])
                    {
                        Array.Copy(currentStreak, bestStreak, 4);
                        Array.Copy(currentSeq, bestSample, seqLength);
                    }
                    else if (currentStreak[1] == bestStreak[1])
                    {
                        if (currentStreak[3] > bestStreak[3])
                        {
                            Array.Copy(currentStreak, bestStreak, 4);
                            Array.Copy(currentSeq, bestSample, seqLength);
                        }
                    }
                }

                streakCount += 1;
            }
        }
    }
}
