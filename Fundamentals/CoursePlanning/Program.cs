namespace CoursePlanning
{
    public class Program
    {
        public static void Main()
        {
            List<string> coursePlan = Console.ReadLine()!.Split(", ").ToList();

            while (true)
            {
                string[] userInput = Console.ReadLine()!.Split(":").ToArray();

                if (userInput[0] == "Add")
                {
                    string title = userInput[1];
                    AddCommand(coursePlan, title);
                }
                else if (userInput[0] == "Insert")
                {
                    string lessonTitle = userInput[1];
                    int lessonIndex = int.Parse(userInput[2]);
                    InsertCommand(coursePlan, lessonIndex, lessonTitle);
                }
                else if (userInput[0] == "Remove")
                {
                    string lessonTitle = userInput[1];
                    RemoveCommand(coursePlan, lessonTitle);
                }
                else if (userInput[0] == "Swap")
                {
                    string lessonOne = userInput[1];
                    string lessonTwo = userInput[2];
                    SwapCommand(coursePlan, lessonOne, lessonTwo);
                }
                else if (userInput[0] == "Exercise")
                {
                    string lessonTitle = userInput[1];
                    ExerciseCommand(coursePlan, lessonTitle);
                }
                else
                {
                    int lessonCount = 1;

                    for (int i = 0; i < coursePlan.Count; i++)
                    {
                        Console.WriteLine($"{lessonCount}.{coursePlan[i]}");
                        lessonCount += 1;
                    }

                    break;
                }
            }
        }

        public static void AddCommand(List<string> coursePlan, string lessonTitle)
        {
            if (!coursePlan.Contains(lessonTitle))
            {
                coursePlan.Add(lessonTitle);
            }
        }

        public static void InsertCommand(
            List<string> coursePlan,
            int lessonIndex,
            string lessonTitle
        )
        {
            if (!coursePlan.Contains(lessonTitle) && lessonIndex < coursePlan.Count)
            {
                coursePlan.Insert(lessonIndex, lessonTitle);
            }
        }

        public static void RemoveCommand(List<string> coursePlan, string lessonTitle)
        {
            coursePlan.Remove(lessonTitle);
        }

        public static void SwapCommand(List<string> coursePlan, string lessonOne, string lessonTwo)
        {
            if (coursePlan.Contains(lessonOne) && coursePlan.Contains(lessonTwo))
            {
                int indexLessonOne = coursePlan.IndexOf(lessonOne);
                int indexLessonTwo = coursePlan.IndexOf(lessonTwo);

                if (indexLessonOne != -1 && indexLessonTwo != -1)
                {
                    // Best practice (alternative) way of swapping elements in a List/Array
                    // Source ChatGPT
                    // (coursePlan[indexLessonOne], coursePlan[indexLessonTwo]) = (
                    //     coursePlan[indexLessonTwo],
                    //     coursePlan[indexLessonOne]
                    // );

                    coursePlan.Insert(indexLessonOne, lessonTwo);
                    coursePlan.RemoveAt(indexLessonOne + 1);
                    coursePlan.Insert(indexLessonTwo, lessonOne);
                    coursePlan.RemoveAt(indexLessonTwo + 1);
                }

                if (coursePlan.Contains($"{lessonOne}-Exercise"))
                {
                    coursePlan.Remove($"{lessonOne}-Exercise");
                    coursePlan.Insert(indexLessonTwo + 1, $"{lessonOne}-Exercise");
                }

                if (coursePlan.Contains($"{lessonTwo}-Exercise"))
                {
                    coursePlan.Remove($"{lessonTwo}-Exercise");
                    coursePlan.Insert(indexLessonOne + 1, $"{lessonTwo}-Exercise");
                }
            }
        }

        public static void ExerciseCommand(List<string> coursePlan, string lessonTitle)
        {
            int indexLessonTitle = coursePlan.IndexOf(lessonTitle);

            if (indexLessonTitle != -1 && !coursePlan.Contains($"{lessonTitle}-Exercise"))
            {
                coursePlan.Insert(indexLessonTitle + 1, $"{lessonTitle}-Exercise");
            }
            else
            {
                coursePlan.Add(lessonTitle);
                coursePlan.Add($"{lessonTitle}-Exercise");
            }
        }
    }
}
