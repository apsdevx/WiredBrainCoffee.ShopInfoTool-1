using System;
using System.Collections.Generic;
using System.Text;
using WiredBrainCoffee.DataAccess.Model;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeShops()
        {
            yield return new CoffeeShop { BeansInStock = 1, Location = "Rajasthan" };
            yield return new CoffeeShop { BeansInStock = 5, Location = "UP" };
            yield return new CoffeeShop { BeansInStock = 10, Location = "MP" };
        }
    }
}
