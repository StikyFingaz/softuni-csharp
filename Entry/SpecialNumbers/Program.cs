namespace SpecialNumbers
{
    public class Program
    {
        public static void Main()
        {
            int userNum = int.Parse(Console.ReadLine()!);

            for (int num = 1111; num < 10000; num++)
            {
                bool isMagicNum = true;
                string currentNum = num.ToString();

                for (int i = 0; i < currentNum.Length; i++)
                {
                    int currentIndex = int.Parse(currentNum[i].ToString());

                    if (currentIndex == 0)
                    {
                        isMagicNum = false;
                        break;
                    }
                    else if (userNum % currentIndex != 0)
                    {
                        isMagicNum = false;
                    }
                }

                if (isMagicNum)
                {
                    Console.Write(currentNum + " ");
                }
            }
        }
    }
}
