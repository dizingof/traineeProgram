using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShkafProject.Test
{
    [TestClass]
    public class DlinaTest
    {
        [TestMethod]
        public void Dlina_GetDlina_10_void_10returned()
        {
            //arrange
            int expected = 10;

            //act
            int razmerVisoti = 10;
            Visota visotaShkafa = new Visota(razmerVisoti);
            int actual = visotaShkafa.GetVisota();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
