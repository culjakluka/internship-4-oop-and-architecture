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
            Damage = 75;
        }

    }
}
