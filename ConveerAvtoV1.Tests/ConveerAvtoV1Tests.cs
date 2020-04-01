using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConveerAvtoV1.Tests
{
    [TestClass]
    public class ConveerAvtoV1Tests
    {
        [TestMethod]
        public void UznatDiametrKoles_Void_ReturnKolesaDiametr()
        {
            int expected = 20;
            Kolesa myKolesa = new Kolesa();
            
            myKolesa.Diametr = 20;
           
            myKolesa.VidKoles = "vid kolesa";

            
            myKolesa.Name = "Name koles";

            Kuzov myKuzuv = new Kuzov();
           
            Motor myMotor = new Motor();
            
            Car avto = new Car(myKuzuv, myKolesa, myMotor);
            int actual = avto.UznatDiametrKoles();
            Assert.AreEqual(expected, actual);
        }
    }
}
