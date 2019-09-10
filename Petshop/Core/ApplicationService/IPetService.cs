using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Core.ApplicationService
{
    public interface IPetService
    {
        List<Pet> FindAllPets();

        Pet Add(Pet pet);

        Pet FindSingle(int id);

        void RemovePet(int id);
        Pet UpdatePet(Pet pets);

        Pet FindPetById(int id);

        List<Pet> SortByPrice(List<Pet> pets);
        List<Pet> SearchRace(String race);

    }
}
