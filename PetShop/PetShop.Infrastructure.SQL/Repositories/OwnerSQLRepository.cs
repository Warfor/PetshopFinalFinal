using System;
using System.Collections.Generic;
using System.Text;
using Core.DomainService;
using Entity;
using SQLitePCL;

namespace PetShop.Infrastructure.SQL.Repositories
{
    class OwnerSQLRepository : IOwnerRepository
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
            throw new NotImplementedException();
        }

        public void Remove(Owner owner)
        {
            
        }

        public IEnumerable<Owner> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Owner FindOwnerById(int id)
        {
            return _context.owners.Find(id);
        }
    }
}
