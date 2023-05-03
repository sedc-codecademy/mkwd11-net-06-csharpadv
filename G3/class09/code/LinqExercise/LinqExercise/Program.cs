using LinqExercise;
using LinqExercise.Helpers;
using System.Net.WebSockets;

// Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
var requirement1 = Db.People
    .Where(person => person.FirstName.StartsWith("R"))
    .OrderByDescending(person => person.Age)
    .Select(person => person.FirstName)
    .ToList();

requirement1.PrintList();

// Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER​
var requirement2 = Db.Dogs
    .Where(dog => dog.Color == "Brown" && dog.Age > 3)
    .OrderBy(dog => dog.Age)
    .Select(dog => $"{dog.Name} is {dog.Age} years old.")
    .ToList();

requirement2.PrintList();

// Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER​
var requirement3 = Db.People
    .OrderByDescending(person => person.FirstName)
    .Where(person => person.Dogs.Count > 2)
    .Select(person => person.FirstName)
    .ToList();

requirement3.PrintList();

// Find and print all Freddy`s dogs names older than 1 year​
var requirement4 = Db.People
    .Single(person => person.FirstName == "Freddy").Dogs
    .Where(dog => dog.Age > 1)
    .Select(dog => dog.Name)
    .ToList();

requirement4.PrintList();

// Find and print Nathen`s first dog​
var requirement5 = Db.People
    .Single(person => person.FirstName == "Nathen")
    .Dogs.First().Name;

requirement5.PrintString();

// Find and print all white dogs names from Cristofer, Freddy, 
// Erin and Amelia, ordered by Name - ASCENDING ORDER​
var requirement6 = Db.People
    .Where(person => person.FirstName == "Cristofer"
            || person.FirstName == "Freddy"
            || person.FirstName == "Erin"
            || person.FirstName == "Amelia")
    .SelectMany(person => person.Dogs)
    .Where(dog => dog.Color == "White")
    .OrderBy(dog => dog.Name)
    .Select(dog => dog.Name)
    .ToList();

requirement6.PrintList();