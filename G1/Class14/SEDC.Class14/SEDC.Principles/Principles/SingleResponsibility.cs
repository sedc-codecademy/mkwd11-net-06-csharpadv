using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Principles.Principles
{

    //Bad example
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AddressName { get; set; }
        public string AddressNumber { get; set; }
        public string City { get; set; }
        public Person BestFriend { get; set; }
        public List<Person> Friends { get; set; }
        public List<Person> Siblings { get; set; }


        public string GetPersonInfo()
        {
            return $"{FirstName} {LastName} - {Age}";
        }

        public bool ValidateAddressNumber(int addressNumber)
        {
            if(addressNumber < 0) return false;
            if (addressNumber > 999) return false;
            return true;
        }

        public string GetAddressInfo()
        {
            return $"{AddressName} No.{AddressNumber} - {City}";
        }

        public bool HasRelations()
        {
            int friends = Friends.Count + Siblings.Count;
            if(friends == 0 && BestFriend == null) return false;
            return true;
        }

        public bool IsBestFriendSibling()
        {
            return Siblings.Exists(x => x == BestFriend);
        }

        public void PrintFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}");
            }
        }

    }



    //Good example

    public class PersonGood
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        public Relation Relation { get; set; }

        public string GetPersonInfo()
        {
            return $"{FirstName} {LastName} - {Age}";
        }
    }

    public class Relation
    {
        public PersonGood BestFriend { get; set; }
        public List<PersonGood> Friends { get; set; }
        public List<PersonGood> Siblings { get; set; }

        public bool HasRelations()
        {
            int friends = Friends.Count + Siblings.Count;
            if (friends == 0 && BestFriend == null) return false;
            return true;
        }

        public bool IsBestFriendSibling()
        {
            return Siblings.Exists(x => x == BestFriend);
        }

        public void PrintFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}");
            }
        }
    }

    public class Address
    {
        public string AddressName { get; set; }
        public string AddressNumber { get; set; }
        public string City { get; set; }

        public bool ValidateAddressNumber(int addressNumber)
        {
            if (addressNumber < 0) return false;
            if (addressNumber > 999) return false;
            return true;
        }

        public string GetAddressInfo()
        {
            return $"{AddressName} No.{AddressNumber} - {City}";
        }
    }
}
