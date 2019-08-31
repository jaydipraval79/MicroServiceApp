using System;
using System.Collections.Generic;
using System.Text;

namespace Aggregates.Models
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }

        public int Pincode { get; set; }

    }
}
