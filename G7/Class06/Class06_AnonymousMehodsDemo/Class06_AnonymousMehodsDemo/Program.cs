namespace Class06_AnonymousMehodsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string> { "risto", "tijana", "martin", "frosina", "ana" };

            List<string> filteredNames = names.Where(x => x.Contains("na")).ToList();

            //last argument of the gerneric Class Func is the Data type of the return type. The others that are not last, are the data types of the input variables
            Func<string, bool> compareFunc = (x) => x.Contains("na");

            List<string> filterNames1 = names.Where(compareFunc).ToList();

            //This Func has only a return type (int), does not have any input arguments
            Func<int> sumFiveAndTwo = () => 2 + 5;

            int result = sumFiveAndTwo();

            Action<int> callback = (number) => Console.WriteLine($"Result: {number}");

            Sum(7, 8, callback);

            //Action is a generic class for creating anonymous methods that do not return anything, and accept 0 - * input arguments
            Action plainHelloWorld = () => Console.WriteLine("Hello world");
            Action<string, int> counterPrinting = (text, number) => Console.WriteLine($"{text}: {number}");

            counterPrinting("The number of students is", 6);


            //a = 3, 3*3*3
            //a = 3, b = 4, c = 5, 3 * 4 * 5;

            Func<int, int, int, int> volumeOfCuboid = (a, b, c) => a * b * c;

            int volume = volumeOfCuboid(3, 4, 5);

            counterPrinting("Volume is", volume);

            Action<string, int> printMultipleTimes = (text, repeats) =>
            {
                for(int i = 0; i < repeats; i++)
                {
                    Console.WriteLine(text);
                }
            };

            printMultipleTimes("Hello all!", 5);

            //Func<int, int, int> calculateArea = (a, b) => a * b;

            Func<int, int, int> calculateArea = (a, b) =>
            {
                Console.WriteLine($"Calculating the area of a rectangle with sides {a} and {b}...");

                return a * b;
            };

            Console.WriteLine(calculateArea(5, 6));
            //Calculating the area of a rectangle with sides {5} and {6}...
            //30


            Action<List<Person>> printAllItems = (list) =>
            {
                foreach(Person p in list)
                {
                    Console.WriteLine($"{p.FirstName} {p.LastName}");
                }
            };

            List<Person> pList = new List<Person>
            {
                new Person {  FirstName = "Test", LastName = "Test"},
                new Person {  FirstName = "Test1", LastName = "Test1"},
                new Person {  FirstName = "Test2", LastName = "Test2"},
                new Person {  FirstName = "Test3", LastName = "Test3"},
            };

            printAllItems(pList);
        }

        static void Sum(int a, int b, Action<int> printCallbackFunction)
        {
            int result = a + b;
            printCallbackFunction(result);
        }
    }
}