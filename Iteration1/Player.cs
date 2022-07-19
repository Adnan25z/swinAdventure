using System;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    public class Player: GameObject, IHaveInventory
    {
        private Inventory _inventory;
        private Location _location;

        public Player(string name, string desc) : base(new string[] { "me", "inventory" }, name, desc)
        {
            _inventory = new Inventory();
            _location = null;
        }

        public GameObject Locate(string id)
        {
            if (this.AreYou(id))
            {
                return this;
            }
            else
            {
                if (!(_location == null))
                {
                    return _location.Locate(id);
                }
                else if (_inventory.HasItem(id))
                {
                    return _inventory.Fetch(id);
                }
                else { return null; }
            }
        }

        public GameObject Take(string id)
        {
            return Inventory.Take(id);
        }

        public void Put(Item item)
        {
            _inventory.Put(item);
        }

        public override string FullDescription
        {
            get
            {
                return $"You are {this.Name} {base.FullDescription}\nYou are carrying:\n{_inventory.ItemList}";
            }
        }

        public Inventory Inventory
        {
            get
            {
                return _inventory;
            }
        }

        public Location Location
        {
            get { return _location; }
            set { _location = value; }
        }
    }
}
