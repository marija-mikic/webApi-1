using Microsoft.EntityFrameworkCore;


namespace webApi.webApi.DAL
{
    public class ProductContex : DbContext
    {
        public ProductContex(DbContextOptions < ProductContex > options): base(options) {}

        public DbSet<Product> Products { get; set; }
    }
}
