using OOP_and_architecture.Data;
using OOP_and_architecture.Data.Monsters;
using System;
using System.Collections.Generic;

namespace OOP_and_architecture.Presentation
{
    class Program
    {
        static void Main(string[] args)
        {

            int action;
            string heroName;
            var monsterCollection = new Dictionary<int, Monster>();
            MonsterGenerator(monsterCollection);
            do
            {
                Console.WriteLine("\tGlavni izbornik:\n" +
                    "1. Odabir Heroja: \n" +
                    "0. Izlazak iz igre"); ;
                action = int.Parse(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        var heroSelected = SelectHeroType();
                        switch (heroSelected)
                        {
                            case 1:
                                heroName = Input("Unesite ime vaseg warriora: ");
                                var heroWarrior = new Warrior(heroName);
                                break;
                            case 2:
                                heroName = Input("Unesite ime vaseg magea: ");
                                var heroMage = new Mage(heroName);
                                break;
                            case 3:
                                heroName = Input("Unesite ime vaseg rangera: ");
                                var hero = new Ranger(heroName);
                                break;
                            default:
                                break;
                        }
                        break;
                    default:
                        break;
                }
            } while (action != 0);
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
                    if (passedOnce)
                    {
                        Console.WriteLine("Unesite broj ispred tipa heroja(0 za povratak): ");
                    }
                    action = int.Parse(Console.ReadLine());
                    passedOnce = true;
                } while (action < -1 || 3 < action);

                switch (action)
                {
                    case 1:
                        heroType = 1;
                        return heroType;
                    case 2:
                        heroType = 2;
                        return heroType;
                    case 3:
                        heroType = 3;
                        return heroType;
                    default:
                        heroType = 0;
                        break;
                }
            } while (action != 0);
            return heroType;
        }
        static void MonsterGenerator(Dictionary<int, Monster> monsterCollection)
        {
            var index = 0;
            var randomNumber = new Random();
            for (int i = 0; i < 10; i++)
            {
                GenerateMonster(monsterCollection, randomNumber.Next(), ref index);
            }
        }
        static void GenerateMonster(Dictionary<int, Monster> monsterCollection, int whichMonster, ref int index)
        {  
            var monster = new Monster();
            switch (whichMonster)
            {
                case 1:
                    monster = new Goblin();
                    monsterCollection.Add(index, monster);
                    index++;
                    break;
                case 2:
                    monster = new Witch();
                    monsterCollection.Add(index, monster);
                    index++;
                    break;
                case 3:
                    monster = new Brute();
                    monsterCollection.Add(index, monster);
                    index++;
                    break;
                default:
                    break;
            }
        }
    }
}
