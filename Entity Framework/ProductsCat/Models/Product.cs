using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;



namespace ProductsCat.Models
{
    public class Product
    {
        [Key] 
        public int ProductId { get; set; }   
        public String Name { get; set; }   

        public String Desc { get; set; }   

        public Decimal Price { get; set; }   

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> CategoriesForProd { get; set; }

    }
}