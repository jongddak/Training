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
    

    static void Main(string[] args)
        {
           string str = Console.ReadLine();
            IsValid(str);



        }
    }
}
