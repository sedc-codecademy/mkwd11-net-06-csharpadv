using Models;

namespace Class03_PolymorphismDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat c = new Cat();
            c.Name = "Tom";
            c.Age = 5;

            Dog d = new Dog();
            d.Name = "Lucy";
            d.Color = "Brown\\White";

            Pet p = new Pet();
            p.Name = "Jerry";

            Console.WriteLine(c.Eat());
            Console.WriteLine(d.Eat());
            Console.WriteLine(p.Eat());

            PetService service = new PetService();

            Console.WriteLine(service.PetStatus(c, "Zdravo"));
            Console.WriteLine(service.PetStatus(c));
            Console.WriteLine(service.PetStatus(d));
            Console.WriteLine(service.PetStatus());
        }
    }
}