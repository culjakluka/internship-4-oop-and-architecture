using System;

namespace OOP_and_architecture.Data
{
    public class Hero
    {
        public Hero(string name)
        {
            Name = name;
            Experience = 100;
            Level = 1;
        }
        public string Name { get; set; }
        public int Experience { get; set; }
        public int Level { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public void ExperienceGain(int gain) 
        {
            Experience += gain;
        }
        public void LeveulUp(int gain) 
        {
            Level += gain;
            Console.WriteLine($"Leveled up to level {Level}!");
        }

        public void LevelCheck() 
        {
            if (Experience / 100 > Level) 
            {
                var bonusLevels = Experience / 100 - Level;
            }
        }
        public override string ToString()
        {
            return $"{Name}'s stats: \n" +
                $"Health        - {Health} Attack damage - {Damage}\n" +
                $"Hero level    - {Level}   ({Experience%100}xp/100xp to level {Level + 1})";
        }
    }
}
