namespace Listtt
{
    internal class Program
    {
        public class Invetory
        {
            List<Item> inventory;  // inventory 리스트 
            public Invetory() {
            
                inventory = new List<Item>();
            
            }

            
            public void RandomAdd(List<Item> items) 
            {   
                Random rand = new Random();
                int x = rand.Next(0,4); // 랜덤 숫자 반환 1 ~ 5
                                        // 아이템리스트에 숫자로 접근해서 .Add  ,9개 넘으면 추가 안되게
                if (inventory.Count < 9)
                {
                    inventory.Add(items[x]);
                }
                else Console.WriteLine("인벤토리가 꽉 찼습니다.");
               



            }
            //숫자키 1~9를 누르면 해당하는 숫자의 아이템을 제거한다
            public void indexRemove(int index)
            {
                Console.WriteLine($"{index}번칸 {inventory[index].Name}삭제 !");
                inventory.RemoveAt(index);
            }
            public void PrintInventory() //인벤토리 내용물 출력 인벤토리 리스트 내용물 만큼만 출력 
            {                           
                Console.Clear();
                for (int i = 0; i < inventory.Count; i++) {
                    Console.WriteLine($"{i+1}번칸의 아이템 : {inventory[i].Name}"); 
                }
            }
        }
        public class Item   // 아이템 타입 클래스 
        {
            public string Name;

            public Item(string name) {
                Name = name;
            }
        }
        public class Potion : Item     // item 클래스를 상속받음
        {   
            
            public Potion(string name):base(name){ }
        }
        public class Weapon : Item
        {
            public Weapon(string name):base(name) { }
        }
        public class Armor : Item 
        {
            public Armor(string name):base(name) { }
        }
        public class Accessory : Item 
        {
            public Accessory(string name):base(name) { }
        }
        public class Food : Item 
        {

            public Food(string name):base(name) { }
        }

        static void Main(string[] args)
        {   
            Invetory invetory = new Invetory();

            List<Item> items = new List<Item>() // 랜덤으로 뽑아갈 아이템 리스트
            {
                new Potion("hp 포션"),
                new Weapon("몽둥이"),
                new Armor("천갑옷"),
                new Accessory("금반지"),
                new Food("빵")
            };

            int value;
            string str;
            
            Console.WriteLine("0 = 랜덤 아이템 획득.");
            Console.WriteLine("1~9 = 해당 칸 아이템 삭제.");
            Console.WriteLine("10 = 종료.");

            while (true) //입력마다 콘솔에 지속적으로 인벤토리의 상태를 표시한다
                         //숫자키 0을 누르면 랜덤으로 아이템의 종류를 획득하고 인벤토리에 추가한다
                         //숫자키 1~9를 누르면 해당하는 숫자의 아이템을 제거한다
            {

                Console.Write("숫자 입력 : ");
                str = Console.ReadLine();
                while ((!int.TryParse(str, out value)) || (value < 0 || value > 11))
                {
                    Console.Write("다시 숫자를 입력해주세요!");
                    str = Console.ReadLine();
                }
                if (value < 1)
                { 
                    invetory.RandomAdd(items);
                    
                }
                else if(value < 10)
                {
                    invetory.indexRemove(value-1);
                    
                }
                else if(value == 10){  break; }
                invetory.PrintInventory();
            }
        }
    }
}
