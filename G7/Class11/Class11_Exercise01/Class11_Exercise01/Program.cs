namespace Class11_Exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database<Dog> dogsDatabase = new Database<Dog>();

            while (true)
            {
                try
                {
                    Console.WriteLine("Choose an option:");
                    Console.WriteLine("1. Insert new dog");
                    Console.WriteLine("2. List all dogs");
                    Console.WriteLine("3. Exit");
                    Console.Write("Your selection: ");
                    string option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            {
                                Console.Write("Name: ");
                                string name = Console.ReadLine();

                                Console.Write("Age: ");
                                if (!int.TryParse(Console.ReadLine(), out int age))
                                {
                                    throw new ArgumentException("Wrong input for age!");
                                }

                                Console.Write("Color: ");
                                string color = Console.ReadLine();

                                //validation whether a dog with that name already exists in our database;
                                List<Dog> dogs = dogsDatabase.GetAll();

                                //Dog dog = dogs.FirstOrDefault(x => x.Name.ToLower() == name.ToLower());

                                //if(dog != null)
                                //{
                                //    throw new Exception("Dog with that name exists!");
                                //}

                                if(dogs.Any(x => string.Equals(x.Name, name, StringComparison.InvariantCultureIgnoreCase)))
                                {
                                    throw new ArgumentException("Dog with that name exists!");
                                }

                                Dog newDog = new Dog(name, age, color);

                                dogsDatabase.Insert(newDog);

                                break;
                            }
                        case "2":
                            {
                                List<Dog> dogs = dogsDatabase.GetAll();

                                foreach(Dog dog in dogs)
                                {
                                    Console.WriteLine(dog.GetInfo());
                                }

                                break;
                            }
                        case "3":
                            {
                                return;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option is selected. Please try again");
                                break;
                            }
                    }

                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry, an error happend. Please try again.");
                }
            }
        }
    }
}