namespace SEDC.Class14.Principles.Solid
{
    // Bad Example
    public class PersonBad
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string AddressName { get; set; }
        public string AddressNumber { get; set; }
        public string City { get; set; }
        public PersonBad BestFriend { get; set; }
        public List<PersonBad> Friends { get; set; }
        public List<PersonBad> Siblings { get; set; }

        public string PrintPerson()
        {
            return $"{FirstName} {LastName} {Age}";
        }

        public bool ValidateAddressNumber(int addressNumber)
        {
            if (addressNumber < 0) return false;
            if (addressNumber > 999) return false;
            return true;
        }

        public string PrintAddress()
        {
            return $"{AddressName} No.{AddressNumber} - {City}";
        }

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
            foreach (PersonBad friend in Friends)
            {
                Console.WriteLine($"{friend.FirstName} {friend.LastName}");
            }
        }
    }

    // Single Responsibility Principle

    // A class should have only one reason to change or in other words, a class should have a single responsibility and do stuff only for that thing
    // This means that every functionality of our software should be separated into a new entity

    // Benefits:
    // - Increased maintainability => Code is easier to understand, modify, and maintain
    // - Flexibility and extensibility => When a class has a single responsibility, it becomes easier to extend and modify its behavior without impacting other parts of the system




    // Continue with the good example here ...




}