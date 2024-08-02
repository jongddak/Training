namespace Test2
{

    //    ■ 아래의 요구사항을 충족하는 기능을 제작하시오.
    //1. 모든 몬스터들은 이름을 가지고 공격을 할 수 있다.
    //2. 각각의 몬스터들은 이름이 다르며 공격방법이 다르다.
    //3. 몬스터에 이름을 추가하는 경우 주어진 이름으로 활동한다.

    internal class Program
    {
        public class Monster
        {
            public string Name;
            public string skill;

            public virtual void Attack() { }


            public Monster(string name) {
                Name = name;

            }
            public Monster() {
                
            }
        }
        public class Pikachu : Monster 
        {
            string name;
            string skill;
            public override void Attack() {
                Console.WriteLine(this.skill);
            }
            public Pikachu(string name) 
            {
                Name = name;
                skill = "백만볼트!";    
            }
            public Pikachu() {
                Name = "피카츄";
                skill = "백만볼트!";
            }
            
        }
        public class Charmander : Monster
        {
            string name;
            string skill;
            public override void Attack()
            {
                Console.WriteLine(this.skill);
            }
            public Charmander(string name)
            {
                Name = name;
                skill = "화염방사!";
            }
            public Charmander()
            {
                Name = "파이리";
                skill = "화염방사!";
            }

        }
        public class Squirtle : Monster
        {
            string name;
            string skill;
            public override void Attack()
            {
                Console.WriteLine(this.skill);
            }
            public Squirtle(string name)
            {
                Name = name;
                skill = "물대포!";
            }
            public Squirtle()
            {
                Name = "꼬부기";
                skill = "물대포!";
            }

        }
        public class Bulbasaur : Monster
        {
            string name;
            string skill;
            public override void Attack()
            {
                Console.WriteLine(this.skill);
            }
            public Bulbasaur(string name)
            {
                Name = name;
                skill = "덩굴채찍!";
            }
            public Bulbasaur()
            {
                Name = "이상해씨";
                skill = "덩굴채찍!";
            }

        }
        //public class Charmander : Monster { }
        //public class Squirtle : Monster { }
        //public class Bulbasaur : Monster { }



        static void Main(string[] args)
        {
            Monster[] monsters = new Monster[5];

            monsters[0] = new Pikachu();
            monsters[1] = new Pikachu("피피카츄");
            monsters[2] = new Charmander();
            monsters[3] = new Squirtle();
            monsters[4] = new Bulbasaur();

            foreach (Monster monster in monsters)
            {
              Console.WriteLine($"{monster.Name} 공격해 !");
              monster.Attack();
              Console.WriteLine();
            }
        }
    }
}
