using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using SQLite.CodeFirst;

namespace shoppingcart.Models
{
    public class CartDbContext : DbContext, ICartDbContext
    {
        public CartDbContext() : base("SQLiteConnection")
        {

        }

        public virtual DbSet<Product> Products { get; set; }

        
        public override int SaveChanges()
        {
            return base.SaveChanges();
        }

        public new void Dispose()
        {
            base.Dispose();
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var sqliteConnectionInitializer = new SqliteDropCreateDatabaseAlways<ApplicationDbContext>(modelBuilder);
            Database.SetInitializer(sqliteConnectionInitializer);
        }

    }
}