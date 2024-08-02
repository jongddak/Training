namespace Test1
{   


//    ■ 아래의 요구사항을 충족하는 기능을 제작하시오.
//1. 두 매개변수를 서로 교환하는 함수를 제작한다.
//2. 함수는 같은 자료형의 매개변수 2개를 요구한다.
//3. 함수는 매개변수로 어떠한 자료형이던 대응할 수 있어야 한다.
    internal class Program
    {
        static void Swap<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b; 
            b = temp;

        }

        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine($"a = {a} b ={b}");
            Swap(ref a, ref b);

            Console.WriteLine($"int 자료형 swap 함수  a = {a} b ={b}");

            double x = 10.6;
            double y = 7.77;
            Console.WriteLine($"a = {x} b ={y}");
            Swap(ref x,ref y);
            Console.WriteLine($"double 자료형 swap 함수 a = {x} b ={y}");
        }
    }
}
