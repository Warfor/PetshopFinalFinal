using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DomainService;
using Entity;

namespace Core.ApplicationService.Services
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
            return petrepository.ReadAll().ToList();
        }

        public Pet Add(Pet pet)
        {
            return petrepository.create(pet);
        }

        public Pet FindSingle(int id)
        {
            return petrepository.ReadAll().FirstOrDefault(pet => pet.Id == id);
        }

        public Pet FindPetById(int ID)
        {
            {
                foreach (var pet in FindAllPets())
                {
                    if (pet.Id == ID)

                    {
                        return pet;
                    }
                }
                return null;
            }
        }

        public Pet UpdatePet(Pet petUpdate)
        {
            var pet = FindPetById(petUpdate.Id);
            pet.Name = petUpdate.Name;
            pet.Color = petUpdate.Color;
            pet.Race = petUpdate.Race;
            return pet;
        }

        public void RemovePet(int id)
        {
            petrepository.RemovePet(id);
        }
        public List<Pet> SearchRace(String PetRace)
        {
            List<Pet> temp = new List<Pet>();

            foreach (var pet in petrepository.ReadAll().ToList())
            {
                if (pet.Race.Equals(PetRace))
                {
                    temp.Add(pet);
                }
            }

            return temp;

        }
        public List<Pet> SortByPrice(List<Pet> pets)
        {
            List<Pet> petts = pets;
            petts.Sort((pet1, pet2) => pet1.Price.CompareTo(pet2.Price));
            return pets;

        }
    }
}
