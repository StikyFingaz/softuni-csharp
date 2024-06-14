namespace ArrayManipulator
{
    public class Program
    {
        public static void Main()
        {
            int[] currentArray = Console.ReadLine()!.Split(" ").Select(int.Parse).ToArray();

            while (true)
            {
                string[] manipulationCommands = Console.ReadLine()!.Split(" ");

                if (manipulationCommands[0] == "end")
                {
                    Console.WriteLine("[" + string.Join(", ", currentArray) + "]");
                    break;
                }
                else
                {
                    if (manipulationCommands[0] == "exchange")
                    {
                        currentArray = IndexExchage(
                            int.Parse(manipulationCommands[1]),
                            currentArray
                        );
                    }
                    else if (manipulationCommands[0] == "max" || manipulationCommands[0] == "min")
                    {
                        MinMaxOddEven(manipulationCommands, currentArray);
                    }
                    else
                    {
                        FirstEvenOdd(manipulationCommands, currentArray);
                    }
                }
            }
        }

        public static int[] IndexExchage(int indexNumber, int[] numArray)
        {
            int[] exchangedArray = numArray;
            if (indexNumber < 0 || indexNumber >= numArray.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int[] leftSlice = numArray[..(indexNumber + 1)];
                int[] rightSlice = numArray[(indexNumber + 1)..];
                exchangedArray = rightSlice.Concat(leftSlice).ToArray();
            }

            return exchangedArray;
        }

        public static void MinMaxOddEven(string[] args, int[] numArray)
        {
            int[] evensArray = numArray.Where(n => n % 2 == 0).ToArray();
            int[] oddsArray = numArray.Where(n => n % 2 != 0).ToArray();

            if (args[0] == "max")
            {
                if (args[1] == "even" && evensArray.Length >= 1)
                {
                    int maxEven = evensArray.Max();

                    for (int i = numArray.Length - 1; i >= 0; i--)
                    {
                        if (numArray[i] == maxEven)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                else if (args[1] == "odd" && oddsArray.Length >= 1)
                {
                    int maxOdd = oddsArray.Max();

                    for (int i = numArray.Length - 1; i >= 0; i--)
                    {
                        if (numArray[i] == maxOdd)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else
            {
                if (args[1] == "even" && evensArray.Length >= 1)
                {
                    int maxEven = evensArray.Min();

                    for (int i = numArray.Length - 1; i >= 0; i--)
                    {
                        if (numArray[i] == maxEven)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                else if (args[1] == "odd" && oddsArray.Length >= 1)
                {
                    int maxOdd = oddsArray.Min();

                    for (int i = numArray.Length - 1; i >= 0; i--)
                    {
                        if (numArray[i] == maxOdd)
                        {
                            Console.WriteLine(i);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        public static void FirstEvenOdd(string[] args, int[] numArray)
        {
            int[] evensArray = numArray.Where(n => n % 2 == 0).ToArray();
            int[] oddsArray = numArray.Where(n => n % 2 != 0).ToArray();
            int numsToDisplay = int.Parse(args[1]);

            if (numsToDisplay > numArray.Length)
            {
                Console.WriteLine("Invalid count");
            }
            else if (args[2] == "even" && evensArray.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else if (args[2] == "odd" && oddsArray.Length == 0)
            {
                Console.WriteLine("[]");
            }
            else if (args[0] == "first")
            {
                if (args[2] == "even")
                {
                    if (numsToDisplay + 1 >= evensArray.Length)
                    {
                        Console.WriteLine("[" + string.Join(", ", evensArray) + "]");
                    }
                    else
                    {
                        Console.WriteLine(
                            "[" + string.Join(", ", evensArray[..numsToDisplay]) + "]"
                        );
                    }
                }
                else
                {
                    if (numsToDisplay + 1 >= oddsArray.Length)
                    {
                        Console.WriteLine("[" + string.Join(", ", oddsArray) + "]");
                    }
                    else
                    {
                        Console.WriteLine(
                            "[" + string.Join(", ", oddsArray[..numsToDisplay]) + "]"
                        );
                    }
                }
            }
            else
            {
                if (args[2] == "even")
                {
                    if (numsToDisplay + 1 >= evensArray.Length)
                    {
                        Console.WriteLine("[" + string.Join(", ", evensArray) + "]");
                    }
                    else
                    {
                        Console.WriteLine(
                            "[" + string.Join(", ", evensArray[numsToDisplay..]) + "]"
                        );
                    }
                }
                else
                {
                    if (numsToDisplay + 1 >= oddsArray.Length)
                    {
                        Console.WriteLine("[" + string.Join(", ", oddsArray) + "]");
                    }
                    else
                    {
                        Console.WriteLine(
                            "[" + string.Join(", ", oddsArray[numsToDisplay..]) + "]"
                        );
                    }
                }
            }
        }
    }
}
