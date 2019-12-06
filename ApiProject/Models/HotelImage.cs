using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class HotelImage
    {
        public int HotelImageId { get; set; }
        [NotMapped]
        public List<IFormFile> Img { get; set; }
        public string ImageName { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public virtual Hotel Hotel { get; set; }

    }
}