using Delivery.Models;
using Delivery.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;
using Delivery.Data.Mocks;

namespace DeliveryInterfaceASPNETCore.Data.Mocks
{
    public class MockOrders : IOrder
    {
        private readonly MockProducts _products = new MockProducts();
        public IEnumerable<Order> Orders => new List<Order>()
        {
            //new Order(_products.Products.ElementAt(0),new DeliveryTime(8))
        };
        


    }
}
