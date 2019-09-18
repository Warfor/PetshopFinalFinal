using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Infrastructure.SQL
{
    public class PetShopContext : DbContext
    {
        public PetShopContext(DbContextOptions opt)
            : base(opt) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            {
                modelBuilder.Entity<Pet>()
                    .HasOne(p => p.Race)
                    .WithMany();

            }
        }

        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> owners { get; set; }
    }

}
