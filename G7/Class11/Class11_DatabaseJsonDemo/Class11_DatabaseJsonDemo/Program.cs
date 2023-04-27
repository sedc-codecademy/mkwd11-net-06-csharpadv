namespace Class11_DatabaseJsonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database<Product> products = new Database<Product>();

            Product p1 = new Product("Mleko", 40);
            Product p2 = new Product("Coca Cola", 70);
            Product p3 = new Product("Cokolado", 80);
            Product p4 = new Product("Pivo", 40);

            products.Insert(p1);
            products.Insert(p2);
            products.Insert(p3);
        }
    }
}