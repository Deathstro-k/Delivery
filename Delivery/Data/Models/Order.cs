using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Delivery.Models
{
    public class Order
    {
        public int Id { get; set; }
        /// <summary>
        /// Номер товара из таблицы товаров
        /// </summary>
        public int ProductId { get; set; }
        public Product Product { get; set; }
        /// <summary>
        /// Период поставки заказа
        /// </summary>
        public int DeliveryTime { get; set; }
        /// <summary>
        /// Дата регистрации заказа
        /// </summary>
        public DateTime RegistrationDate { get; set; }
        /// <summary>
        /// Дата окончания заказа
        /// </summary>
        public DateTime EndDate { get; set; }
        /// <summary>
        /// Вес заказа 
        /// </summary>
        public float? TotalWeight { get; set; }
        /// <summary>
        /// Цена заказа
        /// </summary>
        public decimal? TotalPrice { get; set; }

        
    }
}
