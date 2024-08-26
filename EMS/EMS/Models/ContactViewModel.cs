using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EMS.Models
{
    public class ContactViewModel
    {
        public string CompanyName { get; set; }
        public List<Address> Addresses { get; set; }
    }

    public class Address
    {   public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
    }
}
