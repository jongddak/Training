using System.Collections.Generic;

namespace Josephus
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int n = int.Parse(Console.ReadLine());  // n, k 입력 받음 
        int k = int.Parse(Console.ReadLine());

            LinkedList<int> list = new LinkedList<int>();
           

            for (int i = 0; i < n; i++)  // n명의 사람  1 ~ n 까지의 linked list 생성
            {
                list.AddLast(i + 1);
            }

            LinkedListNode<int> node = list.First;   // 노드 순회용 첫번째 노드 저장 
            int count = 0;  //k 번째 제거용 count 
             
            Console.Write("< ");

            while (list.Count > 0)   // 리스트에 남은게 없어질때까지 반복 
            {   
                
                count++;
                if (count % k == 0)   // k번째 출력 및 제거
                {
                    Console.Write($"{node.Value}  ");
                    LinkedListNode<int> nextNode = node.Next ?? list.First; // 미리 다음 노드를 저장안하면 참조 오류 생겨서
                    list.Remove(node); // k번째 제거
                    node = nextNode;  // 다음노드로 
                    
                }
                else node = node.Next??list.First ;  // k번째가 아니라면 다음노드 or 마지막이면 처음으로 바꾸기 

            }
            Console.Write(" >");
        }
    } 
}
