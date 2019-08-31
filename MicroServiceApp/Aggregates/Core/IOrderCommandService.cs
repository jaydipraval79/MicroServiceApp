using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;

namespace Aggregates.Core
{
    interface IOrderCommandService
    {

        int CreateOrder(Order order);

        bool DeleteOrder(int orderID);

        bool ChangeOrderDate(DateTime orderdate);

        bool ChangeOrderStatus();


    }
}
