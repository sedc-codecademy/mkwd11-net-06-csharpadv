namespace Polymorphism.Entities
{
    public class Developer : Person
    {
        public override void SayHello()
        {
            //this executes the code from the SayHello() from the Person class
            //base.SayHello();
            Console.WriteLine("Hello brother.");
        }
    }
}
