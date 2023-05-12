using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace monster_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Fight_Counter = 0;
            string i = "";
            int damage;
            int XP = 0;

            while (Fight_Counter < 4)
            {               
                Console.WriteLine("Wild Monster appearing{0}",i);
                i += ".";
                Fight_Counter++;
                System.Threading.Thread.Sleep(500);
                Console.Clear();
            }
            monster monster01 = new monster();
            monster01.set_name("easy monster");
            bool fight = true;
            while (fight == true)
            {
                if (monster01.health > 0)
                {
                    int attack = 1;
                    monster01.get_bossinfo();
                    Console.WriteLine("\nEnter 1 to attack");
                    attack = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (attack == 1)
                    {
                        Random num = new Random();
                        damage = num.Next(12, 19);
                        Console.WriteLine("you did {0} damage!", damage);
                        attack = 0;
                        if (monster01.defence > 0)
                        {
                            monster01.set_health(monster01.health - damage / (1 - monster01.defence / 100));
                        }
                        else if (monster01.defence == 0)
                        {
                            monster01.set_health(monster01.health - damage);
                        }
                    }
                    if (monster01.health == 0 || monster01.health < 0)
                    {
                        int NewXP = 0;
                        Console.WriteLine("\nMonster defeated!");
                        Random num = new Random();
                         NewXP = num.Next(4,14);
                        XP = XP + NewXP;
                        Console.WriteLine("You gained {0} XP",NewXP);
                    }
                }
            }

            Console.ReadLine();
        }
        public class monster
        {
            //attributes
            public string name;
            public int health;
            public int defence;

            public monster() 
            {
                name = ("monster");
                health = (100);
                defence = (50);
            }

            //getters and setters for monster attibutes
            public string get_name()
            {
                return name;
            }
            public void set_name(string Name)
            {
                name = Name;
            }
            public int get_health()
            {
                return health;
            }
            public void set_health(int Health)
            {
                health = Health;
            }
            public int get_defence()
            {
                return defence;
            }
            public void set_defence(int Defence)
            {
                defence = Defence;
            }
            //output after each attack
            public void get_bossinfo()
            {
                Console.WriteLine("Monster type: {0}",get_name());
                Console.WriteLine("HP: {0}", get_health());
                Console.WriteLine("Defence: {0}", get_defence());
            }

        }
    }
}
