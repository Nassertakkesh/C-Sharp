using System.ComponentModel.DataAnnotations;
namespace simpleLoginReg.Models
{
    public class user
    {
        [Required]
        // [MinLength(2)]
        public string FirstName { get; set; }

        [Required]
        // [MinLength(2)]
        public string LastName { get; set; }
        
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        // [MinLength(8)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        // [MinLength(8)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPass { get; set; }

    }
}