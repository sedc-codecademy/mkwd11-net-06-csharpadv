namespace Models
{
    public class DevOpsEngineer : Person
    {
        public string FavouriteCloudOperator { get; set; }

        public override string GetProfessionalInfo()
        {
            return $"{FullName} => {FavouriteCloudOperator}";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + " " + GetProfessionalInfo();
        }
    }
}
