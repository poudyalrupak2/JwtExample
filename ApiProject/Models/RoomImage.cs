using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class RoomImage
    {
        public int RoomImageId { get; set; }
        [NotMapped]
        public IEnumerable<IFormFile> Img { get; set; }
        public string ImageName { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public virtual Room Room { get; set; }

    }
}