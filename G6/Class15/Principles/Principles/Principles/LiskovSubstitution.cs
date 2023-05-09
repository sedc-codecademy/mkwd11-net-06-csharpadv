namespace Principles.Principles
{
    // Bad Example
    public class StringComparing
    {
        protected string _firstString;
        protected string _secondString;
        public StringComparing(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }
        public void Compare()
        {
            if (_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first is larger");
            }
            else if (_firstString.Length < _secondString.Length)
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
        public LettersStringComparing(string str1, string str2)
            : base(str1, str2) { }
        public void Compare()
        {
            if (_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with the same letter");
            }
            else
            {
                Console.WriteLine("They don't start with the same letter");
            }
        }
    }
    public class App
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
    // Good Example
    public abstract class StringComparingGood
    {
        protected string _firstString;
        protected string _secondString;
        public StringComparingGood(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }
        public abstract void Compare();
    }
    public class LengthStringComparing : StringComparingGood
    {
        public LengthStringComparing(string str1, string str2)
            : base(str1, str2) { }

        public override void Compare()
        {
            if (_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first is larger");
            }
            else if (_firstString.Length < _secondString.Length)
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
        public LettersStringComparingGood(string str1, string str2)
            : base(str1, str2) { }

        public override void Compare()
        {
            if (_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with the same letter");
            }
            else
            {
                Console.WriteLine("They don't start with the same letter");
            }
        }
    }
    public class AppGood
    {
        public void Run()
        {
            // Works
            Console.WriteLine("Example 2:");
            LengthStringComparing strComp2 = new LengthStringComparing("Bob", "Jill");
            strComp2.Compare();
            LettersStringComparingGood letterStrComp2 = new LettersStringComparingGood("Bob", "Jill");
            letterStrComp2.Compare();
            // Not a Problem any more
            StringComparingGood strCompPolymorph2 = new LettersStringComparingGood("Bob", "Jill");
            StringComparingGood strCompPolymorph3 = new LengthStringComparing("Bob", "Jill");
            strCompPolymorph3.Compare();
            strCompPolymorph2.Compare();
        }
    }
}
