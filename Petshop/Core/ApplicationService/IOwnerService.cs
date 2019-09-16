using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Core.ApplicationService
{
   public interface IOwnerService
    {

        void RemoveOwner(Owner owner);
        void UpdateOwner(Owner owners);
        Owner FindOwnerById(int id);
        List<Owner> ReadAll();
        Owner CreateOwner(Owner owner);
    }
}
