namespace ExamTimes
{
    public class Program
    {
        public static void Main()
        {
            int examHour = int.Parse(Console.ReadLine()!);
            int examMinute = int.Parse(Console.ReadLine()!);
            int arrivalHour = int.Parse(Console.ReadLine()!);
            int arrivalMinute = int.Parse(Console.ReadLine()!);

            int examTime = examHour * 60 + examMinute;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int timeDiff = examTime - arrivalTime;
            string timeDiffTime = ConvertToTime(timeDiff);

            if (timeDiff < 0)
            {
                Console.WriteLine("Late");
                Console.WriteLine($"{timeDiffTime} after the start");
            }
            else if (timeDiff == 0)
            {
                Console.WriteLine("On time");
            }
            else if (timeDiff > 0 && timeDiff <= 30)
            {
                Console.WriteLine("On time");
                Console.WriteLine($"{timeDiffTime} before the start");
            }
            else
            {
                Console.WriteLine("Early");
                Console.WriteLine($"{timeDiffTime} before the start");
            }
        }

        public static string ConvertToTime(int timeDiff)
        {
            timeDiff = Math.Abs(timeDiff);

            if (timeDiff < 60)
            {
                string time = $"{timeDiff} minutes";
                return time;
            }
            else
            {
                int hours = timeDiff / 60;
                int minutes = timeDiff - hours * 60;

                string time = $"{hours}:{minutes:D2} hours";
                return time;
            }
        }
    }
}
