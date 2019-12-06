using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class StockIng
    {
        public int Id { get; set; }
        public IngridiantsName Name { get; set; }
        public int IngridiantsNameId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        

    }
}