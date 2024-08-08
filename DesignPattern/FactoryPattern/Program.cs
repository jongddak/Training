namespace FactoryPattern
{
    //namespace _01._Factory
    //{
    //    internal class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Item potion = ItemFactory.Instantiate("포션");
    //        }
    //    }

    //    public class ItemFactory
    //    {
    //        // 팩토리를 기반으로 다양한 효과들을 볼 수 있다.

    //        // 아이템 테이블과 같은 기능 추가 (객체생성 담당자 : 단일책임)
    //        // 견본품(프로토타입)
    //        // 추가과정(팩토리메서드)
    //        // 제작부품(빌더)

    //        public static Item Instantiate(string name)
    //        {
    //            if (name == "포션")
    //            {
    //                Potion potion = new Potion();
    //                potion.name = "포션";
    //                potion.weight = 3;
    //                potion.image = "유리병에 담긴 빨간액체";
    //                potion.hp = 30;
    //                return potion;
    //            }
    //            else if (name == "큰포션")
    //            {
    //                Potion potion = new Potion();
    //                potion.name = "큰포션";
    //                potion.weight = 10;
    //                potion.image = "기다란 유리병에 담긴 빨간액체";
    //                potion.hp = 200;
    //                return potion;
    //            }
    //            else
    //            {
    //                Console.WriteLine("해당 이름의 아이템이 없습니다.");
    //                return null;
    //            }
    //        }
    //    }

    //    public class Item
    //    {
    //        public string name;
    //        public int weight;
    //        public string image;
    //    }

    //    public class Potion : Item
    //    {
    //        public int hp;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            Item weapon = ItemFactory.Create(ItemType.Weapon);
            Item potion = ItemFactory.Create(ItemType.Potion);
            Item armor = ItemFactory.Create(ItemType.Armor);
            Item food = ItemFactory.Create(ItemType.Food);

            Console.WriteLine(weapon.name);
            Console.WriteLine(weapon.price);

            Console.WriteLine(armor.name);
            Console.WriteLine(food.name);
            Console.WriteLine(food.price);
            Console.WriteLine(potion.name);

            
        }
    }
    public enum ItemType { Weapon, Armor, Potion, Food }

    public class Item
    {
        public int weight;
        public int price;
        public string name;
        public string image;

    }
    public class Weapon : Item
    {
        public int Atk;
    }
    public class Armor : Item
    {
        public int Dfs;
    }
    public class Potion : Item
    {
        public int heal;
    }
    public class Food : Item
    {
        public int fullness;
    }


    public class ItemFactory
    {
        public static Item Create(ItemType type)
        {
            if (type == ItemType.Weapon)
            {
                Weapon weapon = new Weapon();
                weapon.name = "낡은 직검";
                weapon.image = "낡은 칼 이미지";
                weapon.price = 100;
                weapon.Atk = 10;
                weapon.weight = 5;
                return weapon;
            }
            else if (type == ItemType.Armor)
            {
                Armor armor = new Armor();
                armor.name = "낡은 갑옷";
                armor.image = "낡은 갑옷 이미지";
                armor.price = 80;
                armor.Dfs = 5;
                armor.weight = 8;
                return armor;
            }
            else if (type == ItemType.Potion)
            {
                Potion potion = new Potion();
                potion.name = "체력 포션";
                potion.image = "체력 포션 이미지";
                potion.price = 10;
                potion.heal = 50;
                potion.weight = 1;
                return potion;

            }
            else if (type == ItemType.Food)
            {
                Food food = new Food();
                food.name = "스테이크";
                food.image = "스테이크 이미지";
                food.price = 5;
                food.fullness = 20;
                food.weight = 1;
                return food;
            }
            else 
            {
                Console.WriteLine("해당하는 아이템 타입이 없습니다"); 
                return null;
            }
                        
            

        }
    }






}


