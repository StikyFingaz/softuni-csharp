namespace AnonThreat
{
    public class Program
    {
        public static void Main()
        {
            List<string> secretData = Console.ReadLine()!.Split().ToList();

            while (true)
            {
                string[] userInput = Console.ReadLine()!.Split();

                if (userInput[0] == "3:1")
                {
                    Console.WriteLine(string.Join(" ", secretData));
                    break;
                }
                else if (userInput[0] == "merge")
                {
                    int startIndex = int.Parse(userInput[1]);
                    int stopIndex = int.Parse(userInput[2]);
                    MergeCommand(secretData, startIndex, stopIndex);
                }
                else
                {
                    int divisionIndex = int.Parse(userInput[1]);
                    int partitions = int.Parse(userInput[2]);
                    DivideCommand(secretData, divisionIndex, partitions);
                }
            }
        }

        public static void MergeCommand(List<string> dataList, int start, int stop)
        {
            if (start + 1 >= dataList.Count)
            {
                // No action is taken
            }
            else if (stop >= dataList.Count)
            {
                for (int i = start; i < dataList.Count - 1; i++)
                {
                    dataList[start] += dataList[i + 1];
                }
                dataList.RemoveRange(start + 1, dataList.Count - (start + 1));
            }
            else
            {
                for (int i = start; i < stop; i++)
                {
                    dataList[start] += dataList[i + 1];
                }
                dataList.RemoveRange(start + 1, stop - start);
            }
        }

        public static void DivideCommand(List<string> dataList, int divisionIndex, int partitions)
        {
            List<string> leftSlice = dataList[..divisionIndex];
            string partToDivide = dataList[divisionIndex];
            List<string> midSlice = new();
            List<string> rightSlice = dataList[(divisionIndex + 1)..];
            int partitionLen = partToDivide.Length / partitions;
            int hasEqualParts = partToDivide.Length % partitions;

            if (partitions >= partToDivide.Length)
            {
                // No action is taken
            }
            else if (hasEqualParts != 0)
            {
                for (int i = 0; i < partToDivide.Length - hasEqualParts; i += partitionLen)
                {
                    midSlice.Add(partToDivide[i..(i + partitionLen)]);
                }
            }
            else
            {
                for (int i = 0; i < partToDivide.Length; i += partitionLen)
                {
                    midSlice.Add(partToDivide[i..(i + partitionLen)]);
                }
            }

            if (partitions < partToDivide.Length)
            {
                dataList.Clear();
                dataList.AddRange(leftSlice);
                dataList.AddRange(midSlice);
                dataList.AddRange(rightSlice);
            }
        }
    }
}
