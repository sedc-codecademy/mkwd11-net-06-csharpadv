namespace SEDC.Class14.Principles.Solid
{
    // Bad example
    public interface ISuperMarket
    {
        void SellBeverages();
        void SellMeat();
        void SellVegetables();
        void SellFruits();
        void SellMiscellaneous();
        bool CheckStock(int itemId);
        int CheckMeatFridgeTemperature();
    }


    public class SuperMarket : ISuperMarket
    {
        public List<int> ItemIds { get; set; } = new List<int>();

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

        public void SellMiscellaneous()
        {
            Console.WriteLine("Miscellaneous thing is sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }


    // The client opens a GreenMarket and wants to add it to the application
    // If we use the same interface we will have to watch to not call the other methods
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

        public void SellMiscellaneous()
        {
            throw new NotImplementedException();
        }

        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }
    }

    // Interface Segregation Principle (ISP)

    // Classes should not be forced to implement interfaces they do not use

    // Interfaces should be broken down into smaller and more specific interfaces
    // This will prevent classes from being dependent on methods that are irrelevant to their needs.




    // Continue with the good example here ...




}
