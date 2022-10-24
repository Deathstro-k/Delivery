using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Data.Interfaces
{
    public interface IProductCategory
    {
        IEnumerable<ProductCategory> AllProductCategories{ get; }
    }
}
