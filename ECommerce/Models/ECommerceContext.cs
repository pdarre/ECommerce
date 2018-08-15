namespace ECommerce.Models
{
    using System.Data.Entity;

    public class ECommerceContext :DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {
             public DbSet<Product> Products { get; set; }
    }
    }
}