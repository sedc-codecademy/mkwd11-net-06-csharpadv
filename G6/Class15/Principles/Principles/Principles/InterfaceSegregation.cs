namespace Principles.Principles
{
    // Bad example
    public interface ISuperMarket
    {
        void SellBeverages();
        void SellMeat();
        void SellVegetables();
        void SellFruits();
        void SellMiscelenious();
        bool CheckStock(int itemId);
        int CheckMeatFridgeTemperature();
    }
    public class SuperMarket : ISuperMarket
    {
        public List<int> ItemIds { get; set; }

        public int CheckMeatFridgeTemperature()
        {
            // Makes request to meat temperature system and the system returns 10
            return 10;
        }
        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }

        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
        public void SellMeat()
        {
            Console.WriteLine("Meat is sold!");
        }
        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious thing is sold!");
        }
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }
    // The client opens a GreenMarket and wants to add it to the application
    // If we use the same interface we will have to watch to not call the other methods
    // If we make a new interface we will copy code, it will be the same as ISuperMarket but without the things we don't need
    public class GreenMarket : ISuperMarket
    {
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
        public bool CheckStock(int itemId)
        {
            throw new NotImplementedException();
        }
        public void SellBeverages()
        {
            throw new NotImplementedException();
        }
        public void SellMeat()
        {
            throw new NotImplementedException();
        }
        public void SellMiscelenious()
        {
            throw new NotImplementedException();
        }
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }
    }

    // Good Example
    public interface IGreenMarket
    {
        void SellVegetables();
        void SellFruits();
    }
    public interface IBasicMarket
    {
        void SellBeverages();
        void SellMiscelenious();
        bool CheckStock(int itemId);
    }
    public interface IButcherMarket
    {
        void SellMeat();
        int CheckMeatFridgeTemperature();
    }
    public class SuperMarketGood : IBasicMarket, IGreenMarket, IButcherMarket
    {
        public List<int> ItemIds { get; set; }

        public int CheckMeatFridgeTemperature()
        {
            // Makes request to meat temperature system and the system returns 10
            return 10;
        }
        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }
        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
        public void SellMeat()
        {
            Console.WriteLine("Meat is sold!");
        }
        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious thing is sold!");
        }
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }
    // The client opens a GreenMarket and wants to add it to the application
    public class GreenMarketGood : IGreenMarket
    {
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
    }
    // The client opens a Convenient Store 
    public class ConvenientStore : IBasicMarket, IGreenMarket
    {
        public List<int> ItemIds { get; set; }

        public bool CheckStock(int itemId)
        {
            return ItemIds.Exists(x => x == itemId);
        }
        public void SellBeverages()
        {
            Console.WriteLine("Beverage is sold!");
        }
        public void SellFruits()
        {
            Console.WriteLine("Fruit is sold!");
        }
        public void SellMiscelenious()
        {
            Console.WriteLine("Miscelenious thing is sold!");
        }
        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }
}
