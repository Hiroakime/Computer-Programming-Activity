using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            Activity activity = new Activity();
            activity.RunMethod();
            Console.ReadKey();
        }
    }

    public class Activity
    {
       public class Persons
        {
           public string Name {get; set;}

           public int Age {get; set;}
        }

        List<Persons> persons = new List<Persons>();

        public void RunMethod()
        {
            persons.Add(new Persons {Name = "Kurt", Age = 15});
            persons.Add(new Persons {Name = "Carl", Age = 23});
            persons.Add(new Persons {Name = "JK", Age = 45});
            persons.Add(new Persons {Name = "James", Age = 60});
            persons.Add(new Persons {Name = "Kelvin", Age = 39});
            persons.Add(new Persons {Name = "Haze", Age = 18});
            persons.Add(new Persons {Name = "Gaze", Age =  10});
            persons.Add(new Persons {Name = "Soap", Age = 20});
            persons.Add(new Persons {Name = "Price", Age = 23});
            persons.Add(new Persons {Name = "McQueen", Age = 80});
            persons.Add(new Persons {Name = "Bascreveil", Age = 50});

            System.Console.WriteLine("Enter an Age: ");
            if (int.TryParse(Console.ReadLine(), out int inputAge))
            {
                var lowerage = persons.Where(p => p.Age < inputAge);

                Console.WriteLine($"Persons with the lower age than {inputAge}");

                foreach (var persons in lowerage)
                {
                    Console.WriteLine($"Name: {persons.Name} Age: {persons.Age}");
                }
            }
            else
            {
                System.Console.WriteLine("Invalid input.");
            }

        }

    }
}