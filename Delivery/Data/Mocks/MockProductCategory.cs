using System.Collections.Generic;
using Delivery.Data.Interfaces;
using Delivery.Models;

namespace Delivery.Data.Mocks
{
    public class MockProductCategory : IProductCategory
    {
        public IEnumerable<ProductCategory> AllProductCategories => new List<ProductCategory>()
        {
            //new ProductCategory("Груши"),
            //new ProductCategory("Яблоки")
        };
    }
}
