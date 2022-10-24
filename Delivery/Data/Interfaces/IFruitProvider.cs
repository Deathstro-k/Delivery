using Delivery.Models;
using System.Collections.Generic;

namespace Delivery.Data.Interfaces
{
    public interface IFruitProvider
    {
        IEnumerable<FruitProvider> FruitProviders { get; }
    }
}
