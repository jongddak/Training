namespace Josephus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            LinkedList<int> list = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                list.AddLast(i + 1);
            }
            int count = 0;
            for (int i = 0; i < list.Count; i++)
            {
                count++;
                if (count == k)
                {
                    list
                }
            }
        }
    }
}
