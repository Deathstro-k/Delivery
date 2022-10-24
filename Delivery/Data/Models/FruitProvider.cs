using System.Collections.Generic;

namespace Delivery.Models
{
    public class FruitProvider
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование поставщика фруктов
        /// </summary>
        public string Name { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();    
    }
}
