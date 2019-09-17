using System;
using System.Collections.Generic;
using System.Text;
using Entity;
using Microsoft.EntityFrameworkCore.Query.Expressions;
using SQLitePCL;

namespace PetShop.Infrastructure.SQL
{
    public class DBfiller
    {

        public static void Seed(PetShopContext dbFillContext)
        
        {
            Pet pet1 = new Pet
            {
                Id = 1,
                Birthdate = DateTime.Now,
                Name = " Trex ",
                Color = " White ",
                Price = 10000,
                Race = "Dog",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bente "
            };

            Pet pet2 = new Pet
            {
                Id = 2,
                Birthdate = DateTime.Now,
                Name = " Rex ",
                Color = " black ",
                Price = 5000,
                Race = "Cat",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bodil "
            };
            Pet pet3 = new Pet
            {
                Id = 3,
                Birthdate = DateTime.Now,
                Name = " Ricko ",
                Color = " black ",
                Price = 3000,
                Race = "Dog",
                SoldDate = DateTime.Now,
                PreviosOwner = " Klaus "
            };
            Pet pet4 = new Pet
            {
                Id = 4,
                Birthdate = DateTime.Now,
                Name = " Teison ",
                Color = " white ",
                Price = 7500,
                Race = " Dog ",
                SoldDate = DateTime.Now,
                PreviosOwner = " Camille "
            };
            Pet pet5 = new Pet
            {
                Id = 5,
                Birthdate = DateTime.Now,
                Name = " Coli ",
                Color = " White ",
                Price = 2000,
                Race = "Goat",
                SoldDate = DateTime.Now,
                PreviosOwner = " Bo "
            };
            Pet pet6 = new Pet
            {
                Id = 6,
                Birthdate = DateTime.Now,
                Name = " Dummi ",
                Color = " orange ",
                Price = 1000,
                Race = " Cat ",
                SoldDate = DateTime.Now,
                PreviosOwner = " Katrin "
            };

            dbFillContext.Add(pet1);
            dbFillContext.Add(pet2);
            dbFillContext.Add(pet3);
            dbFillContext.Add(pet4);
            dbFillContext.Add(pet5);
            dbFillContext.Add(pet6);


            Owner owner1 = new Owner
            {
                id = 1,
                Name = " Karl "
            };

            Owner owner2 = new Owner
            {
                id = 2,
                Name = " Carg "
            };

            Owner owner3 = new Owner
            {
                id = 3,
                Name = " Farmand "
            };
            dbFillContext.Add(owner1);
            dbFillContext.Add(owner2);
            dbFillContext.Add(owner3);
            dbFillContext.SaveChanges();
        }
    }
    
}
