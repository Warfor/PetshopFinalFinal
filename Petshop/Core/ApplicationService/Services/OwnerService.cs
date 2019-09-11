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

        public OwnerService(IOwnerRepository OwnerRepo)
        {
            ownerRepository = OwnerRepo;
        }
        public Owner Create(Owner owner)
        {
            return ownerRepository.Create(owner);
        }

        public IEnumerable<Owner> ReadAll()
        {
            return ownerRepository.ReadAll().ToList();
        }

        public void Remove(Owner owner)
        {
            ownerRepository.Remove(owner);
        }

        public Owner Update(int id)
        {
            
        }

        public void RemoveOwner(int id)
        {
            ownerRepository.Remove(id);
        }

        public Owner UpdateOwner(int owners)
        {
            Owner owner = ownerRepository.FindOwnerById(owners);
            owner = ownerRepository.Update(owner);
            return owner;
        }

        public Owner FindOwnerById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
