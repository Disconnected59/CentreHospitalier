using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient; //import pie chart
using System.Configuration; //import pie chart
using System.Windows.Forms.DataVisualization.Charting; //import pie chart

namespace ApplicationResponsables
{
    public partial class TauxOccuPeriodeService : Form
    {
        public TauxOccuPeriodeService(Double taux, DateTime pDateDebut, DateTime pDateFin, String pServiceChoisi)
        {
            InitializeComponent();
            Double innocupé = 100 - taux;



            chartTauxOccuPeriodeService.Titles.Add("Taux d'occupation du service "+pServiceChoisi+" pour la période du "+pDateDebut+" au "+pDateFin);
            chartTauxOccuPeriodeService.Series["Series1"].IsValueShownAsLabel = true;
            chartTauxOccuPeriodeService.Series["Series1"].Points.AddXY("Occuppé", taux);
            chartTauxOccuPeriodeService.Series["Series1"].Points.AddXY("Innocuppé", innocupé);


        }

        private void chart1_Click(object sender, EventArgs e)
        {






        }
    }
}
