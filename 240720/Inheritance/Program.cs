using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {

        public class Gun {

            public string Name;
            public string Ammotype;
            public int Damage;
            public double Firerate;
            bool AttachScope;

            public virtual void shoot() 
            {
                Console.WriteLine("총알을 발사합니다");
            }
            public virtual void reload()
            {
                Console.WriteLine("총알을 재장전합니다");
            }
            public virtual void adjustment()
            {
                Console.WriteLine("조정간을 조정합니다");
            }



        }

        // 오버로딩과 오버라이딩 
        static void Main(string[] args)
        {
        }
    }
}
