using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core.DomainService;
using Entity;

namespace Infrastructure.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        public Owner Create(Owner owner)
        {
            throw new NotImplementedException();
        }

        public Owner Update(Owner HumanOwner)
        {
             Owner owner = FindOwnerById(HumanOwner.Id);
            owner = Update(HumanOwner);

            return owner;
        }

        public void Remove(Owner owner)
        {
            Remove(owner);
        }

        public IEnumerable<Owner> ReadAll()
        {
            return FakeDB.OwnerList;
        }

        public Owner FindOwnerById(int ID)
        {
            {
                foreach (var owner in ReadAll())
                {
                    if (owner.Id == ID)

                    {
                        return owner;
                    }
                }
                return null;
            }
        }
    }
}
