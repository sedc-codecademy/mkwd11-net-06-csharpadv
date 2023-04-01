using SEDC.Interfaces.Entities.Interfaces;

namespace SEDC.Interfaces.Entities
{
    public class Developer : IDeveloper
    {
        public void Code()
        {
            Console.WriteLine("Developing application.");
        }
    }
}
