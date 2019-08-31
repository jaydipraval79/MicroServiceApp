using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;
using System.Linq.Expressions;


namespace Aggregates.Service
{
    public class  CustomerQueryService
    {
        Customer FindByID(int orderID)
        {

        }

        IEnumerable<Customer> FindBy(Expression<Func<Customer, bool>> predicate)
        {

        }
    }
}
