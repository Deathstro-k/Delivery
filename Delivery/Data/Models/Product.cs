using Delivery.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Common;

namespace Delivery.Models
{

    public class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// Наименование товара
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Идентификатор категории товара
        /// </summary>
        public int CategoryId { get; set; }
        public ProductCategory Category { get; set; }
        /// <summary>
        /// Идентификатор поставщика фрутов
        /// </summary>
        public int FruitProviderId { get; set; }
        public FruitProvider FruitProvider { get; set; }
        /// <summary>
        /// Нормированный вес товара
        /// </summary>
        public float Weight { get; set; }
        /// <summary>
        /// Нормированная цена товара
        /// </summary>
        public decimal Price { get; set; }       

        public Order Order;
    }
}
