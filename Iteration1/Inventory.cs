﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Iteration1
{
    public class Inventory
    {
		private List<Item> _items;

		public Inventory()
		{
			_items = new List<Item>();
		}

		public bool HasItem(string id)
		{
			foreach (Item i in _items)
			{
                if (i.AreYou(id.ToLower()))
                {
					return true;
                }
			}
			return false;
		}

		public void Put(Item itm)
		{
			_items.Add(itm);
		}

		public Item Take(string id)
		{
			foreach(Item itm in _items)
            {
				if (itm.AreYou(id))
				{
					_items.Remove(itm);
					return itm;
				}
			}
			return null;
		}

		public Item Fetch(string id)
		{
			foreach (Item itm in _items)
			{
				if (itm.AreYou(id))
				{
					return itm;
				}
			}
			return null;
		}

		public string ItemList
		{
            get
			{
				string result = "";
				foreach (Item i in _items)
				{
					result += "\n\t" + i.ShortDesc;
				}
				return result;
			}			
		}
	}
}
