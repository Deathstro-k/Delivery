using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Delivery.Data;
using Delivery.Models;
using System.Diagnostics;
using Delivery.Data.Models;

namespace Delivery.Controllers
{
    public class ReportsController : Controller
    {


        private readonly DataContext _context;
      

        public ReportsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
       
            return View();
        }

   
        public IActionResult Create(ReportTime model)
        {           
            var total = from t in _context.Orders
                        join p in _context.Products
                        on t.ProductId equals p.Id
                        where (t.RegistrationDate> model.From
                        && t.RegistrationDate < model.To)
                        select new Report
                        {
                            ProductName = t.Product.Name,
                            DeliveryTime = t.DeliveryTime,
                            RegistrationDate = t.RegistrationDate,
                            EndDate = t.EndDate,
                            TotalPrice = t.DeliveryTime * p.Price,
                            TotalWeight = t.DeliveryTime * p.Weight,
                        };
            Debug.WriteLine(model.From);
            return View(total);
        }
     
       




    }
}
