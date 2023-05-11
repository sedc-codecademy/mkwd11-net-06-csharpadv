namespace SEDC.Class14.Principles.Solid
{
    // Bad Example

    // Superclass/Base class
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


    // Subclass/Derived class
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



    // Good Example

    public abstract class StringComparingGood
    {
        public StringComparingGood(string firstString, string secondString)
        {
            FirstString = firstString;
            SecondString = secondString;
        }

        protected string FirstString { get; set; }
        protected string SecondString { get; set; }

        public abstract void Compare();
    }


    public class LengthStringComparing : StringComparingGood
    {
        public LengthStringComparing(string firstString, string secondString) : base(firstString, secondString) { }

        public override void Compare()
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


    public class LettersStringComparingGood : StringComparingGood
    {
        public LettersStringComparingGood(string firstString, string secondString) : base(firstString, secondString) { }

        public override void Compare()
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

    public class LiskovSubstitutionAppGood
    {
        public void Run()
        {
            Console.WriteLine("Example 2:");

            LengthStringComparing lengthComp1 = new LengthStringComparing("Bob", "Jill");
            lengthComp1.Compare();

            LettersStringComparingGood lettersStringComp1 = new LettersStringComparingGood("Bob", "Jill");
            lettersStringComp1.Compare();

            StringComparingGood strCompPolymorp1 = new LengthStringComparing("Bob", "Jill");
            strCompPolymorp1.Compare();

            StringComparingGood strCompPolymorp2 = new LettersStringComparingGood("Bob", "Jill");
            strCompPolymorp2.Compare();
        }
    }
}
