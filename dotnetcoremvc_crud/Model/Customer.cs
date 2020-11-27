using System;
using System.Collections.Generic;

namespace dotnetcoremvc_crud.Model
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
    }
}
