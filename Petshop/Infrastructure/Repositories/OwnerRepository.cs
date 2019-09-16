using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.ApplicationService;
using Core.DomainService;
using Entity;

namespace Infrastructure.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner Create(Owner owner)
        {
            owner.id = FakeDB.OwnerId++;
            FakeDB.OwnerList.Add(owner);
            return owner;
        }

        public Owner Update(Owner ownerUpdate)
        {
            var owner = FindOwnerById(ownerUpdate.id);
            owner.Name = ownerUpdate.Name;
            return owner;
        }

        public void Remove(Owner owner)
        {
            FakeDB.OwnerList.Remove(owner);

        }

        public IEnumerable<Owner> ReadAll()
        {
            return FakeDB.OwnerList.ToList();
        }

        public Owner FindOwnerById(int ID)
        {
            {
                foreach (var owner in ReadAll())
                {
                    if (owner.id == ID)

                    {
                        return owner;
                    }
                }
                return null;
            }
        }
    }
}
