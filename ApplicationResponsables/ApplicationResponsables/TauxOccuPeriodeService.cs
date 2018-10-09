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





        }

        private void chart1_Click(object sender, EventArgs e)
        {






        }
    }
}
