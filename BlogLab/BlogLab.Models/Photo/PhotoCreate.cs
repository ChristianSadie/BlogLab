﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Photo
{
    public class PhotoCreate
    {
        public string ImageUrl { get; set; }

        public String PublicId { get; set; }

        public string Description { get; set; }
    }
}
