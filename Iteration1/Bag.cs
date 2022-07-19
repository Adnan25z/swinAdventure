using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class Bag: Item, IHaveInventory
    {
        Inventory _inventory;

        public Inventory Inventory
        {
            get => _inventory;
        }

        public Bag(string[] ids, string name, string desc) : base(ids, name, desc)
        {
            _inventory = new Inventory();
        }

        public override string FullDescription
        {
            get
            {
                return $"The items in {this.Name} are:\n" + _inventory.ItemList;
            }
        }
        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public GameObject Take(string id)
        {
            return _inventory.Take(id);
        }

        public void Put(Item item)
        {
            _inventory.Put(item);
        }
    }
}
