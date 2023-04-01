using AbstractClassesAndInterfaces.Domain.Interfaces;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public abstract class Person : IPerson
    {
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public long PhoneNumber { get; set; }

        public Person()
        {

        }

        public Person(string fullName, int age, string address, long phoneNumber)
        {
            //todo validation
            FullName = fullName;
            Age = age;
            Address = address;
            PhoneNumber = phoneNumber;
        }

        //this method doesn't have implementation in this (base) class. All classes that inherit from Person
        //MUST provide an implementation for this method.
        public abstract string GetProfessionalInfo();

        public void Greet()
        {
            Console.WriteLine($"Hello from {FullName}.");
        }

        public void SendGift(string nameOfGift)
        {
            Console.WriteLine($"Sending {nameOfGift} on address {Address}");
        }
    }
}
