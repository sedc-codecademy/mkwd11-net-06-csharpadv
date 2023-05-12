namespace SOLID
{
    /*
        *** OPEN-CLOSED PRINCIPLE ***
   
            *Open* for extension 
            *Closed* for modification 
         
        => Business requirements change !!!
        => This means that we need to look a bit in the future when writing our code and strive to make it generic and modular

        => The software should be flexible to change
        => New features should be implemented using the new code, but not by changing existing code 
        => IN PRACTICE THIS IS VERY HARD TO KEEP UP TO SO ===> make as less changes as possible to the existing code and make your code as flexibile as possible
     */

    #region Without OCP (BAD EXAMPLE)
    class Studentt
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Academy { get; } = "Code";
        public bool HasProject { get; set; }

        //added additionaly
        public int Grade { get; set; }
        public int Homeworks { get; set; }

        public bool CheckClassDay(string day)
        {
            // The initial implementation
            // The client has only one type of student, Code student
            if (day == "monday" || day == "friday") return true;
            return false;

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
    #endregion

    #region With OCP (GOOD EXAMPLE)
    // This is the initial student added
    abstract class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AcademyType Academy { get; set; }
        public abstract bool CheckClassDay(string day);
        public abstract void GetStatus();
    }

    enum AcademyType
    {
        None,
        Code,
        Design, // we add this when the client requests Design academy to be added
        Networks // we add this when the client requests Networks academy to be added
    }

    // This is the first student type
    class CodeStudent : Student
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
    class DesignStudent : Student
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
    class NetworkStudent : Student
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
    #endregion

}
