namespace SEDC.Class14.Principles.Solid
{
    // Bad Example

    // Version 1 Requirements:
    // Add Code Student
    //  - Class Day (Monday & Friday)
    //  - Check Project Status

    // months pass by ...

    // Version 2 Requirements:

    // Add Network Student
    //  - Classes (Tuesday, Wednesday, Thursday)
    //  - Check Grade Status

    // Add Design Student
    //  - Classes (Monday & Saturday)
    //  - Check Homework Status

    public class Student
    {
        // Version 1 - Code Academy Only
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool HasProject { get; set; } // Code Academy Specific

        #region Added In Version 2

        // Version 2 - Adding More Academies
        public string Academy { get; set; }
        public int Grade { get; set; } // Network Academy Specific
        public int Homeworks { get; set; } // Design Academy Specific

        #endregion


        public bool CheckClassDay(string day)
        {
            #region Version 1

            // Version 1
            // The client has only one type of student, Code student
            if (day == "monday" || day == "friday")
                return true;

            return false;

            #endregion

            #region Version 2
            // Version 2
            // The client adds design student and they go in different days
            // The client after some time adds network student and they go in different days as well
            if (Academy == "Code")
            {
                if (day == "monday" || day == "friday")
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

            #endregion
        }

        public void GetStatus()
        {
            #region Version 1

            // Version 1
            // The client has only one type of student, Code student
            if (HasProject)
            {
                Console.WriteLine("Student has a project!");
            }
            else
            {
                Console.WriteLine("Student is still working on project!");
            }

            #endregion

            #region Version 2


            // Version 2
            // The client adds design student and they have different status to measure
            // The client after some time adds network student and they have different status to measure as well
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
                    Console.WriteLine("Student is still working on their homeworks!");
                }
            }
            else if (Academy == "networks")
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
            else
            {
                Console.WriteLine("No academy like that!");
            }

            #endregion
        }
    }




    // Open-Closed Principle (OCP)


    // Software entities (classes, methods, etc.) should be open for extension but closed for modification.
    // In other words, the behavior of a system can be extended without modifying its existing code


    // What will happen if we break OCP?
    // Modifying already existing working and tested code to accommodate new functionality can introduce bugs and unintended side effects.
    // Each modification increases the risk of introducing errors and can lead to a fragile codebase that requires extensive testing and debugging.




    // Good Example
    public abstract class StudentGood
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Academy Academy { get; set; }
        public abstract bool CheckClassDay(Day day);
        public abstract void GetStatus();
    }

    public class CodeStudent : StudentGood
    {
        public CodeStudent()
        {
            Academy = Academy.Code;
        }

        public bool HasProject { get; set; }

        public override bool CheckClassDay(Day day)
        {
            if (day == Day.Monday || day == Day.Friday)
                return true;

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

    public class DesignStudent : StudentGood
    {
        public DesignStudent()
        {
            Academy = Academy.Design;
        }

        public int Homeworks { get; set; }

        public override bool CheckClassDay(Day day)
        {
            if (day == Day.Tuesday || day == Day.Wednesday || day == Day.Thursday)
                return true;

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
                Console.WriteLine("Student is still working on their homeworks!");
            }
        }
    }


    public class NetworkStudent : StudentGood
    {
        public NetworkStudent()
        {
            Academy = Academy.Networks;
        }

        public int Grade { get; set; }

        public override bool CheckClassDay(Day day)
        {
            if (day == Day.Monday || day == Day.Saturday)
                return true;

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


    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }


    public enum Academy
    {
        None,
        Code,
        Design, // 2nd version
        Networks // 2nd version
    }
}