using Models;
using Models.Enum;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Linq;

namespace AdvanceLinq_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, BreedEnum.Collie), // 0
                new Dog("Buddy", "Brown", 1, BreedEnum.Doberman),
                new Dog("Max", "Olive", 1, BreedEnum.Plott),
                new Dog("Archie", "Black", 2, BreedEnum.Mutt),
                new Dog("Oscar", "White", 1, BreedEnum.Mudi),
                new Dog("Toby", "Maroon", 3, BreedEnum.Bulldog), // 5
                new Dog("Ollie", "Silver", 4, BreedEnum.Dalmatian),
                new Dog("Bailey", "White", 4, BreedEnum.Pointer),
                new Dog("Frankie", "Gray", 2, BreedEnum.Pug),
                new Dog("Jack", "Black", 5, BreedEnum.Dalmatian),
                new Dog("Chanel", "Black", 1, BreedEnum.Pug), // 10
                new Dog("Henry", "White", 7, BreedEnum.Plott),
                new Dog("Bo", "Maroon", 1, BreedEnum.Boxer),
                new Dog("Scout", "Olive", 2, BreedEnum.Boxer),
                new Dog("Ellie", "Brown", 6, BreedEnum.Doberman),
                new Dog("Hank", "Silver", 2, BreedEnum.Collie), // 15
                new Dog("Shadow", "Silver", 3, BreedEnum.Mudi),
                new Dog("Diesel", "Brown", 4, BreedEnum.Bulldog),
                new Dog("Abby", "Black", 1, BreedEnum.Dalmatian),
                new Dog("Trixie", "White", 8, BreedEnum.Pointer), // 19
            };

            List<Person> people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, JobEnum.Choreographer),
                new Person("Rick", "Chapman", 35, JobEnum.Dentist),
                new Person("Oswaldo", "Wilson", 19, JobEnum.Developer),
                new Person("Kody", "Walton", 43, JobEnum.Sculptor),
                new Person("Andreas", "Weeks", 17, JobEnum.Developer),
                new Person("Kayla", "Douglas", 28, JobEnum.Developer),
                new Person("Richie", "Campbell", 19, JobEnum.Waiter),
                new Person("Soren", "Velasquez", 33, JobEnum.Interpreter),
                new Person("August", "Rubio", 21, JobEnum.Developer),
                new Person("Rocky", "Mcgee", 57, JobEnum.Barber),
                new Person("Emerson", "Rollins", 42, JobEnum.Choreographer),
                new Person("Everett", "Parks", 39, JobEnum.Sculptor),
                new Person("Amelia", "Moody", 24, JobEnum.Waiter)
                { Dogs = new List<Dog>() {dogs[16], dogs[18] } },
                new Person("Emilie", "Horn", 16, JobEnum.Waiter),
                new Person("Leroy", "Baker", 44, JobEnum.Interpreter),
                new Person("Nathen", "Higgins", 60, JobEnum.Archivist)
                { Dogs = new List<Dog>(){dogs[6], dogs[0] } },
                new Person("Erin", "Rocha", 37, JobEnum.Developer)
                { Dogs = new List<Dog>() {dogs[2], dogs[3], dogs[19] } },
                new Person("Freddy", "Gordon", 26, JobEnum.Sculptor)
                { Dogs = new List<Dog>() {dogs[4], dogs[5], dogs[10], dogs[12], dogs[13] } },
                new Person("Valeria", "Reynolds", 26, JobEnum.Dentist),
                new Person("Cristofer", "Stanley", 28, JobEnum.Dentist)
                { Dogs = new List<Dog>() {dogs[9], dogs[14], dogs[15] } }
            };

            //Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            List<Person> resultQ1 = people.Where(x => x.FirstName.StartsWith("R")).OrderByDescending(x => x.Age).ToList();
            PrintPeople(resultQ1);

            //Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            //List<Dog> resultQ2 = dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).ToList();
            //dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).Select(x =>
            //{
            //    Console.WriteLine($"{x.Name} - {x.Age}");
            //    return x;
            //}).ToList();

            List<string> resultQ2Formatted = dogs.Where(x => x.Color == "Brown" && x.Age > 3).OrderBy(x => x.Age).Select(x =>
            {
                return $"{x.Name} - {x.Age}";
            }).ToList();


            Console.WriteLine(string.Join("| ", resultQ2Formatted));

            //Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER
            List<Person> resultQ3 = people.Where(x => x.Dogs.Count > 2).OrderByDescending(x => x.FirstName).ToList();
            PrintPeople(resultQ3);

            //Find and print all Freddy`s dogs names older than 1 year
            Person freddy = people.First(x => x.FirstName == "Freddy");
            List<Dog> freddyDogs = freddy.Dogs.Where(x => x.Age > 1).ToList();

            freddyDogs.ForEach(x =>
            {
                Console.WriteLine(x.Name);
            });

            //Find and print Nathen`s first dog
            Person nathen = people.First(x => x.FirstName == "Nathen");
            Dog nathenDog = nathen.Dogs.First();
            Console.WriteLine(nathenDog.GetInfo());

            //Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            //List<Person> subsetPeople = people.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia").ToList();

            //List<Dog> whiteDogs = new List<Dog>();

            //foreach (Person person in subsetPeople)
            //{
            //    List<Dog> whiteDogsSubset = person.Dogs.Where(x => x.Color == "White").ToList();

            //    whiteDogs.AddRange(whiteDogsSubset);
            //}

            //foreach(Dog d in whiteDogs.OrderBy(x => x.Name))
            //{
            //    Console.WriteLine(d.Name);
            //}

            //List<Dog> dogsOf4People = people.Where(x => x.FirstName == "Cristofer" || x.FirstName == "Freddy" || x.FirstName == "Erin" || x.FirstName == "Amelia").SelectMany(x => x.Dogs).ToList();

            //List<Dog> whiteDogsOf4People = people.Where(x => x.FirstName == "Cristofer" 
            //                                                || x.FirstName == "Freddy" 
            //                                                || x.FirstName == "Erin" 
            //                                                || x.FirstName == "Amelia")
            //                                      .SelectMany(x => x.Dogs)
            //                                      .Where(x => x.Color == "White")
            //                                      .ToList();

            //1. Filter only 4 people out of all people
            //2. Get only the dogs using the SelectMany for the filtered people, and merge them in one result list => All dogs for the 4 selected people
            //3. Filter the result list of all dogs to get only the white once
            //4. Order the result list of white dogs by dog's name, asc
            //5. ToList() => execute the query and get the result list
            //6. Iterate trough the list of white dogs ordered by name, and print them.
            people.Where(x => x.FirstName == "Cristofer"
                           || x.FirstName == "Freddy"
                           || x.FirstName == "Erin"
                           || x.FirstName == "Amelia")
                 .SelectMany(x => x.Dogs)
                 .Where(x => x.Color == "White")
                 .OrderBy(x => x.Name)
                 .ToList()
                 .ForEach(x => Console.WriteLine(x.Name));
        }

        static void PrintPeople(List<Person> list)
        {
            foreach (Person p in list)
            {
                Console.WriteLine(p.GetInfo());
            }
        }
    }
}