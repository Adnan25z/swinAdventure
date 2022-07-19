using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public interface IHaveInventory
    {
        GameObject Locate(string id);
        GameObject Take(string id);
        void Put(Item item);
        string Name { get; }
        Inventory Inventory { get; }
    }
}
