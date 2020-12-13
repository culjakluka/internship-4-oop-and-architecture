using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data
{
    public class Goblin : Monster
    {
        public int RandomHealthGenerator()
        {
            var rand = new Random();
            return rand.Next(20, 51);
        }
        public override string ToString()
        {
            return $"Goblin's stats: {base.ToString()}";
        }
    }
}
