using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainOop1
{
    
    internal class Program
    {
        class chracter 
    {
        private int level;
        private int hp;
        private int movementspeed;
        public int damage;

        public void Forward() 
        {   
            movementspeed = 3;
            Console.WriteLine("전진합니다");
        }
        public void Backward()
        {   
            movementspeed = -1;
            Console.WriteLine("후진합니다");
        }
        public void TurnLeft()
        {
            movementspeed = 1;
            Console.WriteLine("자회전합니다");
        }
        public void TurnRight()
        {   
            movementspeed = 1;
            Console.WriteLine("우회전합니다");
        }
        public void Attak(int damage)
        {
            Console.WriteLine($"{damage}의 피해를 입힘");
         
        }
        public void Hit(int damage)
        {
            Console.WriteLine($"{damage}의 피해를 받음");
        }

    }
        static void Main(string[] args)
        {

        }
    }
}
