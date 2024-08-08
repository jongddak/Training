using System.Text;

namespace BuildPattern
{
    //namespace _02._builder
    //{
    //    internal class program
    //    {
    //        static void main(string[] args)
    //        {
    //            orcbuilder warriororcbuilder = new orcbuilder();
    //            warriororcbuilder.setname("오크 전사");
    //            warriororcbuilder.sethp(300);

    //            orcbuilder archororcbuilder = new orcbuilder();
    //            archororcbuilder.setname("오크 궁수");
    //            archororcbuilder.setweapon("나무 활");
    //            archororcbuilder.setlevel(10);

    //            orcbuilder shamanorcbuilder = new orcbuilder();
    //            shamanorcbuilder.setname("오크 주술사");
    //            shamanorcbuilder.setweapon("저주받은 지팡이");
    //            shamanorcbuilder.setarmor("의식복");
    //            shamanorcbuilder.sethp(50);


    //            orcbuilder chiefshamanorcbuilder = new orcbuilder();
    //            chiefshamanorcbuilder.setname("오크 주술사 족장");
    //            chiefshamanorcbuilder.setweapon("세련된 지팡이");
    //            chiefshamanorcbuilder.setarmor("의식복");
    //            chiefshamanorcbuilder.sethp(200);

    //            orc[] orcs = new orc[9];
    //            orcs[0] = warriororcbuilder.build();
    //            orcs[1] = warriororcbuilder.build();
    //            orcs[2] = warriororcbuilder.build();

    //            orcs[3] = archororcbuilder.build();
    //            orcs[4] = archororcbuilder.build();
    //            orcs[5] = archororcbuilder.build();

    //            orcs[6] = shamanorcbuilder.build();
    //            orcs[7] = shamanorcbuilder.build();
    //            orcs[8] = shamanorcbuilder.build();

    //            for (int i = 0; i < orcs.length; i++)
    //            {
    //                console.write($"{i}번 오크 : ");
    //                console.writeline($"{orcs[i].name} {orcs[i].weapon} {orcs[i].armor} {orcs[i].level} {orcs[i].hp}");
    //            }
    //        }
    //    }

    //    public class orcbuilder
    //    {
    //        public string name;
    //        public string weapon;
    //        public string armor;
    //        public int level;
    //        public int hp;

    //        public orcbuilder()
    //        {
    //            name = "오크";
    //            weapon = "몽둥이";
    //            armor = "천옷";
    //            level = 1;
    //            hp = 100;
    //        }

    //        public orc build()
    //        {
    //            orc orc = new orc();

    //            orc.name = name;
    //            orc.weapon = weapon;
    //            orc.armor = armor;
    //            orc.level = level;
    //            orc.hp = hp;

    //            return orc;
    //        }

    //        public void setname(string name)
    //        {
    //            this.name = name;
    //        }

    //        public void setweapon(string weapon)
    //        {
    //            this.weapon = weapon;
    //        }

    //        public void setarmor(string armor)
    //        {
    //            this.armor = armor;
    //        }

    //        public void setlevel(int level)
    //        {
    //            this.level = level;
    //        }

    //        public void sethp(int hp)
    //        {
    //            this.hp = hp;
    //        }
    //    }

    //    public class orc
    //    {
    //        public string name;
    //        public string weapon;
    //        public string armor;
    //        public int level;
    //        public int hp;
    //    }
    //}
    //stringbuilder sb = new stringbuilder(); 스트링 빌더도 빌더패턴의 일종




    internal class Program
    {
        public class Sandwich
        {
            public string name;
            public string bread;
            public string main;
            public string sauce;
            public string vegetable;
            public int price;
            public int kcal;
        }

        public class Sandwichmaker
        {
            public string name;
            public string bread;
            public string main;
            public string sauce;
            public string vegetable;
            public int price;
            public int kcal;

            public Sandwichmaker()
            {
                name = "샌드위치";
                bread = "우유식빵";
                main = "햄";
                sauce = "머스타드";
                vegetable = "양상추";
                price = 3700;
                kcal = 430;
            }

            public Sandwich build()
            {
                Sandwich sandwich = new Sandwich();

                sandwich.name = name;
                sandwich.bread = bread;
                sandwich.main = main;
                sandwich.sauce = sauce;
                sandwich.vegetable = vegetable;
                sandwich.price = price;
                sandwich.kcal = kcal;

                return sandwich;
            }

            public void setName(string name)
            {
                this.name = name;
            }
            public void setBread(string bread)
            {
                this.bread = bread;
            }
            public void setMain(string main)
            {
                this.main = main;
            }
            public void setSauce(string sauce)
            {
                this.sauce = sauce;
            }

            public void setVegetable(string vegetable)
            {
                this.vegetable = vegetable;
            }

            public void setPrice(int price)
            {
                this.price = price;
            }

            public void setKcal(int kcal)
            {
                this.kcal = kcal;
            }

          


        }
        static void Main(string[] args)
        {
            Sandwichmaker nomalsandwichmaker = new Sandwichmaker();
            nomalsandwichmaker.setName("일반 샌드위치");
            nomalsandwichmaker.setBread("우유식빵");
            nomalsandwichmaker.setMain("햄");
            nomalsandwichmaker.setVegetable("양상추");
            nomalsandwichmaker.setSauce("머스타드");
            nomalsandwichmaker.setKcal(430);
            nomalsandwichmaker.setPrice(3200);
            

            Sandwichmaker cheesesandwichmaker = new Sandwichmaker();
            cheesesandwichmaker.setName("치즈 샌드위치");
            cheesesandwichmaker.setBread("호밀식빵");
            cheesesandwichmaker.setMain("치즈");
            cheesesandwichmaker.setVegetable("올리브");
            cheesesandwichmaker.setSauce("꿀");
            cheesesandwichmaker.setKcal(530);
            cheesesandwichmaker.setPrice(3600);
            

            Sandwich[] sandwiches = new Sandwich[5];

            sandwiches[0] = nomalsandwichmaker.build();
            sandwiches[1] = nomalsandwichmaker.build();
            sandwiches[2] = nomalsandwichmaker.build();

            sandwiches[3] = cheesesandwichmaker.build();
            sandwiches[4] = cheesesandwichmaker.build();

            foreach (var i in sandwiches) 
            {
                Console.WriteLine($"{i.bread},{i.main},{i.sauce},{i.vegetable}를 사용한 {i.name}입니다.   가격 :{i.price}, 칼로리{i.kcal}");
            }



        }
    }
}

