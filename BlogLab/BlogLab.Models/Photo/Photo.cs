using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Photo
{
    public class Photo : PhotoCreate
    {
        public int PhotoId { get; set; }

        public string PublicId { get; set; }

        public string Description { get; set; }
    }
}
