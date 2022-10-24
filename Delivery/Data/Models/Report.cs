using System;
using System.Collections.Generic;

namespace Delivery.Data.Models
{
    public class Report
    {      
       
        public List<Report> Reports { get; set; }
        public string ProductName { get; internal set; }
        public int DeliveryTime { get; internal set; }
        public DateTime RegistrationDate { get; internal set; }
        public DateTime EndDate { get; internal set; }
        public decimal TotalPrice { get; internal set; }
        public float TotalWeight { get; internal set; }
    }
}
