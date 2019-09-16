using System;
using System.Collections.Generic;
using System.Text;
using Entity;

namespace Core.ApplicationService
{
   public interface IOwnerService
    {

        void RemoveOwner(int id);
        Owner UpdateOwner(Owner owners);
        Owner FindOwnerById(int id);
        List<Owner> ReadAll();
    }
}
