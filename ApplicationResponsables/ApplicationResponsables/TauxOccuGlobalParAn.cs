using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;


namespace ApplicationResponsables
{
    public partial class TauxOccuGlobalParAn : Form
    {
        public TauxOccuGlobalParAn(int pMoisDebut, int pMoisFin, int pAnneeChoisie)
        {
            InitializeComponent();

            chartTauxOccuGlobalParAn.Titles["Title1"].Text = "Taux d'occupation en pourcent pour l'ensemble de l'hopital, pour l'année "+pAnneeChoisie;
            chartTauxOccuGlobalParAn.ChartAreas[0].AxisY.Maximum = 100;
            chartTauxOccuGlobalParAn.ChartAreas[0].AxisY.Minimum = 0;
            int i=0;

            for (i = pMoisDebut; i < pMoisFin ; i++)
            {
                String mois = getIntituleMois(i);
                Double taux = Passerelle.tauxOccupationParMois(i,pAnneeChoisie);
                chartTauxOccuGlobalParAn.Series["Taux"].Points.AddXY(mois, taux);              


            }

        }


        private static String getIntituleMois(int pMois)
        {
            String intitule;
            String[] lesMois = new String[12];
            lesMois[0] = "Janvier";
            lesMois[1] = "Février";
            lesMois[2] = "Mars";
            lesMois[3] = "Avril";
            lesMois[4] = "Mai";
            lesMois[5] = "Juin";
            lesMois[6] = "Juillet";
            lesMois[7] = "Aout";
            lesMois[8] = "Septembre";
            lesMois[9] = "Octobre";
            lesMois[10] = "Novembre";
            lesMois[11] = "Descembre";

            intitule = lesMois[pMois - 1];
            return intitule;

        }

        private void chartTauxOccuGlobalParAn_Click(object sender, EventArgs e)
        {

        }
    }
}
