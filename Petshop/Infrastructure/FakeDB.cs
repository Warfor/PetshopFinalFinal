﻿using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Infrastructure
{
    public class FakeDB
    {
        internal static int PetId = 1;
        internal static readonly List<Pet> PetList = new List<Pet>();

        public static void InitData()
        {
            Pet pet1 = new Pet
            {
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
                Birthdate = DateTime.Now,
                Name = " Dummi ",
                Color = " orange ",
                Price = 1000,
                Race = " Cat ",
                SoldDate = DateTime.Now,
                PreviosOwner = " Katrin "
            };
            PetList.Add(pet1);
            PetList.Add(pet2);
            PetList.Add(pet3);
            PetList.Add(pet4);
            PetList.Add(pet5);
            PetList.Add(pet6);
        }
    }
}
