using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Goblin : Monster
    {
        public Goblin()
        {
            var rand = new Random();
            Health = rand.Next(MinRandomHealth, MaxRandomHealth);
            MaxHealth = Health;
            Damage = rand.Next(20, 30);
            Name = "Goblin";
            ExperienceGain = (int)MaxHealth;
        }
        private int MaxRandomHealth = 50;
        private int MinRandomHealth = 20;
        public override string ToString()
        {
            return $"Goblin's stats: {base.ToString()}";
        }
    }
}
