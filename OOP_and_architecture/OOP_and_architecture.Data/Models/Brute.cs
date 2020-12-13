using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data.Monsters
{
    public class Brute : Monster
    {

        public override string ToString()
        {
            return $"Brute's stats: {base.ToString()}";
        }
    }
}
