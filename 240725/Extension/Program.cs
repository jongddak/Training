using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extension
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("아이디를 입력하세요 : ");
            string id = Console.ReadLine();

            if (id.IsAllowedID())
            {
                Console.WriteLine("ID가 유효합니다.");
            }
            else
            {
                Console.WriteLine("ID에 허용되지 않는 특수문자가 있습니다.");
            }
        }
    }
}
    public static class StringExtension 
    {
        public static bool IsAllowedID(this string id) 
        {
            char[] disAllowedChar = { '!', '@', '#', '$', '%', '^', '&', '*' };

        foreach (char i in disAllowedChar)
        {
            if (id.Contains(i))
            {
                return false;
            }
        }

         return true;     
        }
        
    
    } 




