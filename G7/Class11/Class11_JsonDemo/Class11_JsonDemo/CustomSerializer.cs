namespace Class11_JsonDemo
{
    public static class CustomSerializer
    {
        public static string SerializeProduct(Product p)
        {
            string json = "{";
            json += $"\"Name\":\"{p.Name}\",";
            json += $"\"Manufacturer\":\"{p.Manufacturer}\",";
            json += $"\"Price\":{p.Price},";
            json += $"\"Barcode\":\"{p.Barcode}\"";
            json += "}";

            return json;
        }

        public static Product DeserializeProduct(string json)
        {
            string content = json.Substring(json.IndexOf("{") + 1, json.IndexOf("}") - 1)
                .Replace("\"", "")
                .Replace("\n", "")
                .Replace("\r", "");

            string[] rows = content.Split(",");

            Dictionary<string, string> properties = new Dictionary<string, string>();

            foreach(string row in rows)
            {
                string[] pair = row.Split(":");
                properties.Add(pair[0].Trim(), pair[1].Trim());
            }

            Product p = new Product();

            p.Name = properties["Name"];
            p.Manufacturer = properties["Manufacturer"];
            p.Price = decimal.Parse(properties["Price"]);
            p.Barcode = properties["Barcode"];

            return p;
        }
    }
}
