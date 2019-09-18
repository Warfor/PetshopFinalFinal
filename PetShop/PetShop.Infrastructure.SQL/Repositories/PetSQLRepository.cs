using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.ApplicationService;
using Core.DomainService;
using Entity;

namespace PetShop.Infrastructure.SQL
{
    public class PetSQLRepository : IPetRepository
    {
        private PetShopContext _context;

        public PetSQLRepository(PetShopContext context)
        {
            _context = context;
        }

        public IEnumerable<Pet> ReadAll()
        {
            return _context.Pets.ToList();
        }

        public Pet create(Pet pet)
        {
            Pet PetToReturn = _context.Attach(pet).Entity;
            _context.SaveChanges();
            return PetToReturn;
        }

        public void RemovePet(int id)
        {
           Pet pet = _context.Pets.ToList().Find(p => p.Id == id);
            _context.Pets.Remove(pet);
            _context.SaveChanges();
        }

        public void UpdatePet(Pet pet)
        {
            Pet pet1 = _context.Pets.ToList().First(p => p.Id == pet.Id);
            pet1 = pet;
            _context.SaveChanges();
        }

        public Pet FindPetById(int id)
        {
            return _context.Pets.Find(id);
        }
    }
}
