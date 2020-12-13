using OOP_and_architecture.Data;
using System;

namespace OOP_and_architecture.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            int action;
            do
            {
                Console.WriteLine("\tGlavni izbornik:\n" +
                    "1. Odabir Heroja: "); ;
                action = int.Parse(Console.ReadLine());
                switch (action)
                { 
                    case 1:
                        SelectHeroType();
                        break;
                    default:
                        break;
                }
            } while (action!=0);            
        }
        static string Input(string message)
        {
            Console.WriteLine(message);
            var userInput = "";
            do
            {

            } while (!string.IsNullOrWhiteSpace(userInput));
            return userInput;
        }
        static int SelectHeroType() 
        {
            int heroType;
            var warrior = new Warrior("placeholder");
            var mage = new Mage("placeholder");
            var ranger = new Ranger("placeholder");
            Console.WriteLine($"Odaberite tip svog heroja: \n" +
                   $"1. Warrior -   Health: {warrior.Health}    - Damage: {warrior.Damage}\n" +
                   $"2. Mage    -   Health: {mage.Health}    - Damage: {mage.Damage}\n" +
                   $"3. Ranger  -   Health: {ranger.Health}    - Damage: {ranger.Damage}\n" +
                   $"0. povratak u glavni izbornik");
            int action;
            var passedOnce = false;
            do
            {
                do
                {
                if(passedOnce)
                    {
                        Console.WriteLine("Unesite broj ispred tipa heroja(0 za povratak): ");
                    }
                    action = int.Parse(Console.ReadLine());
                    passedOnce = true;
                } while ( action < -1 || 3 < action );
                switch (action)
                {
                    case 1:
                        heroType = 1;
                        break;
                    case 2:
                        heroType = 2;
                        break;
                    case 3:
                        heroType = 3;
                        break;
                    default:
                        heroType = 0;
                        break;
                }
            } while (action!=0);
            return heroType;
        }
    }
}
