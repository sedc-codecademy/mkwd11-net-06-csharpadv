using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate void SayDelegate(string something);
    public delegate int NumbersDelegate(int num1, int num2);

    public class DelegateClass
    {
        public void Run() 
        {
            SayDelegate del = new SayDelegate(SayHello);
            SayDelegate bye = new SayDelegate(SayBye);
            SayDelegate wow = new SayDelegate(person => Console.WriteLine($"Wow {person}"));

            del("Viktor");
            bye("Dragan");
            wow("Petar");

            SayWhatever("Bob", SayHello);
            SayWhatever("Jill", SayBye);
            SayWhatever("Greg", person => Console.WriteLine($"Wow {person}"));

            NumberMaster(2, 5, (x, y) => x + y);
            NumberMaster(2, 5, (x, y) => x - y);
            NumberMaster(2, 5, (x, y) => 0);
            NumberMaster(12, 5, (x, y) => 
            {
                if (x > y) 
                {
                    return x;
                }

                return y;
            });

            Console.ReadLine();
        }

        private void SayHello(string person)
        {
            Console.WriteLine($"Hello {person}");
        }

        private void SayBye(string person) 
        {
            Console.WriteLine($"Bye {person}");
        }

        private void SayWhatever(string whatever, SayDelegate sayDel) 
        {
            Console.WriteLine("Chatbot says: ");
            sayDel(whatever);
        }

        private void NumberMaster(int num1, int num2, NumbersDelegate numberDel) 
        {
            var result = numberDel(num1, num2);
            Console.WriteLine($"The result is {result}");
        }
    }
}
