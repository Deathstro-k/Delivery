using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Data.Interfaces
{
    public interface IProduct
    {
        IEnumerable<Product> Products { get; set; }
    }
}
