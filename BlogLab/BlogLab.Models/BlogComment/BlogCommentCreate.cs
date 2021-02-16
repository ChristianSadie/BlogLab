using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.BlogComment
{
    public class BlogCommentCreate
    {
        public int BlogCommentId { get; set; }
       

        public int? ParentBlogCommentId { get; set; }

        public int BlogId { get; set; }

        [Required(ErrorMessage = "Content is Required")]
        [MinLength(10, ErrorMessage = "must be 10 to 300 chars")]
        [MaxLength(300, ErrorMessage = "must be 10 to 300 chars")]
        public string Content { get; set; }
    }
}
