﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Monster
    {
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public double Damage { get; set; }
        public int ExperienceGain { get; set; }
        protected string Name;
        public virtual void BasicAttack(Hero attackedHero)
        {
            attackedHero.Health -= Damage;
            Console.WriteLine($"");
        }
        public override string ToString()
        {
            return $"Health - {Health}/{MaxHealth} Damage - {Damage}";
        }
    }
}
