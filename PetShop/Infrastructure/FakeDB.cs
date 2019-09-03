using Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure
{
   public class FakeDB
    {
        internal static int PetId = 1;
        internal static List<Pet> PetList = new List<Pet>();

        public static void InitData()
        {
            throw new NotImplementedException();
        }
    }
}
