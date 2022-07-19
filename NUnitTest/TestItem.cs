using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Iteration1
{
    [TestFixture]
    public class TestItem
    {
        Item i1;
    
        [SetUp]
        public void Initialize()
        {
            i1 = new Item(new string[] { "sword", "shield" }, "sword", "A grand bronze sword from years ago");
        }
        [Test]
        public void ItemTest()
        {
            Assert.IsTrue(i1.AreYou("sword"));
        }

        [Test]
        public void ShortDescription()
        {
            Assert.IsTrue(i1.ShortDesc == "A sword (sword)");
        }

        [Test]
        public void LongDescription()
        {
            Assert.IsTrue(i1.FullDescription == "A grand bronze sword from years ago");
        }
    }
}
