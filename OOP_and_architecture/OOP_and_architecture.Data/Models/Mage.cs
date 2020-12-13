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
            Damage = 150;
            Mana = 100;
        }
        public int Mana { get; set; }
        public void ReplenishMana() 
        {
            Mana = 100;
            Console.WriteLine($"Replenished {Name} mana pool!");
        }
        public override string ToString()
        {
            return $"{base.ToString()}\n" +
                $"Mana          - {Mana}";
        }
    }
}
