﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedLINQ.Domain.Models
{
    public class Student : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
        public List<Subject> Subjects { get; set; }

        public Student() { }

        public Student(int id, string firstName, string lastName, int age, bool isPartTime)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            IsPartTime = isPartTime;
            Subjects = new List<Subject>();
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName} aged {Age} attends {Subjects.Count} number of subjects");
        }
    }
}
