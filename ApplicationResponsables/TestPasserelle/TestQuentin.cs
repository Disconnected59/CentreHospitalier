using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ApplicationResponsables;


namespace TestPasserelle
{
    [TestClass]
    public class TestQuentin
    {
        [TestMethod]
        public void TestnbOccupantsServicePeriode()
        {
            int attendu = 5;

           int service = 1;

            DateTime debutPeriode = new DateTime(2018,01,01);
            DateTime finPeriode = new DateTime(2018,12,31);

            int actuel = Passerelle.nbOccupantsServiceParPeriode(debutPeriode,finPeriode, service);

            Assert.AreEqual(attendu, actuel);

        }


         [TestMethod]
        public void TestrecupCapaMax()
        {
            int attendu = 50;
            int service = 1;
            int actuel = Passerelle.recupCapacitéMax(service);

            Assert.AreEqual(attendu, actuel);


        }

        [TestMethod]
        public void testTauxOccupationPeriodeService()
         {
             int attendu = 10;
             DateTime debutPeriode = new DateTime(2018, 01, 01);
             DateTime finPeriode = new DateTime(2018, 12, 31);
             int service = 1;

             Double taux = Passerelle.tauxOccupationPeriodeService(debutPeriode, finPeriode, service);

             Assert.AreEqual(attendu, taux);

         }


    }
}
