using System.Collections.Generic;
using Delivery.Data.Interfaces;
using Delivery.Models;

namespace Delivery.Data.Mocks
{
    public class MockFruitProvider : IFruitProvider
    {
        public IEnumerable<FruitProvider> FruitProviders => new List<FruitProvider>()
        {   
            //new FruitProvider("ООО \"Узбекские фрукты\""),
            //new FruitProvider("ООО \"Азербайджанские фрукты\""),
            //new FruitProvider("ООО \"Таджикские фрукты\"")
        };

       
    }
}
