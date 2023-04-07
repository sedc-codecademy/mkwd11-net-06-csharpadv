namespace SEDC.Class03.StaticDbDemo.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Order> Orders { get; set; }
    }
}
