using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class DailyStock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  quantity { get; set; }
        public string Date { get; set; }
        public string ProductName { get; set; }
    }
}