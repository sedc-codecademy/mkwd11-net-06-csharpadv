namespace Generic_Demo01
{
    public class Person
    {
        public string Name { get; set; }

        //Overriding a method from an Object class (class that everything in C# inherits from)
        public override string ToString()
        {
            return Name;
        }
    }
}
