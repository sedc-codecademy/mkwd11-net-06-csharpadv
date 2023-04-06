using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Entities.Interfaces
{
    public interface IDeveloper : IEmployee
    {
        string Code();
    }
}
