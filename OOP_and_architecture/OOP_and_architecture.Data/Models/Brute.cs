using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data.Monsters
{
    public class Brute : Monster
    {
        public Brute()
        {
            var rand = new Random();
            Health = rand.Next(MinRandomHealth, MaxRandomHealth);
            MaxHealth = Health;
            Damage = rand.Next(40, 45);
            Name = "Brute";
            ExperienceGain = (int)MaxHealth;
        }
        private int BrutalChance = 5;
        private int MaxRandomHealth = 60;
        private int MinRandomHealth = 40;
        public void BrutalAttack(Hero attackedHero) 
        {
            var randomInt = new Random();
            if (BrutalChance > randomInt.Next(0, 100)) 
            {
                attackedHero.Health -= 0.2 * attackedHero.MaxHealth;

            }
            base.BasicAttack(attackedHero);
        }
        public override string ToString()
        {
            return $"Brute's stats: {base.ToString()}";
        }
    }
}
