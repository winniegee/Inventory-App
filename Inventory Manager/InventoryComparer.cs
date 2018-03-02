using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory_Manager;

namespace Inventory_Manager
{
    class InventoryComparer : IEqualityComparer<Inventory>
    {
        public bool Equals(Inventory x, Inventory y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Inventory obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
