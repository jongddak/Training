namespace StackandQueue
{
    internal class Program
    {
        public static void IsValid(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char ch in input)
            {
                if (ch == '{' || ch == '[' || ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == '}' || ch == ']' || ch == ')')
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("미완");

                    }

                    char open = stack.Pop();

                    if (!IsMatchingPair(open, ch))
                    {
                        Console.WriteLine("미완");
                    }
                }
            }

            Console.WriteLine("완");
        }

        static bool IsMatchingPair(char open, char close)
        {
            return (open == '{' && close == '}') ||
                   (open == '[' && close == ']') ||
                   (open == '(' && close == ')');
        }

        static int[] CalcWorkDays(int[] workHours)
        {
            int hoursPerDay = 8; // 일 8시간
            int currentDay = 1;
            int remainingHour = hoursPerDay;  // 잔여시간 
            int[] workDays = new int[workHours.Length];

            for (int i = 0; i < workHours.Length; i++)   //
            {
                int hoursLeft = workHours[i];

                while (hoursLeft > 0)
                {
                    if (hoursLeft <= remainingHour)
                    {
                        workDays[i] = currentDay;
                        remainingHour -= hoursLeft;
                        hoursLeft = 0;
                    }
                    else
                    {
                        hoursLeft -= remainingHour;
                        currentDay++;
                        remainingHour = hoursPerDay;
                    }
                }

                if (remainingHour == 0)
                {
                    currentDay++;
                    remainingHour = hoursPerDay;
                }
            }

            return workDays;
        }




        static void Main(string[] args)
        {
            //string str = Console.ReadLine();
            //IsValid(str);



            int[] workHours = { 4, 4, 12, 10, 2, 10 }; // 작업 시간 배열
            int[] workDays = CalcWorkDays(workHours);

            Console.WriteLine("작업 완료 날짜: " + string.Join(", ", workDays)); // 결과 배열 출력
        }
    }
}
