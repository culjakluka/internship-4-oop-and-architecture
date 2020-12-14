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
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public double Damage { get; set; }
        public virtual void BasicAttack(Monster attackedMonster)
        {
            attackedMonster.Health -= Damage;
        }
        public void HealAfterBattle() 
        {
            Health += 0.25 * MaxHealth;
        }
        public void HalfHeal() 
        {
            Health = MaxHealth;
            var xpLoss = (Experience % 100) / 2;
            Experience -= xpLoss;
            Console.WriteLine($"{Name} healed at an expense of {xpLoss} experience!");
        }
        public void ExperienceGain(int gain) 
        {
            Experience += gain;
        }
        public virtual void LevelUp(int gain) 
        {
            Level += gain;
            Console.WriteLine($"Leveled up to level {Level}!");
            MaxHealth += 20;
            Damage += 15;
        }

        public void LevelCheck() 
        {
            var bonusLevels = 0;
            if (Experience / 100 > Level) 
            {
                bonusLevels = Experience / 100 - Level;
            }
            this.LevelUp(bonusLevels);    
        }
        public override string ToString()
        {
            return $"{Name}'s stats: \n" +
                $"Health        - {Health}/{MaxHealth} Attack damage - {Damage}\n" +
                $"Hero level    - {Level}   ({Experience%100}xp/100xp to level {Level + 1})";
        }
    }
}
