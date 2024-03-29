using System;
using System.ComponentModel.DataAnnotations;

namespace formSubmissions.Models

{
    public class User
    {
        [Required]
        [MinLength(4)]
        public string FirstName { get; set; }
 
        [Required]
        [MinLength(4)]
        public string LastName { get; set; }

        [Required]
        [Range(0,1000)]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
 
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}

    