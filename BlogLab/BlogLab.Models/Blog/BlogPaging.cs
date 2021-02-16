using System;
using System.Collections.Generic;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogPaging
    {
        public int Page { get; set; }
        public int PageSize { get; set; } = 6;
    }
}
