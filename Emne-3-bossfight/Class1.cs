using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Emne_3_bossfight
{
    internal class GameCharacter
    {
        private string Name;
        private int Health;
        private int Strength;
        private int Stamina;
        private int MaxStamina;

        public GameCharacter(string name, int hp, int strength, int stamina, int max)
        {
            Name = name;
            Health = hp;
            Strength = strength;
            Stamina = stamina;
            MaxStamina = max;
        }

        private void Fight(GameCharacter enemy, int dmg)
        {
            if (MaxStamina == 10)
            {
                Strength = dmg;
            }

            if(Stamina >= 10)
            {
                enemy.Health = enemy.Health - Strength;
                Stamina -= 10;
                Console.WriteLine($"{Name} hit {enemy.Name} for {Strength}DMG. {enemy.Name} has {enemy.Health} left");
            }
            else if (Stamina <= 0)
            {
                Recharge();
                Console.WriteLine($"{Name} is to tired to attack");
            }
        }

        private void Recharge()
        {
            Stamina += MaxStamina;
            Console.WriteLine($"{Name} spent the turn recharging its stamina");
        }

        private int RandomDMG()
        {
            var random = new Random();
            var dmg = random.Next(0, 31);
            return dmg;
        }

        public void SimulateFight(GameCharacter enemy)
        {
                Fight(enemy, RandomDMG());
                Thread.Sleep(500);

            if(enemy.Health < 0)
            {
                Console.WriteLine($"{enemy.Name} has been slain");
                Environment.Exit(0);
            }
        }
    }
}
