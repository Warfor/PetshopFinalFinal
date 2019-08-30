using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DomainService;
using Entity;

namespace Infrastructure.Repositories
{
    public class PetRepository : IPetRepository
    {
        public Pet create(Pet pet)
        {
            pet.Id = FakeDB.PetId++;
            FakeDB.PetList.Add(pet);
            return pet;
        }

        public void RemovePet(int id)
        {
            FakeDB.PetList.Remove(FakeDB.PetList.FirstOrDefault(pet => pet.Id == id));
        }

        public List<Pet> ReadAll()
        {
            return FakeDB.PetList;

        }
    }
}
