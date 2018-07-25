using System;
using System.Collections.Generic;
using System.Text;

namespace Database.Models
{
    public class Address
    {
        public Guid Guid { get; private set; }
        public string Street { get; private set; }
        public string City { get; private set; }
        public string ZipCode { get; private set; }
    }
}
