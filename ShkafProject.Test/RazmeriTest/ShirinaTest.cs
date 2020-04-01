using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShkafProject.Test.RazmeriTest
{
    [TestClass]
    public class ShirinaTest
    {
        [TestMethod]
        public void Shirina_GetShirina_10_void_10returned()
        {
            //arrange
            int expected = 10;

            //act
            int razmerShirini = 10;
            Shirina shirinaShkafa = new Shirina(razmerShirini);
            int actual = shirinaShkafa.GetShirina();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
