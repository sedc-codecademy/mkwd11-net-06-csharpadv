using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDb.Models
{
    public class Subject :BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfModules { get; set; }

        public override string GetInfo()
        {
            return $"{Title}, {Description}. It has {NumberOfModules} number of modules";
        }
    }
}
