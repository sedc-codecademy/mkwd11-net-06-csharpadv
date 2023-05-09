namespace Principles.Principles
{
    // Bad Example
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; set; }
        public int Grade { get; set; }
        public bool HasProject { get; set; }
        public int Homeworks { get; set; }

        public bool CheckClassDay(string day)
        {
            // The initial implementation
            // The client has only one type of student, Code student
            if (day == "monday" || day == "friday") return true;
            //return false;

            // A new implementation for the same thing
            // The client adds design student and they go in different days
            if (Academy == "Code")
            {
                if (day == "monday" || day == "friday") return true;
                return false;
            }
            else if (Academy == "Design")
            {
                if (day == "tuesday" || day == "wednesday" || day == "thirsday") return true;
                return false;
            }
            else if (Academy == "Network") // The client after some time adds network studen and they go in different days as well
            {
                if (day == "monday" || day == "saturday") return true;
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
            // The client has only one type of student, Code student
            if (HasProject)
            {
                Console.WriteLine("Student has a project!");
            }
            else
            {
                Console.WriteLine("Student is still working on project!");
            }

            // The client adds design student and they have different status to measure
            if (Academy == "code")
            {
                if (HasProject)
                {
                    Console.WriteLine("Student has a project!");
                }
                else
                {
                    Console.WriteLine("Student is still working on project!");
                }
            }
            else if (Academy == "design")
            {
                if (Homeworks > 3)
                {
                    Console.WriteLine("Student has most of their homeworks!");
                }
                else
                {
                    Console.WriteLine("Student is still wroking on their homeworks!");
                }
            }
            else if (Academy == "networks") // The client after some time adds network studen and they have different status to measure as well
            {
                if (Grade > 3)
                {
                    Console.WriteLine("Student is doing well!");
                }
                else
                {
                    Console.WriteLine("Student needs improvement!");
                }
            }
            else { Console.WriteLine("No academy like that!"); }
        }
    }

    // Good Example
    // This is the iniial student added
    public abstract class StudentGood
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AcademyType Academy { get; set; }
        public abstract bool CheckClassDay(string day);
        public abstract void GetStatus();
    }
    // This is the furst student type
    public class CodeStudent : StudentGood
    {
        public bool HasProject { get; set; }
        public CodeStudent()
        {
            Academy = AcademyType.Code;
        }

        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "friday") return true;
            return false;
        }

        public override void GetStatus()
        {
            if (HasProject)
            {
                Console.WriteLine("Student has a project!");
            }
            else
            {
                Console.WriteLine("Student is still working on project!");
            }
        }
    }
    // We add the next student without changing the implementation that worked before ( Student )
    public class DesignStudent : StudentGood
    {
        public int Homeworks { get; set; }
        public DesignStudent()
        {
            Academy = AcademyType.Design;
        }
        public override bool CheckClassDay(string day)
        {
            if (day == "tuesday" || day == "wednesday" || day == "thirsday") return true;
            return false;
        }

        public override void GetStatus()
        {
            if (Homeworks > 3)
            {
                Console.WriteLine("Student has most of their homeworks!");
            }
            else
            {
                Console.WriteLine("Student is still wroking on their homeworks!");
            }
        }
    }
    // We can again add new implementation without changing the previous one 
    public class NetworkStudent : StudentGood
    {
        public int Grade { get; set; }
        public NetworkStudent()
        {
            Academy = AcademyType.Networks;
        }
        public override bool CheckClassDay(string day)
        {
            if (day == "monday" || day == "saturday") return true;
            return false;
        }

        public override void GetStatus()
        {
            if (Grade > 3)
            {
                Console.WriteLine("Student is doing well!");
            }
            else
            {
                Console.WriteLine("Student needs improvement!");
            }
        }
    }

    public enum AcademyType
    {
        None,
        Code,
        Design, // we add this when the client requests Design academy to be added
        Networks // we add this when the client requests Networks academy to be added
    }
}
