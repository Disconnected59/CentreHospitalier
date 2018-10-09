using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationResponsables
{
    class Sejour
    {
        int id;
        String moisSejour;
        int anneeSejour;
        int nbPatient;
        int idService;
        int dureeMoyenne;

        public Sejour(int pId, String pMoisSejour,int pAnneeSejour, int pNbPatient, int pIdService, int pDureeMoyenne)
        {
            id = pId;
            moisSejour = pMoisSejour;
            anneeSejour = pAnneeSejour;
            nbPatient = pNbPatient;
            idService = pIdService;
            dureeMoyenne = pDureeMoyenne;

        }

        public String getMoisSejour()
        {
            return moisSejour;
        }

        public int getAneeSejour()
        {
            return anneeSejour;
        }

        public int getNbPatient()
        {
            return nbPatient;
        }

        public int getIdService()
        {
            return idService;
        }

        public int getDureeMoyenne()
        {
            return dureeMoyenne;
        }

    }

}
