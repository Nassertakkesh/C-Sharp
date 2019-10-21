using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductsCat.Models
{
    public class Association
    {
        [Key] 
        public int AssociationId { get; set; }   
        public int ProductId { get; set; } 
        public int CategoryId { get; set; }   
        public Product AssocProduct { get; set; } 
        public Category AssocCategory { get; set; } 

         
    }
}