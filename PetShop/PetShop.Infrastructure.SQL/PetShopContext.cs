using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Microsoft.EntityFrameworkCore;

namespace PetShop.Infrastructure.SQL
{
    public class PetShopContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<Owner> owners { get; set; }
    }
}
