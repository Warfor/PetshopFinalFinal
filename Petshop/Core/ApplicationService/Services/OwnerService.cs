using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Core.DomainService;
using Entity;

namespace Core.ApplicationService
{
    public class OwnerService : IOwnerService
    {
        private IOwnerRepository ownerRepository;


        public void RemoveOwner(Owner owner)
        {
            ownerRepository.Remove(owner);
        }

        public void UpdateOwner(Owner owners)
        {
            ownerRepository.Update(owners);
        }

        public Owner FindOwnerById(int id)
        {
            {
                foreach (var owner in ReadAll())
                {
                    if (owner.id == id)

                    {
                        return owner;
                    }
                }
                return null;
            }
        }

        public List<Owner> ReadAll()
        {
            return ownerRepository.ReadAll().ToList();
        }

        public Owner CreateOwner(Owner owner)
        {
            return ownerRepository.Create(owner);
        }
    }
}
