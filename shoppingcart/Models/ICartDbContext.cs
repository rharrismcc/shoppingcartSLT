using System.Data.Entity;

namespace shoppingcart.Models
{
    public interface ICartDbContext
    {
        DbSet<Product> Products { get; set; }

        int SaveChanges();

        void Dispose();
    }
}