namespace Models
{
    public class Developer : Person
    {
        public string FavouriteLanguage { get; set; }

        public Developer(string firstName, string lastName, string address, DateTime dateOfBirth, string phoneNumber, int yearsOfExperience, string favouriteLanguage) :
            base(firstName, lastName, address, dateOfBirth, phoneNumber, yearsOfExperience)
        {
            FavouriteLanguage = favouriteLanguage;
        }

        public override string GetProfessionalInfo()
        {
            return $"{FullName} => {FavouriteLanguage}";
        }

        public override string GetInfo()
        {
            return base.GetInfo() + $" favourite language: {FavouriteLanguage}";
        }
    }
}
