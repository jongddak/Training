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
            
        }
    }

    public class Item 
    {
        public int weight;
        public string name;
        public string image;
        public Item() {
            this.name = "123";
            this.image = "123";
            this.weight = 22;
        }
    }

    public class Potion : Item 
    {
        public int hp;
        public Potion(string name, string image, int weight)
        {
            this.name = name;
            this.image = image;
            this.weight = weight;
            this.hp = 3;

        }
    }

    public class BigPotion : Potion 
    {
        public BigPotion() : base("","",3) 
        {
            this.hp = 30;
        }
    }





}


