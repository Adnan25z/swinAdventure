using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class Location : GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private List<Path> _paths;

        public Location(string[] ids, string name, string description) : base(ids, name, description)
        {
            _inventory = new Inventory();
            _paths = new List<Path>();
        }

        public GameObject Locate(string id)
        {
            if (AreYou(id))
            {
                return this;
            }
            return _inventory.Fetch(id);
        }

        public void AddPath(Path p)
        {
            _paths.Add(p);
        }

        public Path GetPath(string id)
        {
            foreach(Path p in _paths)
            {
                if (p.AreYou(id))
                    return p;
            }
            return null;
        }

        public GameObject Take(string id)
        {
            return _inventory.Take(id);
        }

        public void Put(Item item)
        {
            _inventory.Put(item);
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public override string FullDescription
        {
            // Read only property of FullDescription for Location
            get
            {
                return "You are going " + Name + ".\n" + base.FullDescription + "\nIn this place you can view:" + _inventory.ItemList;
            }
        }

        public Inventory InventoryAtLoc
        {
            get
            {
                return _inventory;
            }
        }

        public List<Path> Paths
        {
            get { return _paths; }
        }
    }
}
