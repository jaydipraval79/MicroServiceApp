﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregates.Models
{
    class Customer
    {
        public int CustomerID { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public List<Order> Orders { get; set; }
    }
}
