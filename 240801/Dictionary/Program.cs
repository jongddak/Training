namespace Dictionary
{
    internal class Program
    {
        public enum Monstertype { Fire, Water, Grass, Electric, Wind }
        
        // monsterdata 로 딕셔너리 만들고  monster 클래스로 data 를 참조해서 몬스터를 생성해라?
        public class MonsterData  
        {
            public string Name;
            public int Hp;
            public Monstertype Type;
            public string Subscript;

            public MonsterData(string name, int hp, Monstertype type, string subscript)
            {
                Name = name;
                Hp = hp;
                Type = type;
                Subscript = subscript;
            }
        }
        public class Monster 
        {
            public string Name;
            public int Hp;
            public Monstertype Type;
            public string Subscript;

            public Monster(MonsterData data)
            {
                Name = data.Name;
                Hp = data.Hp;
                Type = data.Type;
                Subscript = data.Subscript;

            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, MonsterData> Pokedex = new Dictionary<string, MonsterData>
            {
                {"피카츄",new MonsterData("피카츄",35,Monstertype.Electric,"뺨의 양쪽에 작은 전기 주머니가 있다. 위기 상황일 때 방전한다.") },
                {"파이리",new MonsterData("파이리",39,Monstertype.Fire, "태어날 때부터 꼬리의 불꽃이 타오르고 있다. 불꽃이 꺼지면 그 생명이 다하고 만다.") },
                {"꼬부기",new MonsterData("꼬부기",44,Monstertype.Water, "기다란 목을 등껍질 속에 감춘 다음 기세 좋게 물대포를 발사한다.") },
                {"이상해씨",new MonsterData("이상해씨",45,Monstertype.Grass, "태어났을 때부터 등에 식물의 씨앗이 있으며 조금씩 크게 자란다.") },
                {"버터플",new MonsterData("버터플",100,Monstertype.Wind, "물을 튕겨내는 가루가 날개를 보호하고 있다. 비가 오는 날에도 하늘을 날 수 있다.") },
            };

            Monster pikachu = new Monster(Pokedex["피카츄"]);
            Monster Charmander = new Monster(Pokedex["파이리"]);
            Monster Squirtle = new Monster(Pokedex["꼬부기"]);
            Monster Bulbasaur = new Monster(Pokedex["이상해씨"]);
            Monster Butterfree = new Monster(Pokedex["버터플"]);

            
            Console.WriteLine($"이름:{pikachu.Name}\n타입:{pikachu.Type}\n체력:{pikachu.Hp} \n설명:{pikachu.Subscript}");
            Console.WriteLine("");
            Console.WriteLine($"이름:{Charmander.Name}\n타입:{Charmander.Type}\n체력:{Charmander.Hp} \n설명:{Charmander.Subscript}");



        }
    }
    }






