using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Monster
    {
        public double Health { get; set; }
        public double Damage { get; set; }
        public override string ToString()
        {
            return $"Health - {Health} Damage - {Damage}";
        }
    }
}
