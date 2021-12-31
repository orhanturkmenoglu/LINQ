using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
   public class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public decimal UnitsPrice { get; set; }
        public int UnitsInStock { get; set; }
    }
}
