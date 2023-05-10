using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Principles.Principles
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Academy { get; set; }
        public int Grade { get; set; }
        public bool HasProject { get; set; }
        public int Homeworks { get; set; }


        public bool CheckClassDay(string day)
        {
            if (Academy == "Code")
            {
                if (day == "monday" || day == "wednesday")
                    return true;
                return false;
            }
            else if (Academy == "Design")
            {
                if (day == "tuesday" || day == "wednesday" || day == "thursday")
                    return true;
                return false;
            }
            else if (Academy == "Network")
            {
                if (day == "monday" || day == "saturday")
                    return true;
                return false;
            }
            else
            {
                Console.WriteLine("No such academy");
                return false;
            }
        }


        public void GetStatus()
        {
            if (Academy == "Code")
            {
                if (HasProject)
                {
                    Console.WriteLine("The student works on project already!");
                }
                else
                {
                    Console.WriteLine("The student is not assigned to any project!");
                }
            }
            else if (Academy == "Design")
            {
                if (Homeworks > 3)
                {
                    Console.WriteLine("The student has most of their homeworks!");

                }
                else
                {
                    Console.WriteLine("The student need to do their homeworks!");
                }
            }
            else if (Academy == "Network")
            {
                if (Grade > 3)
                {
                    Console.WriteLine("The student is good!");
                }
                else
                {
                    Console.WriteLine("The student is bad!");
                }
            }
            else
            {
                // some code
            }
        }
    }


    public abstract class StudentGood
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AcademyType Academy { get; set; }

        public abstract bool CheckClassDay(string day);
        public abstract void GetStatus();
    }

    public class CodeStudent : StudentGood
    {
        public bool HasProject { get; set; }

        public override bool CheckClassDay(string day)
        {
            throw new NotImplementedException();
        }

        public override void GetStatus()
        {
            throw new NotImplementedException();
        }
    }

    public class DesignStudent : StudentGood
    {
        public int Homeworks { get; set; }

        public override bool CheckClassDay(string day)
        {
            throw new NotImplementedException();
        }

        public override void GetStatus()
        {
            throw new NotImplementedException();
        }
    }

    public class NetworkStudent : StudentGood
    {
        public int Grade { get; set; }

        public override bool CheckClassDay(string day)
        {
            throw new NotImplementedException();
        }

        public override void GetStatus()
        {
            throw new NotImplementedException();
        }
    }

    public enum AcademyType
    {
        Code,
        Network,
        Design
    }
}
