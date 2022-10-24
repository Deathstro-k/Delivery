using Microsoft.AspNetCore.Mvc;
using System;

namespace Delivery.Data.Models
{
    public class ReportTime
    {
        [BindProperty]
        public DateTime From { get; set; }
        [BindProperty]
        public DateTime To { get; set; }
    }
}
