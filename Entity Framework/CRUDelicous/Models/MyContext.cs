using Microsoft.EntityFrameworkCore;
 
namespace CRUDelicous.Models
{
    public class ThisContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public ThisContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
    }
}