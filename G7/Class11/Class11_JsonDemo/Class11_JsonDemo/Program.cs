using Newtonsoft.Json;

namespace Class11_JsonDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string folder = @"..\..\..\Example";
            string filePath = folder + @"\product.json";
            string filePath1 = folder + @"\product_newtonsoft.json";

            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }

            if(!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }

            if (!File.Exists(filePath1))
            {
                File.Create(filePath1).Close();
            }

            Product p1 = new Product
            {
                Name = "Coca Cola",
                Manufacturer = "Skopska pivara",
                Price = 70,
                Barcode = "123456546456"
            };

            string json = CustomSerializer.SerializeProduct(p1);

            Product p2 = new Product
            {
                Name = "Mleko",
                Manufacturer = "BiMilk",
                Price = 60,
                Barcode = "88887878888"
            };

            string json2 = CustomSerializer.SerializeProduct(p2);

            using(StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine(json2);
            }

            using(StreamReader sr = new StreamReader(filePath))
            {
                string json_temp = sr.ReadToEnd();
                Product p3 = CustomSerializer.DeserializeProduct(json_temp);
            }

            //NewtonsoftJson
            Product p4 = new Product
            {
                Name = "Leb",
                Manufacturer = "ZitoLuks",
                Price = 35,
                Barcode = "11111111111"
            };

            //Using a static class JsonConvert from Newtonsoft.JSON lib, and SerializeObject method that returns back JSON string that represents the converted JSON content of the object that is send as an inputed argument.
            string jsonString = JsonConvert.SerializeObject(p4);

            using (StreamWriter sw = new StreamWriter(filePath1))
            {
                sw.WriteLine(jsonString);
            }

            using (StreamReader sr = new StreamReader(filePath1))
            {
                string json_temp = sr.ReadToEnd();
                //When using DeserializeObject method, first you need to specify in which type of C# object the JSON string needs to be converted (Generic method <>), and then the JSON string needs to be send as an input argument.
                Product p5 = JsonConvert.DeserializeObject<Product>(json_temp);
            }

            List<Product> products = new List<Product> { p1, p2, p4 };
            string listJsonString = JsonConvert.SerializeObject(products);

            List<Product> deserializedList = JsonConvert.DeserializeObject<List<Product>>(listJsonString);
        }
    }
}