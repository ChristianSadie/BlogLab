using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogLab.Models.Account
{
    public class ApplicationUserLogin
    {
        [Required(ErrorMessage = "Username is Required")]
        [MinLength(5, ErrorMessage = "Must be at leaste 5 to 20 Charaters")]
        [MaxLength(20, ErrorMessage = "Must be at leaste 5 to 20 Charaters")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Username is Required")]
        [MinLength(10, ErrorMessage = "Must be at leaste 10 to 50 Charaters")]
        [MaxLength(50, ErrorMessage = "Must be at leaste 10 to 50 Charaters")]

        public string Password { get; set; }
    }
}
