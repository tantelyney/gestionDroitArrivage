using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDroitArrivage
{
    public partial class UCvehicule : UserControl
    {
        public UCvehicule()
        {
            InitializeComponent();
        }

        private void UserControlVeh_Load(object sender, EventArgs e)
        {
            //chargement des données pour la 'comboBoxRefProprietaire'
            string query = "SELECT ref_proprietaire FROM proprietaire";
            connectionDb.creerConnection();
            DataTable table = connectionDb.recuperData(query);
            connectionDb.fermerConnection();
            comboBoxRefProprietaire.DataSource = table;
            comboBoxRefProprietaire.ValueMember = "ref_proprietaire";

            //chargement des données pour la 'comboBoxNumTransporteur'
            string query2 = "SELECT num_trans FROM transporteur";
            connectionDb.creerConnection();
            DataTable table2 = connectionDb.recuperData(query2);
            connectionDb.fermerConnection();
            comboBoxNumTransporteur.DataSource = table2;
            comboBoxNumTransporteur.ValueMember = "num_trans";

            chargerDataVehicule();
            clearChamp();
        }

        private void chargerDataVehicule()
        {
            string query1 = "SELECT * FROM vehicule";
            connectionDb.creerConnection();
            DataTable table1 = connectionDb.recuperData(query1);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table1;
        }

        private void clearChamp()
        {
            champMatricule.Clear();
            champTypeVehicule.Clear();
            comboBoxRefProprietaire.Text = "";
            comboBoxNumTransporteur.Text = "";
            dataGridView1.ClearSelection();
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                chargerDataVehicule();
                textBoxRecherche.PlaceholderText = "matricule du véhicule";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT * FROM vehicule WHERE matricule LIKE '%" + textBoxRecherche.Text + "%' ";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            champMatricule.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            champTypeVehicule.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxRefProprietaire.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxNumTransporteur.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (champMatricule.Text == "" || champTypeVehicule.Text == "" || comboBoxRefProprietaire.Text == "" || comboBoxNumTransporteur.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO vehicule VALUES('" + champMatricule.Text + "', '" + champTypeVehicule.Text + "', " +
                    "'" + comboBoxRefProprietaire.Text + "', '" + comboBoxNumTransporteur.Text + "') ";
                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataVehicule();
                clearChamp();
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à modifier !", "Gestion de droit d'arrivage" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (champMatricule.Text == "" || champTypeVehicule.Text == "" || comboBoxRefProprietaire.Text == "" || comboBoxNumTransporteur.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var matricule = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string query = "UPDATE vehicule SET matricule='" + champMatricule.Text + "', type='" + champTypeVehicule.Text + "'," +
                    " ref_proprietaire='" + comboBoxRefProprietaire.Text + "', num_trans='" + comboBoxNumTransporteur.Text + "'" +
                    " WHERE matricule='" + matricule + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();
                chargerDataVehicule();
                clearChamp();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à supprimer !", "Gestion de droit d'arrivage" +
                    "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Voullez vous vraiment supprimer cette enregistrement ?", "" +
                    "Gestion de droit d'arrivage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    var matricule = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM vehicule WHERE matricule='" + matricule + "' ";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query);
                    connectionDb.fermerConnection();
                    chargerDataVehicule();
                    clearChamp();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }

        private void champMatricule_TextChanged(object sender, EventArgs e)
        {
            if (champMatricule.Text.Length > 15)
            {
                errorProvider1.SetError(champMatricule, "La valeur saisie dépasse la taille maximale autorisée de 15 caractères");
                champMatricule.Text = champMatricule.Text.Substring(0, 15);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champTypeVehicule_TextChanged(object sender, EventArgs e)
        {
            if (champTypeVehicule.Text.Length > 25)
            {
                errorProvider1.SetError(champTypeVehicule, "La valeur saisie dépasse la taille maximale autorisée de 25 caractères");
                champTypeVehicule.Text = champTypeVehicule.Text.Substring(0, 25);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxRefProprietaire_Leave(object sender, EventArgs e)
        {
            if (comboBoxRefProprietaire.Text.Length > 5)
            {
                errorProvider1.SetError(comboBoxRefProprietaire, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                comboBoxRefProprietaire.Text = comboBoxRefProprietaire.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxNumTransporteur_Leave(object sender, EventArgs e)
        {
            if (comboBoxNumTransporteur.Text.Length > 5)
            {
                errorProvider1.SetError(comboBoxNumTransporteur, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                comboBoxNumTransporteur.Text = comboBoxNumTransporteur.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
