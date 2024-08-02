namespace Test5
{
    internal class Program
    {
        public class Plyer
        {
            public int Money;
            public int Hp;
            public int Atk;
            public int Dfs;
            public List<Item> Items;

            public void BuyItem(Item item) {

                item.EquipEffect(this);
                Money -= item.Price;
            }
            public void SellItem(Item item)
            {

                item.EnequipEffect(this);
                Money += item.Price;
            }

            public Plyer()
            {
                Money = 3000;
                Hp = 100;
                Atk = 10;
                Dfs = 5;
                Items = new List<Item>(6);
            }
        }
        public abstract class Item
        {
            public string Name;
            public int Price;
            public string Sub;
            public string Effect;

            public abstract void EquipEffect(Plyer plyer);
            public abstract void EnequipEffect(Plyer plyer);

        }
        public class Weapon : Item
        {
            public int Ap;

            public override void EquipEffect(Plyer plyer)
            {
                plyer.Atk += Ap;
                Console.WriteLine($"플레이어의 공격력이 {Ap}만큼 증가했습니다");
            }
            public override void EnequipEffect(Plyer plyer)
            {
                plyer.Atk -= Ap;
                Console.WriteLine($"플레이어의 공격력이 {Ap}만큼 감소했습니다");
            }
            public Weapon(string name, int price, int ap, string sub, string eft)
            {
                Name = name;
                Price = price;
                Ap = ap;
                Sub = sub;
                Effect = eft;
            }
        }
        public class Armor : Item
        {
            public int Dp;

            public override void EquipEffect(Plyer plyer)
            {
                plyer.Dfs += Dp;
                Console.WriteLine($"플레이어의 방어력이 {Dp}만큼 증가했습니다");
            }
            public override void EnequipEffect(Plyer plyer)
            {
                plyer.Dfs += Dp;
                Console.WriteLine($"플레이어의 방어력이 {Dp}만큼 감소했습니다");
            }
            public Armor(string name, int price, int dp, string sub, string eft)
            {
                Name = name;
                Price = price;
                Dp = dp;
                Sub = sub;
                Effect = eft;
            }

        }
        public class Acc : Item
        {
            public int Hpp;

            public override void EquipEffect(Plyer plyer)
            {
                plyer.Hp += Hpp;
                Console.WriteLine($"플레이어의 체력이 {Hpp}만큼 증가했습니다");
            }
            public override void EnequipEffect(Plyer plyer)
            {
                plyer.Hp -= Hpp;
                Console.WriteLine($"플레이어의 체력이 {Hpp}만큼 감소했습니다");
            }
            public Acc(string name, int price, int hpp, string sub, string eft)
            {
                Name = name;
                Price = price;
                Hpp = hpp;
                Sub = sub;
                Effect = eft;
            }
        }
        public class Potion : Item
        {
            public int Hpp;

            public override void EquipEffect(Plyer plyer)
            {
                plyer.Hp += Hpp;
                Console.WriteLine($"플레이어의 체력이 {Hpp}만큼 증가했습니다");
                plyer.Items.Remove(this);
            }
            public override void EnequipEffect(Plyer plyer)
            {
                plyer.Hp -= Hpp;
                Console.WriteLine($"플레이어의 체력이 {Hpp}만큼 감소했습니다");
            }
            public Potion(string name, int price, int hpp, string sub, string eft)
            {
                Name = name;
                Price = price;
                Hpp = hpp;
                Sub = sub;
                Effect = eft;
            }
        }


        static void Main(string[] args)
        {
            Plyer plyer = new Plyer();
            Weapon weapon = new Weapon("검", 300, 10, "낡은 검이다.", "(소유) 공격력 10 상승");
            Armor armor  =new Armor("천갑옷",500,10,"낡은 천갑옷", "(소유) 방어력 10 상승");
            Acc acc = new Acc("은반지", 300, 300, "낡은 은반지", "(소유) 체력 300 상승");
            Potion potion = new Potion("이상한 사탕", 100, 200, "이상한 사탕이다.", "(사용) 체력 200 상승");

            List<Item> storeitems = new List<Item>();
            storeitems.Add(weapon);
            storeitems.Add(armor);
            storeitems.Add(acc);
            storeitems.Add(potion);

            while (true)
            {
                Console.WriteLine("===============================");
                Console.WriteLine("==========아이템 상점==========");
                Console.WriteLine("===============================");
                Console.WriteLine("========== 상점 메뉴 ==========");
                Console.WriteLine("1. 아이템 구매");
                Console.WriteLine("2. 아이템 판매");
                Console.WriteLine("3. 아이템 확인");
                Console.WriteLine("메뉴를 선택하세요 : ");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {   
                    case 0:
                        break;
                    case 1:
                        Console.WriteLine("=========아이템 구매==========");
                        Console.WriteLine($"보유한 골드 : {plyer.Money}G ");
                        for (int i = 0; i < storeitems.Count; i++) 
                        {
                            Console.WriteLine($"{i + 1}.{storeitems[i].Name} \n 가격 : {storeitems[i].Price} \n 설명 : {storeitems[i].Sub} \n 효과 : {storeitems[i].Effect}");
                        }
                        Console.WriteLine("구매할 아이템을 선택하세요 (뒤로가기 0) : ");
                        input = int.Parse(Console.ReadLine());
                        if (input == 0)
                        {
                            break;
                        }
                        else if (input == 1) 
                        {
                            plyer.BuyItem(storeitems[0]);
                        }
                        else if (input == 2)
                        {
                            plyer.BuyItem(storeitems[1]);
                        }
                        else if (input == 3)
                        {
                            plyer.BuyItem(storeitems[2]);
                        }
                        else if (input == 4)
                        {
                            plyer.BuyItem(storeitems[3]);
                        }
                        break;
                    case 2:
                        Console.WriteLine("=========아이템 판매==========");
                        Console.WriteLine($"보유한 골드 : {plyer.Money}G ");
                        for (int i = 0; i < plyer.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{plyer.Items[i].Name} \n 가격 : {plyer.Items[i].Price} \n 설명 : {plyer.Items[i].Sub} \n 효과 : {plyer.Items[i].Effect}");
                        }
                        Console.WriteLine("판매할 아이템을 선택하세요 (뒤로가기 0) : ");
                        input = int.Parse(Console.ReadLine());
                        if (input == 0)
                        {
                            break;
                        }
                        else if (input == 1)
                        {
                            plyer.SellItem(storeitems[0]);
                        }
                        else if (input == 2)
                        {
                            plyer.SellItem(storeitems[1]);
                        }
                        else if (input == 3)
                        {
                            plyer.SellItem(storeitems[2]);
                        }
                        else if (input == 4)
                        {
                            plyer.SellItem(storeitems[3]);
                        }
                        break ;
                    case 3:
                        Console.WriteLine("=========보유한 아이템==========");
                        Console.WriteLine($"보유한 골드 : {plyer.Money}G ");
                        for (int i = 0; i < plyer.Items.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}.{plyer.Items[i].Name} \n 가격 : {plyer.Items[i].Price} \n 설명 : {plyer.Items[i].Sub} \n 효과 : {plyer.Items[i].Effect}");
                        }

                        break;



                }
            }
            
        }
    }
}
