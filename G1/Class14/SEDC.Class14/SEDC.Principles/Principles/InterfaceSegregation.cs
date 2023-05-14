using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Principles.Principles
{
    //Bad example

    public interface ISuperMarket 
    {
        void SellBeverages();
        void SellMeat();
        void SellVegetables();
        void SellFruits();
        void SellSweets();
        bool CheckStock(int itemId);
        int CheckMeatFridgeTemperature();
    }


    public class SuperMarket : ISuperMarket
    {
        public List<int> ItemIds = new List<int>();


        public int CheckMeatFridgeTemperature()
        {
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

        public void SellSweets()
        {
            Console.WriteLine("Sweets are sold!");
        }

        public void SellVegetables()
        {
            Console.WriteLine("Vegetable is sold!");
        }
    }

    public class GreenMarket : ISuperMarket
    {
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }

        public bool CheckStock(int itemId)
        {
            throw new NotImplementedException();
        }

        public void SellBeverages()
        {
            throw new NotImplementedException();
        }

        public void SellFruits()
        {
            throw new NotImplementedException();
        }

        public void SellMeat()
        {
            throw new NotImplementedException();
        }

        public void SellSweets()
        {
            throw new NotImplementedException();
        }

        public void SellVegetables()
        {
            throw new NotImplementedException();
        }
    }

    public class MeatMarket : ISuperMarket
    {
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }

        public bool CheckStock(int itemId)
        {
            throw new NotImplementedException();
        }

        public void SellBeverages()
        {
            throw new NotImplementedException();
        }

        public void SellFruits()
        {
            throw new NotImplementedException();
        }

        public void SellMeat()
        {
            throw new NotImplementedException();
        }

        public void SellSweets()
        {
            throw new NotImplementedException();
        }

        public void SellVegetables()
        {
            throw new NotImplementedException();
        }
    }




    //Good example
    public interface IGreenMarket
    {
        void SellVegetables();
        void SellFruits();
    }

    public interface IButcherMarket
    {
        void SellMeat();
        int CheckMeatFridgeTemperature();
    }

    public interface IBasicMarket
    {
        void SellBeverages();
        void SellSweets();
        bool CheckStock(int itemId);
    }


    public class SuperMarketGood : IBasicMarket, IButcherMarket, IGreenMarket
    {
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }

        public bool CheckStock(int itemId)
        {
            throw new NotImplementedException();
        }

        public void SellBeverages()
        {
            throw new NotImplementedException();
        }

        public void SellFruits()
        {
            throw new NotImplementedException();
        }

        public void SellMeat()
        {
            throw new NotImplementedException();
        }

        public void SellSweets()
        {
            throw new NotImplementedException();
        }

        public void SellVegetables()
        {
            throw new NotImplementedException();
        }
    }

    public class GreenMarketGood : IGreenMarket
    {
        public void SellFruits()
        {
            throw new NotImplementedException();
        }

        public void SellVegetables()
        {
            throw new NotImplementedException();
        }
    }

    public class ButcherMarketGood : IButcherMarket
    {
        public int CheckMeatFridgeTemperature()
        {
            throw new NotImplementedException();
        }

        public void SellMeat()
        {
            throw new NotImplementedException();
        }
    }
}
