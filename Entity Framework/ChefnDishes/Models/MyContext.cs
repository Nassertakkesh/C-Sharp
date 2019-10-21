
        using Microsoft.EntityFrameworkCore;
        namespace ChefnDishes.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
        public DbSet<Dish> Dishes {get;set;}
        public DbSet<Chefs> Chefs {get;set;}


    }
}
    