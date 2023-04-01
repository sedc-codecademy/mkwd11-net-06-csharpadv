using SEDC.Interfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Interfaces.Entities
{
    public class QAEng : IQAEng
    {
        public void Code()
        {
            Console.WriteLine("QA eng is coding");
        }

        public void Test()
        {
            Console.WriteLine("QA eng is testing");
        }

        public void CodingAndTesting()
        {
            Console.WriteLine("QA eng is coding and testing in the same time.");
        }

    }
}
