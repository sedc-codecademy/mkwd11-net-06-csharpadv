namespace Models
{
    public static class DogShelter
    {
        public static List<Dog> Dogs;

        static DogShelter()
        {
            Dogs = new List<Dog>();
        }

        public static string PrintAll()
        {
            //{"1. Sharko [Black]", "2. Lucy [Brown]"}
            List<string> dogInfos = Dogs.Select(x => $"{x.Id}. {x.Name} [{x.Color}]").ToList();

            return string.Join("\n", dogInfos);
        }
    }
}
