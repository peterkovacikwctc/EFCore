using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EFCore.Models
{
    public class Product : Controller
    {
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public short UnitsInStock { get; set; }
            public short UnitsOnOrder { get; set; }
            public short ReorderLevel { get; set; }
            public bool Discontinued { get; set; }
            public int CategoryId { get; set; }
            public Category Category { get; set; }
    
    }
}
