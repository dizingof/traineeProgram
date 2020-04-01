﻿using System;
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
            int razmerDlini = 10;
            Dlina dlinaShkafa = new Dlina(razmerDlini);
            int actual = dlinaShkafa.GetDlina();
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
