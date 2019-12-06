using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web;

namespace HotelManagemant.Models
{
    public class DrinkImage
    {
        public int Id { get; set; }
        [NotMapped]
        public List<IFormFile> Img { get; set; }
        public string ImageName { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public virtual DrinkCategory DrinkCategory { get; set; }
    }
}