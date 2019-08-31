using System;
using System.Collections.Generic;
using System.Text;
using Aggregates.Models;

namespace Aggregates.Service
{
    interface ICusomerService
    {
        bool CreateCustomer(Customer customer);

        bool DeleteCustomer(int customerID);
        bool ChangeName();
        bool ChangeAddress();



        
    }
}
