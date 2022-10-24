using Delivery.Models;
using Delivery.Data.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace Delivery.Data.Mocks
{
    public class MockProducts : IProduct
    {


        MockProductCategory category = new MockProductCategory();
        MockFruitProvider provider = new MockFruitProvider();
        public IEnumerable<Product> Products
        {

            get
            {
                return new List<Product>()
                {
                    //new Product("Груша \"Августовская роса\"", category.AllProductCategories.ElementAt(0), provider.FruitProviders.ElementAt(0), 100, 20000.05m,1),
                    //new Product("Груша \"Вильямс\"", category.AllProductCategories.ElementAt(0),provider.FruitProviders.ElementAt(0), 100, 20000.05m,1),
                    //new Product("Груша \"Abate Fetel\"", category.AllProductCategories.ElementAt(0),provider.FruitProviders.ElementAt(1), 100, 20000.05m,2),
                    //new Product("Груша \"Concorde\"", category.AllProductCategories.ElementAt(0),provider.FruitProviders.ElementAt(1), 100, 20000.05m,2),
                    //new Product("Груша \"Чижовская\"", category.AllProductCategories.ElementAt(0),provider.FruitProviders.ElementAt(2), 100, 20000.05m,3),
                    //new Product("Груша \"Августовская роса\"", category.AllProductCategories.ElementAt(0),provider.FruitProviders.ElementAt(2),100, 20000.05m,3),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1), provider.FruitProviders.ElementAt(0), 100, 20000.05m,1),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1), provider.FruitProviders.ElementAt(0),100, 20000.05m,1),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1),provider.FruitProviders.ElementAt(1), 100, 20000.05m,2),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1),provider.FruitProviders.ElementAt(1), 100, 20000.05m,2),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1),provider.FruitProviders.ElementAt(2), 100, 20000.05m,2),
                    //new Product("Яблоко \"Августовская роса\"", category.AllProductCategories.ElementAt(1),provider.FruitProviders.ElementAt(2), 100, 20000.05m,2)
                };
            }   
            set { }

        }
    }
    
}
