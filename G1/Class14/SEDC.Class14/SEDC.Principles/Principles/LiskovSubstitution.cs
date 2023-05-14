using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Principles.Principles
{
    // Bad example
    public class StringComparerr
    {
        protected string _firstString;
        protected string _secondString;


        public StringComparer(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }

        public void Compare()
        {
            if(_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first string is larger.");
            }
            else if(_secondString.Length > _firstString.Length) 
            {
                Console.WriteLine("The second string is larger.");
            }
            else
            {
                Console.WriteLine("They are same");
            }
        }
    }

    public class LetterStringComparing : StringComparer
    {
        public LetterStringComparing(string str1, string str2) 
            : base(str1, str2)
        {

        }

        public void Compare()
        {
            if(_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with same letter.");
            }
            else
            {
                Console.WriteLine("They don't start with same letter.");
            }
        }
    }



    public class AppBadExample
    {
        public static void Run()
        {
            Console.WriteLine("Bad example:");
            StringComparer strComp1 = new StringComparer("Bob", "Jill");
            strComp1.Compare();

            LetterStringComparing letterStrComp = new LetterStringComparing("Bob", "Jill");
            letterStrComp.Compare();

            StringComparer strCompPoly = new LetterStringComparing("Bob", "Jill");
            strCompPoly.Compare();

        }
    }


    public abstract class StringComparerGood
    {
        protected string _firstString;
        protected string _secondString;

        public StringComparerGood(string str1, string str2)
        {
            _firstString = str1;
            _secondString = str2;
        }

        public abstract void Compare();
    }

    public class StringLengthComparer : StringComparerGood
    {

        public StringLengthComparer(string str1, string str2)
            : base(str1, str2)
        {
            
        }

        public override void Compare()
        {
            if (_firstString.Length > _secondString.Length)
            {
                Console.WriteLine("The first string is larger.");
            }
            else if (_secondString.Length > _firstString.Length)
            {
                Console.WriteLine("The second string is larger.");
            }
            else
            {
                Console.WriteLine("They are same");
            }
        }
    }

    public class StringLetterComparer : StringComparerGood
    {
        public StringLetterComparer(string str1, string str2)
          : base(str1, str2)
        {

        }

        public override void Compare()
        {
            if (_firstString.First() == _secondString.First())
            {
                Console.WriteLine("They start with same letter.");
            }
            else
            {
                Console.WriteLine("They don't start with same letter.");
            }
        }
    }


    public class AppGoodExample
    {
        public static void Run()
        {
            Console.WriteLine("============== GOOD EXAMPLE =============");
            Console.WriteLine("Good example:");
            StringLengthComparer strComp1 = new StringLengthComparer("Bob", "Jill");
            strComp1.Compare();

            StringLetterComparer letterStrComp = new StringLetterComparer("Bob", "Jill");
            letterStrComp.Compare();

            StringComparerGood strLetterCompare = new StringLetterComparer("Martin", "Marija");
            StringComparerGood strComp = new StringLengthComparer("Jill", "Bob");
            strComp.Compare();
            strLetterCompare.Compare();
        }
    }
}
