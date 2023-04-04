using AbstractClassesAndInterfaces.Entities.Interfaces;

namespace AbstractClassesAndInterfaces.Entities
{
    public class DevOps : Human, IDeveloper, IDevOps
    {
        public bool AWSCertified { get; set; }

        public bool AzureCertified { get; set; }

        public DevOps(string fullName, int age, long phone, bool AWSCertified, bool AzureCertified) : base(fullName, age, phone)
        {
            this.AWSCertified = AWSCertified;
            this.AzureCertified = AzureCertified;
        }

        public bool CheckInfrastructure(int status)
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
            Console.WriteLine("THE DEV OPS GUY IS CODING, but not like the developer one");
        }

        public override string GetInfo()
        {
            return $"{FullName} ({Age}) - AWS Certified: {(AWSCertified ? "yes" : "no")} Azure Certified: {(AzureCertified ? "yes" : "no")}";
        }
    }
}
