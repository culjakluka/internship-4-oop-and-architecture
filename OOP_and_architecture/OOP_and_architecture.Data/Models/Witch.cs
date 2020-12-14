using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data.Monsters
{
    public class Witch : Monster
    {
        public Witch()
        {
            var rand = new Random();
            Health = rand.Next(MinRandomHealth, MaxRandomHealth);
            MaxHealth = Health;
            Damage = rand.Next(35, 45);
            Name = "Witch";
            ExperienceGain = (int)MaxHealth;
        }
        private int MaxRandomHealth = 70;
        private int MinRandomHealth = 30;
        public override string ToString()
        {
            return $"Witch's stats: {base.ToString()}";
        }
        public void DoomBoos(Dictionary<int, Monster> dict, Hero hero)
        {
            var randomInt = new Random();
            if (randomInt.Next(0, 101) > 3) 
            {
                foreach (var monster in dict)
                {
                    RandomizeHealth(monster.Value);
                }
            }
            hero.Health = hero.Health * (randomInt.NextDouble()+0.5);
        }
        public void RandomizeHealth(Monster monster)
        {
            var randomInt = new Random();
            monster.Health = randomInt.Next(MinRandomHealth, MaxRandomHealth);
            monster.MaxHealth = monster.Health;
        }
    }
}
