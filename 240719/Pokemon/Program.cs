using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainer {
        public string Name;
      //  public const int maxMonsters = 6; 
        public string[] Monsters;
        


        public Trainer(string name) {
        
           this.Name = name;
            //  this.Monsters = new string[maxMonsters];
            this.Monsters =new string[5];
            Monsters[0] = new Monster("파이리"); //스타팅
        }
    
    
    
    }
 class Monster {
        public string Name;
        private int hp;

        public Monster(string name, int hp)
        {
            this.Name = name;
            this.hp = hp;
        }
    }
   


    internal class Program
    {
        static void Main(string[] args)
        {
            Trainer trainer1 = new Trainer("지우");
            Monster monster1 = new Monster("피카츄", 100);
            trainer1.Monsters[1] = monster1.Name; 
        }
    }

}
