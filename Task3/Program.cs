using System;

using Domain.Models;
using Domain.Enums;

using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>() {
                new Animal("Archie", "brown", 12, GenderEnum.Male),
                new Animal("Alice", "grey", 4, GenderEnum.Female),
                new Animal("Max", "white", 9, GenderEnum.Male),
                new Animal("Oliver", "grey", 2, GenderEnum.Male),
                new Animal("Lucy", "black", 3, GenderEnum.Female),
                new Animal("Daicy", "brown", 12, GenderEnum.Female),
                new Animal("LuckyRoverIII", "orange", 5, GenderEnum.Male),
                new Animal("Apollo", "white", 1, GenderEnum.Female),
                new Animal("Nala", "brown", 4, GenderEnum.Female),
                new Animal("Scout", "black", 7, GenderEnum.Male),
            };

            List<string> animalsOlderThanFive = animals.Where(animal => animal.Age >= 5).Select(animal => animal.Name).ToList();

            Console.WriteLine("===========Older than 5=========");
            foreach(string name in animalsOlderThanFive)
            {
                Console.WriteLine(name);
            }

            List<string> animalsStartingWithA = animals.Where(animal => animal.Name.StartsWith('A')).Select(animal => animal.Name).ToList();

            Console.WriteLine("===========Starts with A=========");
            foreach (string name in animalsStartingWithA)
            {
                Console.WriteLine(name);
            }

            List<string> animalsMaleAndBrown = animals.Where(animal => animal.Gender == GenderEnum.Male && animal.Color == "brown").Select(animal => animal.Name).ToList();

            Console.WriteLine("===========Male and brown color=========");
            foreach (string name in animalsMaleAndBrown)
            {
                Console.WriteLine(name);
            }

            List<string> animalNameLongerThan10 = animals.Where(animal => animal.Name.Length > 10).Select(animal => animal.Name).ToList();

            Console.WriteLine("===========Name longer than 10=========");
            Console.WriteLine(animalNameLongerThan10.First());




        }
    }
}
