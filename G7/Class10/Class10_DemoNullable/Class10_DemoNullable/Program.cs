using System.Runtime.CompilerServices;

namespace Class10_DemoNullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "Risto";
            bool? employed;

            employed = true;
            employed = false;
            employed = null;

            int? counter = null;

            if(counter != null)
            {
                //do the check
            }

            if(counter == null)
            {
                //throw exception
                //alert the user that needs to input something
            }

            Invoice i = new Invoice
            {
                Number = "12345"
            };

            if(i.State == null)
            {
                Console.WriteLine("We have not received this invoice");
            }

            if(!i.State.HasValue)
            {
                Console.WriteLine("We have not received this invoice");
            }
        }
    }
}