﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DomainService;
using Entity;
using SQLitePCL;

namespace PetShop.Infrastructure.SQL.Repositories
{
    public class OwnerSQLRepository : IOwnerRepository
    {
        private PetShopContext _context;
        public OwnerSQLRepository(PetShopContext context)
        {
            _context = context;
        }
        public Owner Create(Owner owner)
        {
            Owner OwnerToReturn = _context.Attach(owner).Entity;
            _context.SaveChanges();
            return OwnerToReturn;
        }

        public Owner Update(Owner ownerUpdate)
        {
           Owner owner1 = _context.owners.ToList().First(o => o.id == ownerUpdate.id);
            owner1 = ownerUpdate;
            _context.SaveChanges();
            return owner1;
        }

        public void Remove(Owner owner)
        {
            _context.owners.ToList().Find(own => own.id == owner.id);
            _context.owners.Remove(owner);
            _context.SaveChanges();
        }

        public IEnumerable<Owner> ReadAll()
        {
            return _context.owners.ToList();
        }

        public Owner FindOwnerById(int id)
        {
            return _context.owners.Find(id);
        }
    }
}
