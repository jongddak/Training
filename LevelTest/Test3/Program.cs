namespace Test3
{
    internal class Program
    {
        //배열에서 중복숫자 제거해서 리턴 ,원본 배열의 숫자 순서는 유지해야함 숫자는 0~ 9 

       
        public static List<int> Solution(List<int> array) 
        {
            List<int> answer = new List<int>();
            int count = 0;
            answer.Add(array[count]);      // 배열 맨처음 숫자는 그냥 넣음 
            for (int i = 0; i < array.Count; i++)
            {
                if (answer[count] != array[i])    //비교해서 다르면 추가
                { 
                    answer.Add(array[i]);
                    count++;
                }
                
            }
            return answer;
        }


        static void Main(string[] args)
        {
            List<int> num = new List<int>();

            Console.WriteLine("배열 숫자 입력 , 끝내고 싶으면 10입력");
            while (true) 
            {
                int input = int.Parse(Console.ReadLine());


                if (input == 10)
                {
                    break;
                }
                else 
                {
                    num.Add(input); 
                }
            }

            List<int> answer = new List<int>();

            answer=Solution(num);



            Console.Write("[ ");
            for (int i = 0; i < answer.Count; i++) 
            {
                Console.Write($" {answer[i]} ");
            }
            Console.Write(" ]");
        }
    }
}
