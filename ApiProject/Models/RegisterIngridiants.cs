using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class RegisterIngridiants
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public IngridiantsName Name { get; set; }
        public int IngridiantsNameId { get; set; }
        public int Quantity { get; set; }
        public string QuantityType  { get; set; }
        public decimal PricePerUnit { get; set; }
        public int Westage { get; set; }
        public RegisterVendor vendor { get; set; }
        public int VendorId { get; set; }
        public string PaidIn { get; set; }
        public decimal TotalPrice { get; set; }
        public string BroughtDate { get; set; }
        public string BroughtBy { get; set; }
        public string CreatedBy { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedAt { get; set; }
    }
}