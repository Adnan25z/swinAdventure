using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;

namespace Iteration1
{
    [TestFixture]
    public class TestBag
    {
        Bag bag1, bag2;
        Item TestItem, TestItem2;

        [SetUp]
        public void Setup()
        {
            bag1 = new Bag(new string[] { "bag", "level_1" }, "level_1 bag", "low storage capacity bag");
            bag2 = new Bag(new string[] { "bag2", "level_2" }, "level_2 bag", "medium storage capacity bag");
            TestItem = new Item(new string[] { "sword", "bronze" }, "bronze sword", "a grand bronze sword from years ago");
            TestItem2 = new Item(new string[] { "shovel", "spade" }, "a shovel", "This is a might fine");
        }

        [Test]
        public void BagLocatesItemsTest()
        {
            bag1.Inventory.Put(TestItem);
            Assert.IsTrue(bag1.Locate("sword") == TestItem);
        }

        [Test]
        public void BagLocatesItselfTest()
        {
            Assert.IsTrue(bag1.Locate("bag") == bag1);
        }

        [Test]
        public void BagLocatesNothingTest()
        {
            Assert.IsNull(bag1.Locate("backpack"));
        }

        [Test]
        public void BagFullDescriptionTest()
        {
            bag1.Inventory.Put(TestItem);
            string expected = "The items in level_1 bag are:\n" + "\n\tA bronze sword (sword)";
            Assert.AreEqual(bag1.FullDescription, expected);
        }

        [Test]
        public void BaginBagTest()
        {  
            bag1.Inventory.Put(TestItem);
            bag2.Inventory.Put(TestItem2);
            bag1.Inventory.Put(bag2);

            Assert.IsTrue(bag1.Locate("sword") == TestItem);
            Assert.IsFalse(bag1.Locate("shovel") == TestItem2);
            Assert.IsTrue(bag1.Locate("bag2") == bag2);

        }
    }
}
