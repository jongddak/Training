using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Trainer {
        public string Name;
        public Monster[] Monsters;
        


        public Trainer(string name) {
        
           this.Name = name;
           
            Monsters =new Monster[6];
            Monsters[0] = new Monster("파이리"); //스타팅
        }

        //public void GetMonster(Monster monster) {

        //    for (int i = 0; i < 6; i++) 
        //    {
        //        if (monsters[i] == null) {

        //            monster[i] = Monster
        //        }
        //    }
            
        
        
        //}
    
    
    
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
