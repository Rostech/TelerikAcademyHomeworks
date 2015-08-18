
namespace AnimalHierarchy
{
    using System;
    using AnimalHierarchy.Models;
    using AnimalHierarchy.Enumerations;

    class RunAnimalHierarchy
    {
        /*
         3. Animal hierarchy

            Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
            All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. All animals are described by age, 
            name and sex. Kittens can be only female and tomcats can be only male. Each animal produces a specific sound.
            Create arrays of different kinds of animals and calculate the average age of each kind of animal using a static method (you may use LINQ).

        */

        static void Main()
        {
            var arrWithCats = new Cat[]
            {
                new Cat(14, "Gosho", Sex.Male),
                new Cat(6, "Mialcho", Sex.Male),
                new Cat(10, "Misha", Sex.Female),
                new Cat(9, "Joystick", Sex.Male),
                new Cat(14, "Macka", Sex.Female)
            };

            Console.ForegroundColor = ConsoleColor.Magenta;
            foreach (var item in arrWithCats)
            {
                Console.WriteLine(item.ProduceSount());
            }
            Console.WriteLine("Average ange of all cats : " + Animal.AverageAge(arrWithCats) + "\n");

            var arrWithKittens = new Kitten[]
            {
                new Kitten(2, "Peshka"),
                new Kitten(1, "Mimka"),
                new Kitten(3, "Dimitrinka"),
                new Kitten(1, "Skilitka")
            };

            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (var item in arrWithKittens)
            {
                Console.WriteLine(item.ProduceSount());
            }
            Console.WriteLine("Average ange of all kittens : " + Animal.AverageAge(arrWithKittens) + "\n");

            var arrWithTomcats = new Tomcat[]
            {
                new Tomcat(1, "Stamatcho"),
                new Tomcat(2, "Metadoncho"),
                new Tomcat(1, "Ivelincho"),
            };

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (var item in arrWithTomcats)
            {
                Console.WriteLine(item.ProduceSount());
            }
            Console.WriteLine("Average ange of all tomcats : " + Animal.AverageAge(arrWithTomcats) + "\n");
            
            var arrWithDogs = new Dog[]
            {
                new Dog(1, "Sharo", Sex.Male),
                new Dog(2, "Pincho", Sex.Male),
                new Dog(3, "Kalina", Sex.Female),
                new Dog(4, "Steven", Sex.Male),
                new Dog(5, "MIla", Sex.Female),
            };

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (var item in arrWithDogs)
            {
                Console.WriteLine(item.ProduceSount());
            }
            Console.WriteLine("Average ange of all dogs : " + Animal.AverageAge(arrWithDogs) + "\n");

            var arrWithFrogs = new Frog[]
            {
                new Frog(1, "Japcho", Sex.Male),
                new Frog(2, "Kwa", Sex.Male),
                new Frog(3, "Japka", Sex.Female),
                new Frog(4, "Jaburan", Sex.Male),
                new Frog(5, "Roberta", Sex.Female),
            };

            Console.ForegroundColor = ConsoleColor.Green;
            foreach (var item in arrWithFrogs)
            {
                Console.WriteLine(item.ProduceSount());
            }
            Console.WriteLine("Average ange of all frogs : " + Animal.AverageAge(arrWithFrogs) + "\n");
        }
    }
}
