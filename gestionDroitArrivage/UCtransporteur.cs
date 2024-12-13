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
    public partial class UCtransporteur : UserControl
    {
        public UCtransporteur()
        {
            InitializeComponent();
        }

        private void UserControlTransp_Load(object sender, EventArgs e)
        {
            chargerDataTransporteur();
            clearChamp();
        }

        private void chargerDataTransporteur()
        {
            string query = "SELECT * FROM transporteur";
            connectionDb.creerConnection();
            DataTable table = connectionDb.recuperData(query);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table;
        }

        private void clearChamp()
        {
            champNumTransporteur.Clear();
            champNom.Clear();
            champPrenoms.Clear();
            champCin.Clear();
            champAdresse.Clear();
            champTelephone.Clear();
            dataGridView1.ClearSelection();
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                chargerDataTransporteur();
                textBoxRecherche.PlaceholderText = "nom/prénoms du transporteur";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT * FROM transporteur WHERE nom_trans LIKE '%" + textBoxRecherche.Text + "%' " +
                    "OR prenoms_trans LIKE '%" + textBoxRecherche.Text + "%'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            champNumTransporteur.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            champNom.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            champPrenoms.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            champCin.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            champAdresse.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            champTelephone.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (champNumTransporteur.Text == "" || champNom.Text == "" || champPrenoms.Text == "" || champCin.Text == "" || champAdresse.Text == ""
                || champTelephone.Text == "")
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
                string query = "INSERT INTO transporteur VALUES('" + champNumTransporteur.Text + "', '" + champNom.Text + "'," +
                    " '" + champPrenoms.Text + "', '" + champCin.Text + "', '" + champAdresse.Text + "', '" + champTelephone.Text + "') ";
                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataTransporteur();
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
            else if (champNumTransporteur.Text == "" || champNom.Text == "" || champPrenoms.Text == "" || champCin.Text == "" 
                || champAdresse.Text == "" || champTelephone.Text == "")
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
                var numTransp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                string query = "UPDATE transporteur SET num_trans='" + champNumTransporteur.Text + "', nom_trans='" + champNom.Text + "', " +
                    "prenoms_trans='" + champPrenoms.Text + "', cin_trans='" + champCin.Text + "', adresse_trans='" + champAdresse.Text + "'," +
                    " tel_trans='" + champTelephone.Text + "' WHERE num_trans='" + numTransp + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();
                chargerDataTransporteur();
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
                    var numTransp = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    string query = "DELETE FROM transporteur WHERE num_trans='" + numTransp + "' ";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query);
                    connectionDb.fermerConnection();
                    chargerDataTransporteur();
                    clearChamp();
                }
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }

        private void champNumTransporteur_TextChanged(object sender, EventArgs e)
        {
            if (champNumTransporteur.Text.Length > 5)
            {
                errorProvider1.SetError(champNumTransporteur, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champNumTransporteur.Text = champNumTransporteur.Text.Substring(0, 5);
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

        private void champCin_TextChanged(object sender, EventArgs e)
        {
            if (champCin.Text.Length > 12)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champCin, "La valeur saisie dépasse la taille maximale autorisée de 12 caractères");
                champCin.Text = champCin.Text.Substring(0, 12);
            }
            else if (!Int64.TryParse(champCin.Text, out _))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champTelephone, "Valeur invalide. La valeur saisie doit être composée que des chiffres");
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
