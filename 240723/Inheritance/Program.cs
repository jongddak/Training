using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {

        public abstract class Gun {

            public string Name;
            public string Ammotype;
            public int AmmoMax;
            public int Damage;
            public double Firerate;
            public bool AttachScope;
            public bool AttachGrip;
            public bool AttachSuprresor;

            public virtual void Shoot() {
                Console.WriteLine($"{Ammotype}탄이 {Firerate}초에 한발씩 발사됨");
            }
            public virtual void Reload() {
                Console.WriteLine($"{Ammotype}탄이 {AmmoMax}발 장전됨");
            }
            public abstract void Attachment();
        }

        public class Aug : Gun {

            public Aug(string name, string ammotype, int ammoMax, int damage, double firerate, bool attachScope, bool attachGrip, bool attachSuprresor)
            {
                Name = name;
                Ammotype = ammotype;
                AmmoMax = ammoMax;
                Damage = damage;
                Firerate = firerate;
                AttachScope = attachScope;
                AttachGrip = attachGrip;
                AttachSuprresor = attachSuprresor;

                Console.WriteLine($"{Ammotype}탄을 사용하는 {Name}입니다 ");
            }


            public override void Attachment()
            {
                Console.Write($"{Name}에 ");

                if (AttachScope == true)
                {
                    Console.Write($"8배율스코프 장착 ");
                }

                if (AttachGrip == true)
                {
                    Console.Write($"수직손잡이 장착 ");
                }
                if (AttachSuprresor == true)
                {
                    Console.Write($"소음기 장착 ");
                }
                Console.WriteLine("");
            }


        }
        public class M24 : Gun
        {
            public M24(string name, string ammotype, int ammoMax, int damage, double firerate, bool attachScope, bool attachGrip, bool attachSuprresor)
            {
                Name = name;
                Ammotype = ammotype;
                AmmoMax = ammoMax;
                Damage = damage;
                Firerate = firerate;
                AttachScope = attachScope;
                AttachGrip = attachGrip;
                AttachSuprresor = attachSuprresor;

                Console.WriteLine($"{Ammotype}탄을 사용하는 {Name}입니다 ");
            }



            public override void Attachment()
            {
                Console.Write($"{Name}에 ");

                if (AttachScope == true)
                {
                    Console.Write($"8배율스코프 장착 ");
                }

                if (AttachGrip == true)
                {
                    Console.Write($"수직손잡이 장착 ");
                }
                if (AttachSuprresor == true)
                {
                    Console.Write($"소음기 장착 ");
                }
                Console.WriteLine("");
            }

        }
        public class Beryl : Gun
        {

            public Beryl(string name, string ammotype, int ammoMax, int damage, double firerate, bool attachScope, bool attachGrip, bool attachSuprresor)
            {
                Name = name;
                Ammotype = ammotype;
                AmmoMax = ammoMax;
                Damage = damage;
                Firerate = firerate;
                AttachScope = attachScope;
                AttachGrip = attachGrip;
                AttachSuprresor = attachSuprresor;

                Console.WriteLine($"{Ammotype}탄을 사용하는 {Name}입니다");
            }



            public override void Attachment()
            {
                Console.Write($"{Name}에 ");

                if (AttachScope == true)
                {
                    Console.Write($"8배율스코프 장착 ");
                }

                if (AttachGrip == true)
                {
                    Console.Write($"수직손잡이 장착 ");
                }
                if (AttachSuprresor == true)
                {
                    Console.Write($"소음기 장착 ");
                }
                Console.WriteLine("");
            }
           
        }

        // 오버로딩 같은 이름의 메서드를 여러 개 정의하고 매개변수의 수나 타입을 다르게 하여 구분가능
        // 오버로딩을 통해 하나의 메서드 이름으로 다양한 처리를 수행 가능. 

        // 오버라이딩 상속된 클래스의 메서드를 재정의 해 해당 메서드의 동작을 자식 클래스에 맞게 변경하는 것 virtual, abstract , override .키워드로 사용 
        static void Main(string[] args)
        {
           Aug aug = new Aug("Aug","5.56mm",40,42,0.085d,false,true,true);
           aug.Attachment();
           aug.Reload();
           aug.Shoot();
           Console.WriteLine("");
           M24 m24 = new M24("M24", "7.56mm", 7, 70, 1.4d, true, false, true);
           m24.Attachment();
           m24.Reload();  
           m24.Shoot();
           Console.WriteLine("");
           Beryl beryl = new Beryl("Beryl", "7.56mm", 40, 45, 0.095d, true, false, true);
           beryl.Reload();
           beryl.Attachment();
           beryl.Shoot();
           
             




        }
    }
}
