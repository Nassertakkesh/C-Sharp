    using System.ComponentModel.DataAnnotations;
    using System;
    using System.ComponentModel.DataAnnotations.Schema;
    namespace CRUDelicous.Models    {
        public class Dish
        {
            // auto-implemented properties need to match the columns in your table
            // the [Key] attribute is used to mark the Model property being used for your table's Primary Key
            [Key]
            public int DishId { get; set; }
            // MySQL VARCHAR and TEXT types can be represeted by a string
            [Required]
            public string ChefsName { get; set; }
            [Required]
            public string DishName { get; set; }
            [Required]
            [MinLength(1, ErrorMessage = "must be at least 1 characters")]
            public int Calories { get; set; }
            [Required]
            public int Tastiness { get; set; }
            [Required]
            public string Description { get; set; }
         
            // The MySQL DATETIME type can be represented by a DateTime
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            public DateTime UpdatedAt {get;set;} = DateTime.Now;
        }
    }


