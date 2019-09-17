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

        public void UpdatePet(Pet petUpdate)
        {
            var pet = FindPetById(petUpdate.Id);
            pet.Name = petUpdate.Name;
            pet.Color = petUpdate.Color;
            pet.Race = petUpdate.Race;
        }

        public Pet FindPetById(int id)
        {
            {
                foreach (var pet in FakeDB.PetList.ToList())
                {
                    if (pet.Id == id)

                    {
                        return pet;
                    }
                }
                return null;
            }
        }

        public IEnumerable<Pet> ReadAll()
        {
            return FakeDB.PetList;

        }
    }
}
