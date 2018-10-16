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
        public TauxOccuGlobalParAn()
        {
            InitializeComponent();

            chartTauxOccuGlobalParAn.Titles["Title1"].Text = "Taux d'occupation en pourcent pour l'ensemble de l'hopital, pour l'année 2018 ";
            chartTauxOccuGlobalParAn.ChartAreas[0].AxisY.Maximum = 100;
            chartTauxOccuGlobalParAn.ChartAreas[0].AxisY.Minimum = 0;

            Dictionary<int, String> serviceParID = new Dictionary<int, string>();
            int i = 1;
            ArrayList lesServices = Passerelle.getServices();
            foreach (String unService in lesServices)
            {
                serviceParID.Add(i, unService);
                i++;

            }

            Double taux = 0;
            foreach (int unService in serviceParID.Keys)
            {
                Double moyenne = Passerelle.moyPatientsAneeParService(unService);
                taux+=moyenne;
            }
            taux = taux/4;



        }

        private void chart1_Click(object sender, EventArgs e)
        {



        }
    }
}
