namespace Test4
{
    internal class Program
    {
        public abstract class Map
        {
            public int AreaCount { get; protected set; }
            public List<string> MapNameList;

            public Map(int Area)
            {
                AreaCount = Area;
                MapNameList = new List<string>(new string[Area]);
            }

            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool IsConnect(int from, int to);
        }

        public class ListMap : Map
        {
            public List<int>[] Map;

            public ListMap(int Area) : base(Area)
            {
                Map = new List<int>[Area];
                for (int i = 0; i < Area; i++)
                {
                    Map[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                Map[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                Map[from].Remove(to);
            }

            public override bool IsConnect(int from, int to)
            {
                return Map[from].Contains(to);
            }
        }
       
        static void Main(string[] args)
        {   
            ListMap listMap = new ListMap(8);
            Stack<int> Mapstack = new Stack<int>(); // 스택에 방문순서대로 들어가니 현재 이전 이동경로 다 가능? 
            
            Mapstack.Push(0); // 마을로 시작 
            listMap.MapNameList[0] = "마을";
            listMap.MapNameList[1] = "길드";
            listMap.MapNameList[2] = "성";
            listMap.MapNameList[3] = "상점";
            listMap.MapNameList[4] = "묘지";
            listMap.MapNameList[5] = "숲";
            listMap.MapNameList[6] = "초원";
            listMap.MapNameList[7] = "바다";

            listMap.Connect(0, 2); // 마을-성
            listMap.Connect(0, 4); // 마을-묘지


            listMap.Connect(1, 2); // 길드-성
            listMap.Connect(1, 3); // 길드-상점 
            listMap.Connect(1, 5); // 길드-숲



            listMap.Connect(2, 5); // 성-숲
            listMap.Connect(2, 6); // 성-초원
            listMap.Connect(2, 4); // 성-묘지
            listMap.Connect(2, 0);
            listMap.Connect(2, 1);



            listMap.Connect(3, 5); // 상점-숲
            listMap.Connect(3, 7); // 상점-바다
            listMap.Connect(3, 1);

            listMap.Connect(4, 6); // 묘지-초원
            listMap.Connect(4, 7); // 묘지-바다
            listMap.Connect(4, 0);
            listMap.Connect(4, 2);


            listMap.Connect(5, 6); // 숲-초원
            listMap.Connect(5, 1);
            listMap.Connect(5, 2);
            listMap.Connect(5, 3);

            listMap.Connect(6, 7); // 초원-바다
            listMap.Connect(6, 2);
            listMap.Connect(6, 4);
            listMap.Connect(6, 5);

            listMap.Connect(7, 3);
            listMap.Connect(7, 6);
            listMap.Connect(7, 4);

            
            
          


            while (true)
            {

                Console.WriteLine("=========맵이동=========");
                Console.WriteLine($"현재장소 : {listMap.MapNameList[Mapstack.Peek()]}");


                Console.Write("이동경로 : ");
                foreach (var i in Mapstack.Reverse())
                {
                    Console.Write($"{listMap.MapNameList[i]}  > ");
                    
                }
                Console.WriteLine();
                Console.WriteLine();

                int count = 1;
                foreach (var i in listMap.Map[Mapstack.Peek()])  // 갈수있는곳 
                {
                    Console.WriteLine($"{count}.  {listMap.MapNameList[i]} ");
                    count++;
                }
                

                Console.WriteLine("이동할 장소를 선택하세요(뒤로가기 0) : ");

                List<int> list = new List<int>();
                foreach (var Area in listMap.Map[Mapstack.Peek()])
                {
                   list.Add(Area);
                }

                int input = int.Parse(Console.ReadLine());
                Console.Clear();
                if (input == 0)
                {
                    Mapstack.Pop();
                    
                }
                else if (input == 1)
                {
                    
                    Mapstack.Push(list[0]);
                }
                else if (input == 2)
                {
                    
                    Mapstack.Push(list[1]);
                }
                else if (input == 3) 
                {
                    
                    Mapstack.Push(list[2]);
                }
                else if (input == 4) 
                {
                    
                    Mapstack.Push(list[3]);
                }
                else if (input == 5) 
                {
                    
                    Mapstack.Push(list[4]);
                }
                else { break; }

            }

        }
    }
}

