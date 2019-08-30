using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DomainService;
using Entity;

namespace Core.ApplicationService
{
    public class PetService : IPetService
    {
        private IPetRepository petrepository;

        public PetService(IPetRepository petRepo)
        {
            petrepository = petRepo;
        }

        public List<Pet> FindAllPets()
        {
            return petrepository.ReadAll();
        }

        public Pet Add(Pet pet)
        {
            return petrepository.create(pet);
        }

        public Pet FindSingle(int id)
        {
            return petrepository.ReadAll().FirstOrDefault(pet => pet.Id == id);
        }

        public void RemovePet(int id)
        {
            petrepository.RemovePet(id);
        }
    }
}
