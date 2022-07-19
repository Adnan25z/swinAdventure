using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Iteration1;

namespace Iteration1
{
    [TestFixture]
    public class TestIdentifiable
    {
        Identifiable details;

        [SetUp]
        public void SetUp()
        {
            details = new Identifiable(new string[] { "adnan", "103169535" });
        }

        [Test]
        public void TestAreYou()
        {
            Assert.IsTrue(details.AreYou("adnan"));
        }

        [Test]
        public void TestAreYouNot()
        {
            Assert.That(details.AreYou("ayaan"), Is.False);
        }

        [Test]
        public void TestAreYouCaseSensative()
        {
            Assert.That(details.AreYou("ADNAN"), Is.True);
        }

        [Test]
        public void TestFirstID()
        {
            Assert.IsTrue(details.FirstId == "adnan");
        }

        [Test]
        public void TestAddID()
        {
            details.AddIdentifier("hamza");
            Assert.IsTrue(details.AreYou("hamza"));
        }
    }
}