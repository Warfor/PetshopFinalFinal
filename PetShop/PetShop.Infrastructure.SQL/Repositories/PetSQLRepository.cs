using System;
using System.Collections.Generic;
using System.Text;
using Core.ApplicationService;
using Core.DomainService;
using Entity;

namespace PetShop.Infrastructure.SQL
{
    class PetSQLRepository : IPetRepository
    {
        private PetShopContext _context;

        public PetSQLRepository(PetShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Pet> ReadAll()
        {
            throw new NotImplementedException();
        }

        public Pet create(Pet pet)
        {
            Pet PetToReturn = _context.Attach(pet).Entity;
            _context.SaveChanges();
            return PetToReturn;
        }

        public void RemovePet(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePet(Pet pet)
        {
            throw new NotImplementedException();
        }

        public Pet FindPetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
