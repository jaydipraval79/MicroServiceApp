using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregates.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public DateTime OrderDate { get; set; }

        public decimal Amount { get; set; }

        public int Discount { get; set; }

        public string OrderStatus { get; set; }

        public IList<OrderLine> orderLines { get; set; }

        


    }
}
