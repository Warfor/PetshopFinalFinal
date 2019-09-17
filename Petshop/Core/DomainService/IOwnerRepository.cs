using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Core.DomainService
{
    public interface IOwnerRepository
    {
        Owner Create(Owner owner);

        Owner Update(Owner ownerUpdate);

        void Remove(Owner owner);

        IEnumerable<Owner> ReadAll();

        Owner FindOwnerById(int id);

    }
}
