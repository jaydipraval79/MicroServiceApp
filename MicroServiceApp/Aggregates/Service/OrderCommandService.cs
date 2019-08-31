using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;
using System.Linq;
using Aggregates.Core;

namespace Aggregates.Service
{
    public  class OrderCommandService
    {

        Customer _customer;

        IOrderQueryService _queryService;
        OrderCommandService(Customer customer,IOrderQueryService queryService)
        {
            this._customer = customer;
            this._queryService = queryService;

        }

        public int CreateOrder(Order order)
        {
            _customer.Orders.Add(order);
            return _customer.Orders.Count;

        }

        public bool DeleteOrder(int orderID)
        {
            Order ord =  _customer.Orders.Where(x => x.OrderID == orderID).FirstOrDefault();
            return _customer.Orders.Remove(ord);
        }

        public bool ChangeOrderDate(int orderID , DateTime orderdate)
        {

        }

        public bool ChangeOrderStatus()
        {

        }


    }
}
