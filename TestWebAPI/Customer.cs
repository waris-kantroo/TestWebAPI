using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebAPI
{
    public class Customer
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public Address1 address { get; set; }
        public DateTime DOB { get; set; }

    }

    public class Address1
    {
        public int telephone { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
        public SubAddress subAddress { get; set; }
    }

    public class SubAddress
    {
        public int telephone { get; set; }
        public string city { get; set; }
        public string pincode { get; set; }
    }
}