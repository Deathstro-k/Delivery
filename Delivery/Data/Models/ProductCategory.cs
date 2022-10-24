using System.Collections.Generic;

namespace Delivery.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование категории товара
        /// </summary>
        public string Name { get; set; }
        public Product Product { get; set; }

    }

}
