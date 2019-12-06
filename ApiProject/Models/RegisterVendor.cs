using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class RegisterVendor
    {
        public int Id { get; set; }
        public string VendorName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedAt { get; set; }

    }
}