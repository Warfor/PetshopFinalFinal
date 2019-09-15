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

        public Owner Update(int id)
        {
             Owner owner = FindOwnerById(id);
            owner = Update(id);

            return owner;
        }

        public Owner Remove(Owner owner)
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
