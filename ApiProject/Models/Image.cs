﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManagemant.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        [NotMapped]
        public IEnumerable<Microsoft.AspNetCore.Http.IFormFile> Img { get; set; }
        public string ImageName { get; set; }
        public long Size { get; set; }
        public string Path { get; set; }
        public virtual MenuRegistration MenuRegistration { get; set; }

    }
}