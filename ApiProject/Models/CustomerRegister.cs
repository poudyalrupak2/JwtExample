using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class CustomerRegister
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }
        public string state { get; set; }
        public string NationalIdNo { get; set; }
        public string Nationality { get; set; }
        public string  Email { get; set; }
        public string  Password { get; set; }
    }
}