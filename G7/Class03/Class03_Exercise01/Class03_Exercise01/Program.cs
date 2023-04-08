using Models;

namespace Class03_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog d1 = new Dog()
            {
                Id = 1,
                Name = "Sharko",
                Color = "Black"
            };


            Dog d2 = new Dog()
            {
                Id = 2,
                Name = "Lucy",
                Color = "Brown/White"
            };

            Dog d3 = new Dog()
            {
                Id = 3,
                Name = "Pako",
                Color = "White"
            };

            Dog d4 = new Dog()
            {
                Id = 0,
                Name = "B",
                Color = "White"
            };

            //d4 = new Dog()
            //{
            //    Id = 4,
            //    Name = "Bbb",
            //    Color = "White"
            //};

            List<Dog> dogs = new List<Dog>()
            {
                d1, d2, d3, d4
            };

            foreach(Dog d in dogs)
            {
                if(Dog.Validate(d))
                {
                    DogShelter.Dogs.Add(d);
                }
            }

            Console.Write(DogShelter.PrintAll());

            //if(Dog.Validate(d1))
            //{
            //    DogShelter.Dogs.Add(d1);
            //}

            //if (Dog.Validate(d2))
            //{
            //    DogShelter.Dogs.Add(d2);
            //}

            //if (Dog.Validate(d3))
            //{
            //    DogShelter.Dogs.Add(d3);
            //}
        }
    }
}