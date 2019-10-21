using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCat.Models
{
    public class Category
    {
        [Key] 
        public int CategoryId { get; set; }   
        public String Name { get; set; }   
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public List<Association> ProdcutsInCat { get; set; }

    }
         }