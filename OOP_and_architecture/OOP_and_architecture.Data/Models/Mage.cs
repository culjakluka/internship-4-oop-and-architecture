using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Mage : Hero
    {
        public Mage(string name) : base(name)
        {
            Health = 100;
            MaxHealth = Health;
            Damage = 150;
            Mana = 100;
            MaxMana = Mana;
        }
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        private bool WasResurrected = false;
        public void Heal() 
        {
            Mana -= 50;
            Health = 100;
            Console.WriteLine($"{Name} filled up his health pool for a cost of 50 mana. {Mana} mana left.");
        }
        public override void LevelUp(int gain)
        {
            base.LevelUp(gain);

        }
        public override void BasicAttack(Monster attackedMonster) 
        {
            base.BasicAttack(attackedMonster);
            Mana -= 30;
            Console.WriteLine($"{Name} dealt 30 damage via Basic Attack.");
        }
        public void ReplenishMana() 
        {
            Mana = MaxMana;
            Console.WriteLine($"Replenished {Name} mana pool ({Mana}/{MaxMana})!");
        }
        public void Resurrect() 
        {
            if (!WasResurrected)
            { 
                if (Health < 0) 
                {
                    Health = MaxHealth;
                }
            Console.WriteLine($"{Name} resurrected from the dead!");
                WasResurrected = true;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Mana          - {Mana}";
        }
    }
}
