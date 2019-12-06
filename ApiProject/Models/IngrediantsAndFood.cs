using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class IngrediantsAndFood
    {
        public int Id { get; set; }
        public RegisterFood registerFood { get; set; }
        public int RegisterFoodId { get; set; }
       public RegisterIngridiants Register { get; set; }
        public int RegisterIngridiantsId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

    }
}