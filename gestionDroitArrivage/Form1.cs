using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using QuestPDF.Helpers;
using System;
using System.Data;
using System.Drawing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace gestionDroitArrivage
{
    public partial class Form1 : Form
    {
        private bool labelAccHovered = false;
        private bool labelArrHovered = false;
        private bool labelDroitHovered = false;
        private bool labelPayeHovered = false;
        private bool labelPropHovered = false;
        private bool labelTransHovered = false;
        private bool labelVehHovered = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSupprArrivage_Click(object sender, EventArgs e)
        {

        }

        private void btnAjoutArrivage_Click(object sender, EventArgs e)
        {

        }

        private void btnRead_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnModifArrivage_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genererHistogramme();
        }

        private void genererHistogramme()
        {
            var plotModel1 = new PlotModel { Title = "Statistique du nombre d'arrivage mensuel" };
            var plotModel2 = new PlotModel { Title = "Statistique des recettes mensuels" };

            string query1 = "SELECT MONTH(arrivage.date_arrivage) AS mois,  COUNT(arrivage.num_arrivage) AS nbArrivage, " +
                "YEAR(arrivage.date_arrivage) AS annee FROM arrivage GROUP BY MONTH(arrivage.date_arrivage) " +
                "HAVING annee=YEAR(CURRENT_DATE)";
            string query2 = "SELECT MONTH(arrivage.date_arrivage) AS mois, SUM(payement.montant) AS recette, " +
                "YEAR(arrivage.date_arrivage) AS annee FROM arrivage,payement " +
                "WHERE (DATE(arrivage.date_arrivage)=DATE(payement.date_arrivage)) " +
                "GROUP BY MONTH(arrivage.date_arrivage) HAVING annee=YEAR(CURRENT_DATE)";
            string query3 = "SELECT AVG(payement.montant) AS moyenne FROM payement " +
                "WHERE MONTH(payement.date_payement)=(MONTH(CURRENT_DATE))";
            DataTable tab1 = new DataTable();
            DataTable tab2 = new DataTable();
            DataTable tab3 = new DataTable();

            connectionDb.creerConnection();
            tab1 = connectionDb.recuperData(query1);
            tab2 = connectionDb.recuperData(query2);
            tab3 = connectionDb.recuperData(query3);
            connectionDb.fermerConnection();
            int nbRow1 = tab1.Rows.Count;
            int nbRow2 = tab2.Rows.Count;

            //graph 1
            for (int i = 0; i < nbRow1; i++)
            {
                int mois = Convert.ToInt32(tab1.Rows[i][0]);
                int nbArrivage = Convert.ToInt32(tab1.Rows[i][1]);

                var series1 = new LinearBarSeries
                {
                    ItemsSource = new[]
                    {
                    new DataPoint(mois, nbArrivage),
                    },
                };

                plotModel1.Series.Add(series1);
                plotView1.Model = plotModel1;
            }

            //graph 2
            for (int i = 0; i < nbRow2; i++)
            {
                int mois = Convert.ToInt32(tab2.Rows[i][0]);
                int recette = Convert.ToInt32(tab2.Rows[i][1]);

                var series2 = new LinearBarSeries
                {
                    ItemsSource = new[]
                    {
                    new DataPoint(mois, recette),
                    },
                };
                plotModel2.Series.Add(series2);
                plotView2.Model = plotModel2;
            }
            panelContenu.Controls.Clear();
            panelContenu.Controls.Add(plotView1);
            panelContenu.Controls.Add(plotView2);
            int lbl3Value;
            if (Convert.IsDBNull(tab3.Rows[0][0])) { lbl3Value = 0; }
            else { lbl3Value = Convert.ToInt32(tab3.Rows[0][0]); }
            label3.Text = "Moyenne des payements du mois : " + lbl3Value + " Ariary";
            panelContenu.Controls.Add(label3);
        }

        private void chargerDataArrivage()
        {

        }

        private void clearChamps()
        {

        }

        private void lblDateArrivage_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {

        }

        private void listBoxMarchandise_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {

        }

        private void menuArrivage_Enter(object sender, EventArgs e)
        {

        }

        private void menuArrivage_MouseEnter(object sender, EventArgs e)
        {
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.WhiteSmoke;

        }

        private void menuArrivage_MouseLeave(object sender, EventArgs e)
        {
            if (labelArrHovered == true)
            {
                menuArrivage.ForeColor = Color.Black;
                menuArrivage.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuArrivage.ForeColor = Color.Black;
                menuArrivage.BackColor = Color.White;
            }

        }

        private void menuDroit_MouseEnter(object sender, EventArgs e)
        {
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.WhiteSmoke;

        }

        private void menuDroit_MouseLeave(object sender, EventArgs e)
        {
            if (labelDroitHovered == true)
            {
                menuDroit.ForeColor = Color.Black;
                menuDroit.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuDroit.ForeColor = Color.Black;
                menuDroit.BackColor = Color.White;
            }

        }

        private void menuPayement_MouseEnter(object sender, EventArgs e)
        {
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.WhiteSmoke;

        }

        private void menuPayement_MouseLeave(object sender, EventArgs e)
        {
            if (labelPayeHovered == true)
            {
                menuPayement.ForeColor = Color.Black;
                menuPayement.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuPayement.ForeColor = Color.Black;
                menuPayement.BackColor = Color.White;
            }

        }

        private void menuProprietaire_MouseEnter(object sender, EventArgs e)
        {
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.WhiteSmoke;

        }

        private void menuProprietaire_MouseLeave(object sender, EventArgs e)
        {
            if (labelPropHovered == true)
            {
                menuProprietaire.ForeColor = Color.Black;
                menuProprietaire.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuProprietaire.ForeColor = Color.Black;
                menuProprietaire.BackColor = Color.White;
            }

        }

        private void menuTransporteur_MouseEnter(object sender, EventArgs e)
        {
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.WhiteSmoke;

        }

        private void menuTransporteur_MouseLeave(object sender, EventArgs e)
        {
            if (labelTransHovered == true)
            {
                menuTransporteur.ForeColor = Color.Black;
                menuTransporteur.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuTransporteur.ForeColor = Color.Black;
                menuTransporteur.BackColor = Color.White;
            }

        }

        private void menuVehicule_MouseEnter(object sender, EventArgs e)
        {
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.WhiteSmoke;

        }

        private void menuVehicule_MouseLeave(object sender, EventArgs e)
        {
            if (labelVehHovered == true)
            {
                menuVehicule.ForeColor = Color.Black;
                menuVehicule.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuVehicule.ForeColor = Color.Black;
                menuVehicule.BackColor = Color.White;
            }

        }

        private void menuVehicule_MouseClick(object sender, MouseEventArgs e)
        {

            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = false;
            labelDroitHovered = false;
            labelPayeHovered = false;
            labelPropHovered = false;
            labelTransHovered = false;
            labelVehHovered = true;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCvehicule form = new UCvehicule();
            panelContenu.Controls.Add(form);
            label2.Text = "Véhicules";
        }

        private void menuTransporteur_MouseHover(object sender, EventArgs e)
        {

        }

        private void menuTransporteur_MouseClick(object sender, MouseEventArgs e)
        {
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = false;
            labelDroitHovered = false;
            labelPayeHovered = false;
            labelPropHovered = false;
            labelTransHovered = true;
            labelVehHovered = false;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCtransporteur form = new UCtransporteur();
            panelContenu.Controls.Add(form);
            label2.Text = "Transporteur de marchandises";

        }

        private void menuProprietaire_MouseClick(object sender, MouseEventArgs e)
        {
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = false;
            labelDroitHovered = false;
            labelPayeHovered = false;
            labelPropHovered = true;
            labelTransHovered = false;
            labelVehHovered = false;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCproprietaire form = new UCproprietaire();
            panelContenu.Controls.Add(form);
            label2.Text = "Propriétaire de véhicules";
        }

        private void menuPayement_MouseClick(object sender, MouseEventArgs e)
        {
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = false;
            labelDroitHovered = false;
            labelPayeHovered = true;
            labelPropHovered = false;
            labelTransHovered = false;
            labelVehHovered = false;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCpayement form = new UCpayement();
            panelContenu.Controls.Add(form);
            label2.Text = "Payement des droit d'arrivages";
        }

        private void menuDroit_MouseClick(object sender, MouseEventArgs e)
        {
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = false;
            labelDroitHovered = true;
            labelPayeHovered = false;
            labelPropHovered = false;
            labelTransHovered = false;
            labelVehHovered = false;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCdroit form = new UCdroit();
            panelContenu.Controls.Add(form);
            label2.Text = "Droit de marchandises";
        }

        private void menuArrivage_MouseClick(object sender, MouseEventArgs e)
        {
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.BlanchedAlmond;
            //les autres
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.White;

            labelArrHovered = true;
            labelDroitHovered = false;
            labelPayeHovered = false;
            labelPropHovered = false;
            labelTransHovered = false;
            labelVehHovered = false;
            labelAccHovered = false;

            panelContenu.Controls.Clear();
            UCarrivage form = new UCarrivage();
            panelContenu.Controls.Add(form);
            label2.Text = "Arrivage de marchandises";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxRecherche_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void lblFermer_MouseEnter(object sender, EventArgs e)
        {
            lblFermer.BackColor = Color.DarkRed;
            lblFermer.ForeColor = Color.White;
        }

        private void lblFermer_MouseLeave(object sender, EventArgs e)
        {
            lblFermer.BackColor = Color.White;
            lblFermer.ForeColor = Color.Black;
        }

        private void lblFermer_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void btnQuitus_Click(object sender, EventArgs e)
        {

        }

        private void lblFermer_Click(object sender, EventArgs e)
        {

        }

        private void menuAccueil_MouseClick(object sender, MouseEventArgs e)
        {
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.BlanchedAlmond;
            //les autres
            menuArrivage.ForeColor = Color.Black;
            menuArrivage.BackColor = Color.White;
            menuVehicule.ForeColor = Color.Black;
            menuVehicule.BackColor = Color.White;
            menuDroit.ForeColor = Color.Black;
            menuDroit.BackColor = Color.White;
            menuPayement.ForeColor = Color.Black;
            menuPayement.BackColor = Color.White;
            menuProprietaire.ForeColor = Color.Black;
            menuProprietaire.BackColor = Color.White;
            menuTransporteur.ForeColor = Color.Black;
            menuTransporteur.BackColor = Color.White;

            labelAccHovered = true;
            labelArrHovered = false;
            labelDroitHovered = false;
            labelPayeHovered = false;
            labelPropHovered = false;
            labelTransHovered = false;
            labelVehHovered = false;

            panelContenu.Controls.Clear();
            genererHistogramme();
            label2.Text = "";
        }

        private void menuAccueil_MouseEnter(object sender, EventArgs e)
        {
            menuAccueil.ForeColor = Color.Black;
            menuAccueil.BackColor = Color.WhiteSmoke;

        }

        private void menuAccueil_MouseLeave(object sender, EventArgs e)
        {
            if (labelAccHovered == true)
            {
                menuAccueil.ForeColor = Color.Black;
                menuAccueil.BackColor = Color.BlanchedAlmond;
            }
            else
            {
                menuAccueil.ForeColor = Color.Black;
                menuAccueil.BackColor = Color.White;
            }
        }
    }
}
