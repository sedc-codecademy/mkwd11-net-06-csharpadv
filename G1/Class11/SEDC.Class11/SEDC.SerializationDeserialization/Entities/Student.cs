﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.SerializationDeserialization.Entities
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [JsonProperty("Student_Age")]
        public int Age { get; set; }
        public bool IsPartTime { get; set; }
    }
}
