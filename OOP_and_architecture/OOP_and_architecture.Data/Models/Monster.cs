using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Monster
    {
        public int Health { get; set; }
        public int Damage { get; set; }
        public override string ToString()
        {
            return $"Health - {Health} Damage - {Damage}";
        }
    }
}
