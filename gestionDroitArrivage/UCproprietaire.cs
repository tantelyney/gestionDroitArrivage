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
    public partial class UCproprietaire : UserControl
    {
        public UCproprietaire()
        {
            InitializeComponent();
        }

        private void UserControlPropri_Load(object sender, EventArgs e)
        {
            chargerDataProprietaire();
            clearChamp();
        }

        private void chargerDataProprietaire()
        {
            string query1 = "SELECT * FROM proprietaire";
            connectionDb.creerConnection();
            DataTable table1 = connectionDb.recuperData(query1);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table1;
        }

        private void clearChamp()
        {
            champRefProprietaire.Clear();
            champNom.Clear();
            champPrenoms.Clear();
            champAdresse.Clear();
            champTelephone.Clear();
            dataGridView1.ClearSelection();
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                chargerDataProprietaire();
                textBoxRecherche.PlaceholderText = "nom/prénoms du propriétaire";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT * FROM proprietaire WHERE nom_prop LIKE '%" + textBoxRecherche.Text + "%' " +
                    "OR prenoms_prop LIKE '%" + textBoxRecherche.Text + "%'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            champRefProprietaire.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            champNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            champPrenoms.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            champAdresse.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            champTelephone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (champRefProprietaire.Text == "" || champNom.Text == "" || champPrenoms.Text == "" || champAdresse.Text == "" || champTelephone.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Int64.TryParse(champTelephone.Text, out _) && champTelephone.Text.Substring(0) != "+")
            {
                MessageBox.Show("Valeur invalide. La valeur saisie doit être composée que des chiffres sauf pour celle qui commence par +261 ", "" +
                    "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champTelephone.Clear();
                champTelephone.Focus();
            }
            else
            {
                string query = "INSERT INTO proprietaire VALUES('" + champRefProprietaire.Text + "', '" + champNom.Text + "'," +
                    " '" + champPrenoms.Text + "', '" + champAdresse.Text + "', '" + champTelephone.Text + "') ";
                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataProprietaire();
                clearChamp();
            }
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à modifier !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (champRefProprietaire.Text == "" || champNom.Text == "" || champPrenoms.Text == "" || champAdresse.Text == "" || champTelephone.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!Int64.TryParse(champTelephone.Text, out _) && champTelephone.Text.Substring(0) != "+")
            {
                MessageBox.Show("Valeur invalide. La valeur saisie doit être composée que des chiffres sauf pour celle qui commence par +261 ", "" +
                    "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champTelephone.Clear();
                champTelephone.Focus();
            }
            else
            {
                var refPropri = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                string query = "UPDATE proprietaire SET ref_proprietaire='" + champRefProprietaire.Text + "', nom_prop='" + champNom.Text + "', " +
                    "prenoms_prop='" + champPrenoms.Text + "', adresse_prop='" + champAdresse.Text + "', tel_prop='" + champTelephone.Text + "' " +
                    "WHERE ref_proprietaire='" + refPropri + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();
                chargerDataProprietaire();
                clearChamp();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à supprimer !", "Gestion de droit d'arrivage", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Voullez vous vraiment supprimer cette enregistrement ?", "Gestion de droit d'arrivage",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    var refPropri = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM proprietaire WHERE ref_proprietaire='" + refPropri + "' ";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query);
                    connectionDb.fermerConnection();
                    chargerDataProprietaire();
                    clearChamp();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }

        private void champRefProprietaire_TextChanged(object sender, EventArgs e)
        {
            if (champRefProprietaire.Text.Length > 5)
            {
                errorProvider1.SetError(champRefProprietaire, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champRefProprietaire.Text = champRefProprietaire.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champNom_TextChanged(object sender, EventArgs e)
        {
            if (champNom.Text.Length > 50)
            {
                errorProvider1.SetError(champNom, "La valeur saisie dépasse la taille maximale autorisée de 50 caractères");
                champNom.Text = champNom.Text.Substring(0, 50);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champPrenoms_TextChanged(object sender, EventArgs e)
        {
            if (champPrenoms.Text.Length > 50)
            {
                errorProvider1.SetError(champPrenoms, "La valeur saisie dépasse la taille maximale autorisée de 50 caractères");
                champPrenoms.Text = champPrenoms.Text.Substring(0, 50);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champAdresse_TextChanged(object sender, EventArgs e)
        {
            if (champAdresse.Text.Length > 50)
            {
                errorProvider1.SetError(champAdresse, "La valeur saisie dépasse la taille maximale autorisée de 50 caractères");
                champAdresse.Text = champAdresse.Text.Substring(0, 50);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champTelephone_TextChanged(object sender, EventArgs e)
        {
            if (champTelephone.Text.Length > 13)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champTelephone, "La valeur saisie dépasse la taille maximale autorisée de 13 caractères");
                champTelephone.Text = champTelephone.Text.Substring(0, 13);
            }
            else if (!Int64.TryParse(champTelephone.Text, out _) && champTelephone.Text.Substring(0) != "+")
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champTelephone, "Valeur invalide. La valeur saisie doit être composée que des chiffres sauf pour celle qui commence par +261");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
