namespace Ladybugs
{
    public class Program
    {
        public static void Main()
        {
            int fieldLength = int.Parse(Console.ReadLine()!);
            int[] initialPositions = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();
            int[] currentField = new int[fieldLength];

            for (int i = 0; i < initialPositions.Length; i++)
            {
                if (initialPositions[i] < fieldLength)
                {
                    currentField[initialPositions[i]] = 1;
                }
            }

            while (true)
            {
                string input = Console.ReadLine()!;

                if (input == "end")
                {
                    Console.Write(string.Join(" ", currentField));
                    break;
                }
                else
                {
                    string[] currentCommand = input.Split(" ");
                    int startIndex = int.Parse(currentCommand[0]);
                    string direction = currentCommand[1];
                    int stopIndex = int.Parse(currentCommand[2]);

                    try
                    {
                        int ladyBugIndex = currentField[startIndex];
                        if (ladyBugIndex == 0)
                        {
                            continue;
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }

                    currentField[startIndex] = 0;

                    try
                    {
                        if (direction == "right")
                        {
                            for (
                                int i = startIndex + stopIndex;
                                i < currentField.Length;
                                i += stopIndex
                            )
                            {
                                if (currentField[i] != 1)
                                {
                                    currentField[i] = 1;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            for (int i = startIndex - stopIndex; i >= 0; i -= stopIndex)
                            {
                                if (currentField[i] != 1)
                                {
                                    currentField[i] = 1;
                                    break;
                                }
                            }
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue;
                    }

                    Console.Write(string.Join(" ", currentField));
                }
            }
        }
    }
}
