    using System.ComponentModel.DataAnnotations;
    using System;
using System.Collections.Generic;

namespace ChefnDishes.Models
{
    public class Chefs
    {
            [Key]
            public int ChefId { get; set; }
            //////////////////////////////////////////////////////////////
            [Required]
            [MinLength(2, ErrorMessage = "Needs to be at least 2 characters")]
            [Display(Name = "First Name for the cheif")]
            public string FirstName { get; set; }
            //////////////////////////////////////////////////////////////
            [Required]
            [MinLength(2, ErrorMessage = "Needs to be at least 2 characters")]
            [Display(Name = "Last Name For the Cheif")]
            public string LastName { get; set; }
            //////////////////////////////////////////////////////////////
            [Required]
            [DataType(DataType.Date)]
            public DateTime BirthDate {get;set;}
            //////////////////////////////////////////////////////////////

            public List<Dish> Dishes {get; set;}
            public DateTime CreatedAt {get;set;}
            public DateTime UpdatedAt {get;set;}
    }
}