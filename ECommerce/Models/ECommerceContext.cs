namespace ECommerce.Models
{
    using System.Data.Entity;

    public class ECommerceContext : DbContext
    {
        public ECommerceContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ECommerce.Models.Department> Departments { get; set; }
    }
}