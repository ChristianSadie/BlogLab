using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Blog
{
    public class BlogCreate
    {
        public int BlogId { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [MinLength(10, ErrorMessage = "must be 10 to 50 chars")]
        [MaxLength(50, ErrorMessage = "must be 10 to 50 chars ")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [MinLength(300, ErrorMessage = "must be 300 to 3000 chars")]
        [MaxLength(3000, ErrorMessage = "must be 300 to 3000 chars")]
        public string Content { get; set; }

        public int? PhotoId { get; set; }
    }
}
