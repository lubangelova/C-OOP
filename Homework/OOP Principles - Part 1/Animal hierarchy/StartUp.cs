using System;
using System.Collections.Generic;
using System.Linq;

namespace Animal_hierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cat1 = new Cat("Tommy", 2, SexType.male);
            var cat2 = new Cat("Catty", 3, SexType.female);
            var dog1 = new Dog("Rex", 3, SexType.male);
            var dog2 = new Dog("Johny", 4, SexType.male);
            var frog1 = new Frog("Frogy", 1, SexType.female);
            var frog2 = new Frog("Jabka", 1, SexType.female);
            var kitten = new Kitten("Kitty", 1);
            var tomCat = new Tomcat("TomCat", 2);
            Console.WriteLine(cat1.ToString());
            Console.WriteLine(dog1.ToString());
            Console.WriteLine(frog1.ToString());
            Console.WriteLine(kitten.ToString());
            Console.WriteLine(tomCat.ToString());
            cat1.Sound();
            dog1.Sound();
            frog1.Sound();
            kitten.Sound();
            tomCat.Sound();

            var listOfAnimals = new List<Animals> { dog1, dog2, cat1, cat2, frog1, frog2, kitten, tomCat };
            var dogs = listOfAnimals.Where(d => d is Dog);
            var cats = listOfAnimals.Where(c => c is Cat);
            var frogs = listOfAnimals.Where(f => f is Frog);

            Console.WriteLine($"Dogs avarage age is: {Dog.CalculateAverageAge(dogs)}");
            Console.WriteLine($"Cats avarage age is: {Cat.CalculateAverageAge(cats)}");
            Console.WriteLine($"Frogs avarage age is: {Frog.CalculateAverageAge(frogs)}");

        }
    }
}
