namespace SEDC.Class14.Principles.Solid
{
    // Bad Example
    public class StringComparing
    {
        public StringComparing(string str1, string str2)
        {
            FirstString = str1;
            SecondString = str2;
        }

        protected string FirstString { get; set; }
        protected string SecondString { get; set; }


        public void Compare()
        {
            if (FirstString.Length > SecondString.Length)
            {
                Console.WriteLine("The first is larger");
            }
            else if (FirstString.Length < SecondString.Length)
            {
                Console.WriteLine("The second is larger");
            }
            else
            {
                Console.WriteLine("They are the same");
            }
        }
    }

    public class LettersStringComparing : StringComparing
    {
        public LettersStringComparing(string str1, string str2) : base(str1, str2) { }

        public void Compare()
        {
            if (FirstString.First() == SecondString.First())
            {
                Console.WriteLine("They start with the same letter");
            }
            else
            {
                Console.WriteLine("They don't start with the same letter");
            }
        }
    }

    public class LiskovSubstitutionAppBad
    {
        public void Run()
        {
            // Works
            Console.WriteLine("Example 1:");

            StringComparing strComp1 = new StringComparing("Bob", "Jill");
            strComp1.Compare();

            LettersStringComparing letterStrComp1 = new LettersStringComparing("Bob", "Jill");
            letterStrComp1.Compare();

            // Problem
            StringComparing strCompPolymorph1 = new LettersStringComparing("Bob", "Jill");
            strCompPolymorph1.Compare();
        }
    }

    // Liskov Substitution Principle (LSP)

    // Objects of a superclass should be replaceable with objects of its subclass without affecting the correctness of the program.

    // Benefits:
    // - Easy Polymorphism
    // - Code Reusability
    // - Code Maintainability



    // Continue with the good example here ...




}
