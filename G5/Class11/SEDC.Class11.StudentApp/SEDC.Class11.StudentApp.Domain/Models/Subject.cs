using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Class11.StudentApp.Domain.Models
{
    public class Subject : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int NumberOfModules { get; set; }
        public override string GetInfo()
        {
            return $"{Title} {Description} = Modules: {NumberOfModules}";
        }
    }
}
