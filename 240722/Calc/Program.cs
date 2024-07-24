using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{   
    internal class Program
    {
        class MyCalculator 
        {
            public static double Add(double a, double b) 
            {
                return a + b;
            }
            public static double Subtract(double a, double b)
            {
                return a - b;
            }
            public static double Multiply(double a, double b)
            {
                return a * b;
            }
            public static double Divide(double a, double b)
            {
                if (b == 0) {
                    Console.WriteLine("에러 : 0으론 나눌수 없어요");
                        return a;
                
                }
                return a / b;
            }
            public static double Squared(double a, double b)
            {
                return Math.Pow(a,b);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("1.덧셈");
            Console.WriteLine("2.뺄셈");
            Console.WriteLine("3.곱셈");
            Console.WriteLine("4.나눗셈");
            Console.WriteLine("5.제곱");
            int x = int.Parse(Console.ReadLine());
            

            Console.WriteLine("숫자 두개 입력해주세요");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            double b= double.Parse(Console.ReadLine());
            switch (x) { 
            
            
                           case 1: Console.WriteLine(MyCalculator.Add(a,b));
                                break;
                           case 2: Console.WriteLine(MyCalculator.Subtract(a, b));
                                break;              
                           case 3: Console.WriteLine(MyCalculator.Multiply(a, b));    
                                break;    
                           case 4: Console.WriteLine(MyCalculator.Divide(a, b));
                                break;
                           case 5: Console.WriteLine(MyCalculator.Squared(a, b));
                           break;
           
            
            
                        }
            
           

           

        }
    }
}
