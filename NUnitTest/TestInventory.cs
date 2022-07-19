using System;
using NUnit.Framework;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Iteration1;

namespace Iteration1
{
    [TestFixture()]
    public class TestInventory
    {
		[Test()]
		public void TestNoItemFind()
		{
			Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
			Inventory testInventory = new Inventory();
			testInventory.Put(shovel);
			Assert.IsFalse(testInventory.HasItem("sword"));
		}


		[Test()]
		public void TestFindItem()
		{
			Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
			Inventory testInventory = new Inventory();
			testInventory.Put(shovel);
			Assert.True(testInventory.HasItem("shovel"));
		}

		

		[Test()]
		public void TestFetchItem()
		{
			Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
			Inventory testInventory = new Inventory();
			testInventory.Put(shovel);
			Assert.IsInstanceOf<Item>(testInventory.Fetch("shovel"));
			Assert.AreSame(shovel, testInventory.Fetch("shovel"));
			Assert.AreEqual("shovel", testInventory.Fetch("shovel").FirstId);
		}

		[Test()]
		public void TestTakeItem()
		{
			Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
			Inventory testInventory = new Inventory();
			testInventory.Put(shovel);
			testInventory.Take("shovel");
			Assert.IsNull(testInventory.Fetch("shovel"));
		}

		[Test()]
		public void TestItemList()
		{
			Item shovel = new Item(new String[] { "shovel", "spade" }, "a shovel", "This is a might fine ...");
			Item sword = new Item(new String[] { "sword", "short sword" }, "a sword", "This is a short sword ...");
			Inventory testInventory = new Inventory();
			testInventory.Put(shovel);
			testInventory.Put(sword);

			Assert.AreEqual("\n\t" + shovel.ShortDesc + "\n\t" + sword.ShortDesc, testInventory.ItemList);
		}
	}
}
