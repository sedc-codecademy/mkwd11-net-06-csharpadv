namespace Models
{
    public class QaEngineer : Person
    {
        public TestingTypeEnum TypeOfTesting { get; set; }


        public override string GetProfessionalInfo()
        {
            return $"{FullName} => {TypeOfTesting}";
        }
    }
}
