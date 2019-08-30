using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Core.DomainService
{
    public interface IPetRepository
    {
        List<Pet> ReadAll();

        Pet create(Pet pet);

        void RemovePet(int id);
    }
}
