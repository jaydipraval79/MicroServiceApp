using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregates.Models
{
    public class OrderLine
    {

        public int OrderID { get; set; }
        public int ProductID { get; set; }
        public int ProductCode { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public decimal price { get; set; }


    }
}
