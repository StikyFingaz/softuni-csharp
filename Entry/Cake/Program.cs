namespace Cake
{
    public class Porgram
    {
        public static void Main()
        {
            int cakeWidth = int.Parse(Console.ReadLine()!);
            int cakeLength = int.Parse(Console.ReadLine()!);
            int piecesLeft = cakeWidth * cakeLength;

            while (true)
            {
                string piecesTaken = Console.ReadLine()!;

                if (piecesTaken == "STOP")
                {
                    Console.WriteLine($"{piecesLeft} pieces are left.");
                    break;
                }
                else
                {
                    int piecesNumber = int.Parse(piecesTaken);
                    piecesLeft -= piecesNumber;

                    if (piecesLeft <= 0)
                    {
                        Console.WriteLine(
                            $"No more cake left! You need {Math.Abs(piecesLeft)} pieces more."
                        );
                        break;
                    }
                }
            }
        }
    }
}
