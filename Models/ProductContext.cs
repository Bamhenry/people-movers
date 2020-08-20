using System.Data.Entity;

namespace PeopleMovers.Models
{
    public class ProductContext : DbContext
    {
        public ProductContext() : base("PeopleMovers")
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}