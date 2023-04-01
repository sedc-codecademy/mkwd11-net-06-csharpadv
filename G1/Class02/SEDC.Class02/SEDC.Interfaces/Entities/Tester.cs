using SEDC.Interfaces.Entities.Interfaces;

namespace SEDC.Interfaces.Entities
{
    public class Tester : ITester
    {
        public void Test()
        {
            Console.WriteLine("Testing application.");
        }
    }
}
