using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_and_architecture.Data.Monsters
{
    public class Witch : Monster
    {
        public override string ToString()
        {
            return $"Witch's stats: {base.ToString()}";
        }
    }
}
