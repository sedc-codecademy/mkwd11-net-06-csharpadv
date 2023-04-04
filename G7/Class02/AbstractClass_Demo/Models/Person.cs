namespace Models
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public int YearsOfExperience { get; set; }

        public Person(string firstName, string lastName, string address, DateTime dateOfBirth, string phoneNumber, int yearsOfExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            DateOfBirth = dateOfBirth;
            PhoneNumber = phoneNumber;
            YearsOfExperience = yearsOfExperience;
        }

        public Person()
        {

        }

        public virtual string GetInfo()
        {
            return $"{FullName} [{YearsOfExperience}] - {PhoneNumber}";
        }

        //this method does not have implemntation. It will force all childs to implement it by themself
        //This will be a function that will print out Projects that the employee has been working on
        public abstract string GetProfessionalInfo();
    }
}