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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            ArrayList lesMois = new ArrayList(); // Liste des mois pour la comboBox
            String leMois = "Janvier";
            lesMois.Add(leMois);
            leMois = "Février";
            lesMois.Add(leMois);
            leMois = "Mars";
            lesMois.Add(leMois);
            leMois = "Avril";
            lesMois.Add(leMois);
            leMois = "Mai";
            lesMois.Add(leMois);
            leMois = "Juin";
            lesMois.Add(leMois);
            leMois = "Juillet";
            lesMois.Add(leMois);
            leMois = "Aout";
            lesMois.Add(leMois);
            leMois = "Septembre";
            lesMois.Add(leMois);
            leMois = "Octobre";
            lesMois.Add(leMois);
            leMois = "Novembre";
            lesMois.Add(leMois);
            leMois = "Decembre";
            lesMois.Add(leMois);
            cbboxMois.DataSource = lesMois;

            ArrayList lesServices = Passerelle.getServices();
            cbboxService.DataSource = lesServices;



        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cbboxPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnvalider_Click(object sender, EventArgs e)
        {
            /*String serviceChoisi = (String)cbboxService.SelectedItem;
            int moisChoisi = (int)cbboxMois.SelectedIndex + 1;

            Passerelle.getdureemoyenne(serviceChoisi, moisChoisi);
            lblduree.Text = "La durée moyenne est ";*/
        }

        private void lblduree_Click(object sender, EventArgs e)
        {

        }

        private void btnValiderMois_Click(object sender, EventArgs e)
        {
            int moisChoisi = (int)cbboxMois.SelectedIndex + 1 ;
            switch (moisChoisi)
            {
                case 1:
                    dtpdebut.MinDate = new DateTime(2018, 1, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 1, 31);
                    dtpfin.MinDate = new DateTime(2018, 1, 1);
                    dtpfin.MaxDate = new DateTime(2018, 1, 31);

                    break;

                case 2:
                    dtpdebut.MinDate = new DateTime(2018, 2, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 2, 28);
                    dtpfin.MinDate = new DateTime(2018, 2, 1);
                    dtpfin.MaxDate = new DateTime(2018, 2, 28);
                    break;

                case 3:
                    dtpdebut.MinDate = new DateTime(2018, 3, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 3, 31);
                    dtpfin.MinDate = new DateTime(2018, 3, 1);
                    dtpfin.MaxDate = new DateTime(2018, 3, 31);
                    break;

                case 4:
                    dtpdebut.MinDate = new DateTime(2018, 4, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 4, 30);
                    dtpfin.MinDate = new DateTime(2018, 4, 1);
                    dtpfin.MaxDate = new DateTime(2018, 4, 30);
                    break;

                case 5:
                    dtpdebut.MinDate = new DateTime(2018, 5, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 5, 31);
                    dtpfin.MinDate = new DateTime(2018, 5, 1);
                    dtpfin.MaxDate = new DateTime(2018, 5, 31);
                    break;

                case 6:
                    dtpdebut.MinDate = new DateTime(2018, 6, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 6, 30);
                    dtpfin.MinDate = new DateTime(2018, 6, 1);
                    dtpfin.MaxDate = new DateTime(2018, 6, 30);
                    break;

                case 7:
                    dtpdebut.MinDate = new DateTime(2018, 7, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 7, 31);
                    dtpfin.MinDate = new DateTime(2018, 7, 1);
                    dtpfin.MaxDate = new DateTime(2018, 7, 31);
                    break;

                case 8:
                    dtpdebut.MinDate = new DateTime(2018, 8, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 8, 31);
                    dtpfin.MinDate = new DateTime(2018, 8, 1);
                    dtpfin.MaxDate = new DateTime(2018, 8, 31);
                    break;

                case 9:
                    dtpdebut.MinDate = new DateTime(2018, 9, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 9, 30);
                    dtpfin.MinDate = new DateTime(2018, 9, 1);
                    dtpfin.MaxDate = new DateTime(2018, 9, 30);
                    break;

                case 10:
                    dtpdebut.MinDate = new DateTime(2018, 10, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 10, 31);
                    dtpfin.MinDate = new DateTime(2018, 10, 1);
                    dtpfin.MaxDate = new DateTime(2018, 10, 31);
                    break;

                case 11:
                    dtpdebut.MinDate = new DateTime(2018, 11, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 11, 30);
                    dtpfin.MinDate = new DateTime(2018, 11, 1);
                    dtpfin.MaxDate = new DateTime(2018, 11, 30);
                    break;

                case 12:
                    dtpdebut.MinDate = new DateTime(2018, 12, 1);
                    dtpdebut.MaxDate = new DateTime(2018, 12, 31);
                    dtpfin.MinDate = new DateTime(2018, 12, 1);
                    dtpfin.MaxDate = new DateTime(2018, 12, 31);
                    break;

                default:


                    break;

            }
        }

        private void btnBascule2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }

        private void lblPeriode_Click(object sender, EventArgs e)
        {

        }
    }
}
