using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;

namespace Aggregates.Core
{
    interface ICusomerCommandService
    {
        bool CreateCustomer(Customer customer);

        bool DeleteCustomer(int customerID);
        bool ChangeName();
        bool ChangeAddress();
  
    }
}
