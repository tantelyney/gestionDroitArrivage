using MySql.Data.MySqlClient;
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
    public partial class UCdroit : UserControl
    {
        public UCdroit()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserControlDroit_Load(object sender, EventArgs e)
        {
            //chargement des données pour la 'comboBoxRefDroit'
            string query = "SELECT ref_droit FROM droit";
            connectionDb.creerConnection();
            DataTable table = connectionDb.recuperData(query);
            connectionDb.fermerConnection();
            comboBoxRefDroit.DataSource = table;
            comboBoxRefDroit.ValueMember = "ref_droit";

            chargerDataDroit();
            clearChamp();
        }

        private void chargerDataDroit()
        {
            string query1 = "SELECT * FROM marchandise";
            connectionDb.creerConnection();
            DataTable table1 = connectionDb.recuperData(query1);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table1;
            string query2 = "SELECT * FROM droit";
            connectionDb.creerConnection();
            DataTable table2 = connectionDb.recuperData(query2);
            connectionDb.fermerConnection();
            dataGridView2.DataSource = table2;
        }

        private void clearChamp()
        {
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
            champRefDroit.Clear();
            champTarif.Clear();
            champRefMarchandise.Clear();
            champLibelle.Clear();
            comboBoxRefDroit.Text = "";
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                chargerDataDroit();
                textBoxRecherche.PlaceholderText = "libellé marchandise";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT marchandise.* FROM marchandise WHERE marchandise.libelle LIKE '%" + textBoxRecherche.Text + "%'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            champRefMarchandise.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            champLibelle.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            comboBoxRefDroit.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            champRefDroit.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            champTarif.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            btnEnregistrer.Text = "Modifier";
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (champRefDroit.Text == "" || champTarif.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(champTarif.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ tarif doit être un entier !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champTarif.Clear();
                champTarif.Focus();
            }
            else if (btnEnregistrer.Text == "Modifier")
            {
                var refDroit = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value.ToString());

                string query1 = "UPDATE droit SET ref_droit='" + champRefDroit.Text + "', tarif='" + champTarif.Text + "' WHERE ref_droit='" + refDroit + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query1);
                connectionDb.fermerConnection();
                chargerDataDroit();
                champRefDroit.Clear();
                champTarif.Clear();
                btnEnregistrer.Text = "Enregistrer";
                dataGridView2.ClearSelection();
            }
            else
            {
                string query2 = "INSERT INTO droit(ref_droit,tarif) VALUES('" + champRefDroit.Text + "','" + champTarif.Text + "')";
                connectionDb.creerConnection();
                connectionDb.inserer(query2);
                connectionDb.fermerConnection();
                chargerDataDroit();
                champRefDroit.Clear();
                champTarif.Clear();
                dataGridView2.ClearSelection();
            }
        }

        private void champTarif_KeyUp(object sender, KeyEventArgs e)
        {
            if (champTarif.Text == "" && champRefDroit.Text == "") { btnEnregistrer.Text = "Enregistrer"; }
        }

        private void champRefDroit_KeyUp(object sender, KeyEventArgs e)
        {
            if (champTarif.Text == "" && champRefDroit.Text == "") { btnEnregistrer.Text = "Enregistrer"; }
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (champRefMarchandise.Text == "" || champLibelle.Text == "" || comboBoxRefDroit.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO marchandise " +
                    "VALUES ('" + champRefMarchandise.Text + "', '" + champLibelle.Text + "', '" + comboBoxRefDroit.Text + "')";
                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataDroit();
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
            else if (champRefMarchandise.Text == "" || champLibelle.Text == "" || comboBoxRefDroit.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }/*
            else if (!int.TryParse(champTarif.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ tarif doit être un entier !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champTarif.Clear();
                champTarif.Focus();
            }*/
            else
            {
                var refMarchandise = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string query = "UPDATE marchandise SET ref_marchandise='" + champRefMarchandise.Text + "'," +
                    " libelle='" + champLibelle.Text + "', ref_droit='" + comboBoxRefDroit.Text + "' WHERE ref_marchandise='" + refMarchandise + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();
                chargerDataDroit();
                clearChamp();
            }
        }

        private void btnSuppr_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;

            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à supprimer !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Voullez vous vraiment supprimer cette enregistrement ?", "Gestion de droit d'arrivage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    var refMarchandise = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    string query = "DELETE FROM marchandise WHERE ref_marchandise='" + refMarchandise + "' ";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query);
                    connectionDb.fermerConnection();
                    chargerDataDroit();
                    clearChamp();
                }

            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }

        private void champRefDroit_TextChanged(object sender, EventArgs e)
        {
            if (champRefDroit.Text.Length > 5)
            {
                errorProvider1.SetError(champRefDroit, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champRefDroit.Text = champRefDroit.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champTarif_TextChanged(object sender, EventArgs e)
        {
            if (champTarif.Text.Length > 5)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champTarif, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champTarif.Text = champTarif.Text.Substring(0, 5);
            }
            else if (!int.TryParse(champTarif.Text, out _))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champTarif, "Valeur invalide. La valeur saisie doit être un entier");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champRefMarchandise_TextChanged(object sender, EventArgs e)
        {
            if (champRefMarchandise.Text.Length > 5)
            {
                errorProvider1.SetError(champRefMarchandise, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champRefMarchandise.Text = champRefMarchandise.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champLibelle_TextChanged(object sender, EventArgs e)
        {
            if (champLibelle.Text.Length > 50)
            {
                errorProvider1.SetError(champLibelle, "La valeur saisie dépasse la taille maximale autorisée de 50 caractères");
                champLibelle.Text = champLibelle.Text.Substring(0, 50);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxRefDroit_Leave(object sender, EventArgs e)
        {
            if (comboBoxRefDroit.Text.Length > 5)
            {
                errorProvider1.SetError(comboBoxRefDroit, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                comboBoxRefDroit.Text = comboBoxRefDroit.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
