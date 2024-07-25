using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public class Player
    {
        private Armor curArmor;

        public void Equip(Armor armor)
        {
            Console.WriteLine($"플레이어가 {armor.name} 을/를 착용합니다.");
            curArmor = armor;
            curArmor.OnBreaked += UnEquip;
        }

        public void UnEquip()
        {
            Console.WriteLine($"플레이어가 {curArmor.name} 을/를 해제합니다.");
            curArmor.OnBreaked -= UnEquip;
            curArmor = null;
        }

        public void Hit()
        {
            // 빈칸
            if (curArmor != null)
            {
                Console.WriteLine($"공격을 받았습니다! 내구도가 1 감소합니다");
                curArmor.DecreaseDurability();
            }
            else { Console.WriteLine("현재 장착한 방어구가 없습니다!"); }

            
        }
    }

    public class Armor
    {
        public string name;
        private int durability;

        public event Action OnBreaked;

        public Armor(string name, int durability)
        {
            this.name = name;
            this.durability = durability;
        }

        public void DecreaseDurability()
        {
            durability--;
            if (durability <= 0)
            {
                Break();
                
            }
        }

        private void Break()
        {
            
            // 빈칸
            Console.Write($"현재 내구도 : {durability} ");
            Console.WriteLine("갑옷 파괴! ");
            OnBreaked();
        }
    }

    static void Main(string[] args)
    {
        Player player = new Player();
        Armor ammor = new Armor("갑옷", 3);
        Armor ammor1 = new Armor("갑옷", 3);


        player.Equip(ammor);

        player.Hit();
        player.Hit();
        player.Hit();

        player.Hit();

        player.Equip(ammor1);
        player.Hit();
        player.Hit();
        player.Hit();


    }
}
