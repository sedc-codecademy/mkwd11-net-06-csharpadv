using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Domain.Interfaces
{
    public interface IQAEngineer
    {
        void TestingFeature(string feature, DateTime deadline);
    }
}
