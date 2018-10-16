using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationResponsables;


namespace TestPasserelle
{
    [TestClass]
    public class TestQuentin
    {
 
         [TestMethod]
        public void TestrecupCapaMax()
        {
            int attendu = 50;
            int service = 1;
            int actuel = Passerelle.recupCapacitéMax(service);

            Assert.AreEqual(attendu, actuel);


        }

        [TestMethod]
        public void testTauxOccupationMoisService()
         {
             int attendu = 60;

             int mois = 1;
             int service = 1;

             Double tauxRecup = Passerelle.tauxOccuMoisService(mois, service);

             Assert.AreEqual(attendu, tauxRecup);
         }

         [TestMethod]
        public void testOccupantsHopitalParMois()
        {
            int attendu = 59;

            int actuel = Passerelle.getOccupantsHopitalParMois(1);

            Assert.AreEqual(attendu, actuel);



        }


    }
}
