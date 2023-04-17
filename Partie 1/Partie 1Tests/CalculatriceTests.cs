using Microsoft.VisualStudio.TestTools.UnitTesting;
using Partie_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partie_1.Tests
{
    [TestClass()]
    public class CalculatriceTests
    {
        int nb1 = 2;
        int nb2 = 3;
        [TestMethod()]
        public void ExposantTest()
        {
           Assert.AreEqual(8, Math.Pow(nb1, nb2), "L'exposant ne marche pas");
        }

        [TestMethod()]
        public void LogTest()
        {
            nb1 = 2;
            nb2 = 2;
            Assert.AreEqual(1, Math.Log(nb1, nb2), "La logarithmique ne marche pas");
        }

        [TestMethod()]
        public void SoustraireTest()
        {
            Assert.AreEqual(-1, nb1 - nb2, "La soustraction ne marche pas");
        }

        [TestMethod()]
        public void AdditionerTest()
        {
            Assert.AreEqual(5, nb1 + nb2, "L'addition ne marche pas");
        }

        [TestMethod()]
        public void MultiplierTest()
        {
            Assert.AreEqual(6, nb1 * nb2, "La multiplication ne marche pas");
        }

        [TestMethod()]
        public void DiviserTest()
        {
            nb1 = 4;
            nb2 = 2;
            Assert.AreEqual(2, nb1 / nb2, "La division ne marche pas");
        }
    }
}