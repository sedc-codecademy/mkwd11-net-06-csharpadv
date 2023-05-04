namespace Class11_DatabaseJsonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database<Product> products = new Database<Product>();

            List<Product> r = products.GetAll();

            Product p1 = new Product("Milk", 40);
            Product p2 = new Product("Coca Cola", 70);
            Product p3 = new Product("Chocolate", 80);
            Product p4 = new Product("Beer", 40);

            products.Insert(p1);
            products.Insert(p2);
            products.Insert(p3);

            Database<Car> cars = new Database<Car>();

            Car c1 = new Car
            {
                Name = "Renault",
                FuelType = FuelTypeEnum.Petrol
            };

            cars.Insert(c1);

            cars.Insert(new Car
            {
                Name = "BMW",
                FuelType = FuelTypeEnum.Electric
            });
        }
    }
}