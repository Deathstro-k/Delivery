using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Data.Interfaces
{
    public interface IOrder
    {
        IEnumerable<Order> Orders { get; }
    }
}
