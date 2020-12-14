using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Ranger : Hero
    {
        public Ranger(string name) : base(name)
        {
            Health = 125;
            MaxHealth = Health;
            Damage = 75;
            CriticalChance = 15;
            StunChance = 15;
        }
        public int CriticalChance { get; set; }
        public int StunChance { get; set; }
        public virtual void BasicAttack(Monster attackedMonster, ref bool stunned) 
        {
            var randomInt = new Random();
            if (randomInt.Next(0, 101) > StunChance) 
            {
                stunned = true;
            }
            if (randomInt.Next(0, 101) > CriticalChance)
            {
                attackedMonster.Health -= 2 * Damage;
                return;
            }
            base.BasicAttack(attackedMonster);
        }
        public override void LevelUp(int gain)
        {
            base.LevelUp(gain);
            CriticalChance += 20;
            StunChance += 20;
        }

    }
}
