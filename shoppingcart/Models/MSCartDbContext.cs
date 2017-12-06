using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace shoppingcart.Models
{
    public class MSCartDbContext : DbContext, ICartDbContext
    {
        public MSCartDbContext() : base("SQLSvrConnection")
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
            var dbInitializer = new DropCreateDatabaseIfModelChanges<MSCartDbContext>();
            Database.SetInitializer(dbInitializer);
        }

    }
}