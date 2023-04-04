using Models;

namespace AbstractClass_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Developer developer = new Developer("Risto", "Panchevski", "Skope", DateTime.Now.AddYears(-33), "070123456", 9, "C#");

            Console.WriteLine(developer.GetProfessionalInfo());
            Console.WriteLine(developer.GetInfo());

            QaEngineer qa = new QaEngineer()
            {
                FirstName = "Test",
                LastName = "Test",
                Address = "Skopje",
                DateOfBirth = DateTime.Now.AddYears(-30),
                YearsOfExperience = 5,
                PhoneNumber = "0701231231",
                TypeOfTesting = TestingTypeEnum.Automatic
            };

            Console.WriteLine(qa.GetProfessionalInfo());
            Console.WriteLine(qa.GetInfo());

            DevOpsEngineer devOps = new DevOpsEngineer()
            {
                FirstName = "Devops",
                LastName = "Devops",
                Address = "Skopje",
                DateOfBirth = DateTime.Now.AddYears(-35),
                YearsOfExperience = 10,
                PhoneNumber = "0701881231",
                FavouriteCloudOperator = "AWS"
            };

            Console.WriteLine(devOps.GetProfessionalInfo());
            Console.WriteLine(devOps.GetInfo());


            //Boxing and Unboxing
            Developer dev = new Developer("Dev", "Dev", "Skopje", DateTime.Now.AddYears(-40), "070", 10, "Java");

            Person person = (Person)dev;

            Developer dev1 = (Developer)person;

            List<Developer> developers;
            List<QaEngineer> qaE;
            List<DevOpsEngineer> devopsE;

            //Boxing all childs to parent Person class, so they can fit in one List of same data type (Person)
            List<Person> employees = new List<Person>() { developer, qa, devOps, dev };

            Developer d1 = (Developer) employees[0];
        }
    }
}