using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Interfaces.Entities.Interfaces
{
    public interface IQAEng : IDeveloper, ITester
    {
        void CodingAndTesting();
    }
}
