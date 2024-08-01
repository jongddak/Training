namespace Traingraph
{
    internal class Program
    {
       
          

        public abstract class Graph
        {
            public int VertexCount { get; protected set; }

            public Graph(int vertex)
            {
                VertexCount = vertex;
            }

            public abstract void Connect(int from, int to);
            public abstract void DisConnect(int from, int to);
            public abstract bool IsConnect(int from, int to);
        }

        public class ListGraph : Graph
        {
            public List<int>[] graph;

            public ListGraph(int vertex) : base(vertex)
            {
                graph = new List<int>[vertex];
                for (int i = 0; i < vertex; i++)
                {
                    graph[i] = new List<int>();
                }
            }

            public override void Connect(int from, int to)
            {
                graph[from].Add(to);
            }

            public override void DisConnect(int from, int to)
            {
                graph[from].Remove(to);
            }

            public override bool IsConnect(int from, int to)
            {
                return graph[from].Contains(to);
            }
        }
        static void Main(string[] args)
         {
            ListGraph listGraph = new ListGraph(8);

          
            listGraph.Connect(0, 1);
            listGraph.Connect(0, 2);
            listGraph.Connect(0, 3);
            listGraph.Connect(0, 4);

            listGraph.Connect(1, 3);
            listGraph.Connect(1, 6);

            listGraph.Connect(2, 4);
            listGraph.Connect(2, 6);

            listGraph.Connect(3, 5);

            listGraph.Connect(4, 6);

            listGraph.Connect(5, 6);

            

            // 그래프 출력
            for (int i = 0; i < listGraph.VertexCount; i++)
            {
                Console.Write($" {i}번 노드: ");
                foreach (var vertex in listGraph.graph[i])
                {
                    Console.Write($"{vertex}노드 ");
                }
                Console.WriteLine();
            }


        }
    
    }
}
