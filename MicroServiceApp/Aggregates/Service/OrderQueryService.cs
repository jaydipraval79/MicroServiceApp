using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;
using System.Linq.Expressions;
using System.Linq;
using Aggregates.Core;


namespace Aggregates.Service
{
    public class  OrderQueryService
    {

        Order _order;

        ICustomerQueryService _customerrQueryService;

        OrderQueryService(Order order,ICustomerQueryService customerrQueryService)
        {
             _customerrQueryService = customerrQueryService;
        }

        public IEnumerable<OrderLine> FindByOrderID(int orderID)
        {
            return _order.orderLines.Where(x => x.OrderID == orderID);
        }
        public IEnumerable<OrderLine> FindByProduct(int produtCode)
        {

            return _order.orderLines.Where(x => x.ProductCode == produtCode);
        }

    }
}
