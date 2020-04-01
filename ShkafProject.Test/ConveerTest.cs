using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShkafProject.Test
{
    [TestClass]
    public class ConveerTest
    {
        [TestMethod]
        public void Conveer_VvodRazmerov_Void_DictionaryReturned()
        {
            //arrange
            

            
            Dictionary<string, int> expected = new Dictionary<string, int>();
            expected.Add("Visota", 10);
            expected.Add("Shirina", 20);
            expected.Add("Dlina", 30);
            expected.Add("Glubina", 40);
            //act
            Conveer myConv = new Conveer();


            Dictionary<string, int> actual = myConv.VvodRazmerov();

            //Assert
            Assert.AreEqual(expected["Visota"], actual["Visota"]);

        }
    }
}
