using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Warrior : Hero
    {
        public Warrior(string name) : base(name)
        {
            Health = 150;
            Damage = 50;
        }
        public void RageAttack(Monster attackedMonster) 
        {
            attackedMonster.Health -= 2 * Damage;
            Health = Health * 0.85;
        }
    }
}
