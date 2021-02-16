using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserCreate : ApplicationUserLogin
    {
       
        [MinLength(10, ErrorMessage = "Must be at leaste 10 to 30 Charaters")]
        [MaxLength(30, ErrorMessage = "Must be at leaste 10 to 30 Charaters")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [MaxLength(50, ErrorMessage = "can be at most 30 characters")]
        [EmailAddress(ErrorMessage = "Invalid Email Format")]
        public string Email { get; set; }
    }
}
