using AbstractClassesAndInterfaces.Domain.Interfaces;

namespace AbstractClassesAndInterfaces.Domain.Models
{
    public class DevOpsEngineer : Person, IDevOpsEngineer, IDeveloper
    {
        public bool IsAzureCertified { get; set; }
        public bool IsAWSCertified { get; set; }

        public DevOpsEngineer(string fullName, int age,
            string address, long phoneNumber, bool isAzureCertified, bool isAWSCertified) : base(fullName, age, address, phoneNumber)
        {
            IsAzureCertified = isAzureCertified;
            IsAWSCertified = isAWSCertified;
        }

        public override string GetProfessionalInfo()
        {
            string info = $"{FullName}";
            info += IsAzureCertified ? " has Azure certificate. " : " doesn't have Azure Certificate. ";
            info += IsAWSCertified ? " has AWS certificate. " : " doesn't have AWS Certificate. ";

            return info;
        }

        public bool CheckInfrastructure(int status)
        {
            List<int> okStatuses = new List<int> { 200, 202, 204 };
            return okStatuses.Contains(status);
        }

        public void Code()
        {
            if(IsAzureCertified)
            {
                Console.WriteLine("Writing code for Azure Portal service");
            }

            if (IsAWSCertified)
            {
                Console.WriteLine("Writing code for AWS Portal services");
            }

        }
    }
}
