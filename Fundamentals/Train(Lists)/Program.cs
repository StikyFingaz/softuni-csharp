namespace TrainLists
{
    public class Program
    {
        public static void Main()
        {
            List<int> trainComposition = Console.ReadLine()!.Split(" ").Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine()!);

            while (true)
            {
                string[] userInput = Console.ReadLine()!.Split();

                if (userInput[0] == "end")
                {
                    Console.WriteLine(string.Join(" ", trainComposition));
                    break;
                }
                else if (userInput[0] == "Add")
                {
                    trainComposition.Add(int.Parse(userInput[1]));
                }
                else
                {
                    for (int i = 0; i < trainComposition.Count; i++)
                    {
                        if (trainComposition[i] + int.Parse(userInput[0]) <= maxCapacity)
                        {
                            trainComposition[i] += int.Parse(userInput[0]);
                            break;
                        }
                    }
                }
            }
        }
    }
}
