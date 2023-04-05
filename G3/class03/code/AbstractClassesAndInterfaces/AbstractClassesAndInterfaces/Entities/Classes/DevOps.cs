using AbstractClassesAndInterfaces.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesAndInterfaces.Entities.Classes
{
    public class DevOps : Human, IDeveloper, IOperations
    {
        public bool AWSCertified { get; set; }
        public bool AzureCertified { get; set; }
        public DevOps(string fullname, 
                      int age, long phone,
                      bool awsCert, bool azureCert) : base(fullname, age, phone)
        {
            AWSCertified = awsCert;
            AzureCertified = azureCert;
        }

        public override string GetInfo()
        {
            string result = $"{FullName} ({Age}) - Has: ";
            result += AWSCertified ? "AWS Certificate" : "";
            result += AzureCertified ? " Azure Certificate" : "";
            result += AWSCertified || AzureCertified ? "" : "No certificates yet";
            return result;
        }
        public bool CheckInfrastucture(int status)
        {
            List<int> okStatuses = new List<int>() { 200, 202, 204 };
            if (okStatuses.Contains(status))
            {
                return true;
            }
            return false;
        }

        public void Code()
        {
            Console.WriteLine("tak tak tak...");
            Console.WriteLine("Open StackEchange DevOps...");
            Console.WriteLine("tak tak tak tak tak...");
        }

        
    }
}
