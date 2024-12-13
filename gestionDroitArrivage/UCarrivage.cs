using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using QuestPDF.Companion;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Formats.Asn1;
using System.IO.Enumeration;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = QuestPDF.Infrastructure.Color;

namespace gestionDroitArrivage
{
    public partial class UCarrivage : UserControl
    {
        public UCarrivage()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //chargement des matricules dans la table vehicule pour la comboBoxMatricule
            string query = "SELECT matricule FROM vehicule";
            connectionDb.creerConnection();
            DataTable table = connectionDb.recuperData(query);
            connectionDb.fermerConnection();
            comboBoxMatricule.DataSource = table;
            comboBoxMatricule.ValueMember = "matricule";

            //chargement des ref_marchandise dans la table marchandise pour la comboBoxMarchandise
            string query2 = "SELECT ref_marchandise FROM marchandise";
            connectionDb.creerConnection();
            DataTable tab = connectionDb.recuperData(query2);
            connectionDb.fermerConnection();
            comboBoxMarchandise.DataSource = tab;
            comboBoxMarchandise.ValueMember = "ref_marchandise";

            //chargement des données "arrivage"
            chargerDataArrivage();

            clearChamps();
        }

        private void chargerDataArrivage()
        {
            string query1 = "SELECT arrivage.*, contenir.ref_marchandise, contenir.qte FROM arrivage,contenir " +
                "WHERE (arrivage.date_arrivage = contenir.date_arrivage) ";
            connectionDb.creerConnection();
            DataTable table1 = connectionDb.recuperData(query1);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table1;
        }

        private void clearChamps()
        {
            dateTimeArrivage.Value = DateTime.Now;
            champPointDepart.Clear();
            comboBoxMatricule.Text = "";
            comboBoxMarchandise.Text = "";
            champQte.Clear();
            listBoxMarchandise.Items.Clear();
            listBoxQte.Items.Clear();
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //numArrivage = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            dateTimeArrivage.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            champPointDepart.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxMatricule.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            comboBoxMarchandise.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            champQte.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (comboBoxMarchandise.Text == "")
            {
                MessageBox.Show("Veuillez saisir la référence de la marchandise !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxMarchandise.Focus();
            }
            else if (champQte.Text == "")
            {
                MessageBox.Show("Veuillez saisir la quantité de la marchandise !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                champQte.Focus();
            }
            else if (!int.TryParse(champQte.Text, out _) && !double.TryParse(champQte.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ quatité doit être un nombre !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champQte.Clear();
                champQte.Focus();
            }
            else
            {
                listBoxMarchandise.Items.Add(comboBoxMarchandise.Text);
                listBoxQte.Items.Add(champQte.Text);

                DateTime dateArrivage = dateTimeArrivage.Value;

                //connectionDb.creerConnection();
                string server = "localhost";
                string user = "root";
                string database = "droitarrivagedb";
                string pwd = "";

                string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();

                //connectionDb.inserer(query);
                string query = "INSERT INTO contenir(date_arrivage, ref_marchandise, qte) " +
                    "VALUES ('" + dateArrivage.ToString("yyyy/MM/dd HH:mm") + "', '" + comboBoxMarchandise.Text + "', '" + champQte.Text + "')";
                MySqlCommand cmd = new MySqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                //connectionDb.fermerConnection();
                connect.Close();
                comboBoxMarchandise.Text = "";
                champQte.Clear();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamps();
        }

        private void btnAjoutArrivage_Click(object sender, EventArgs e)
        {
            if (champPointDepart.Text == "" || comboBoxMatricule.Text == "" || listBoxMarchandise.Items.Count == 0 || listBoxQte.Items.Count == 0)
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //collection des informations
                string server = "localhost";
                string user = "root";
                string database = "droitarrivagedb";
                string pwd = "";
                string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();
                MySqlCommand comm = new MySqlCommand("SELECT date_arrivage FROM contenir ORDER BY date_arrivage DESC LIMIT 1", connect);
                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                DateTime date = reader.GetDateTime("date_arrivage");
                connect.Close();

                string query = "INSERT INTO arrivage(date_arrivage, point_depart, matricule) " +
                    "VALUES ('" + date.ToString("yyyy/MM/dd HH:mm") + "', '" + champPointDepart.Text + "', '" + comboBoxMatricule.Text + "')";

                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataArrivage();
                clearChamps();
            }
        }

        private void btnModifArrivage_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un arrivage à modifier !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (champPointDepart.Text == "" || comboBoxMatricule.Text == "" || comboBoxMarchandise.Text == "" || champQte.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(champQte.Text, out _) && !double.TryParse(champQte.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ quatité doit être un nombre !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champQte.Clear();
                champQte.Focus();
            }
            else
            {
                //collection des informations
                int indexRow = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow row = dataGridView1.Rows[indexRow];
                int numArriv = Convert.ToInt32(row.Cells["num_arrivage"].Value);
                var marchandise = Convert.ToString(row.Cells["ref_marchandise"].Value);
                DateTime ancienDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                DateTime dateArrivage = dateTimeArrivage.Value;

                string query = "UPDATE arrivage,contenir SET arrivage.date_arrivage='" + dateArrivage.ToString("yyyy/MM/dd HH:mm") + "'," +
                    "arrivage.point_depart='" + champPointDepart.Text + "', arrivage.matricule='" + comboBoxMatricule.Text + "', " +
                    "contenir.ref_marchandise='" + comboBoxMarchandise.Text + "', contenir.qte='" + champQte.Text + "' " +
                    "WHERE (arrivage.date_arrivage=contenir.date_arrivage) AND arrivage.num_arrivage='" + numArriv + "' " +
                    "AND contenir.date_arrivage='" + ancienDate.ToString("yyyy/MM/dd HH:mm") + "' AND contenir.ref_marchandise='" + marchandise + "'  ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();

                //modifier la date des autres marchandises concernants
                string server = "localhost";
                string user = "root";
                string database = "droitarrivagedb";
                string pwd = "";

                string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();
                MySqlCommand cmd = new MySqlCommand("UPDATE contenir SET contenir.date_arrivage='" + dateArrivage.ToString("yyyy/MM/dd HH:mm") + "'" +
                    " WHERE contenir.date_arrivage='" + ancienDate.ToString("yyyy/MM/dd HH:mm") + "' ", connect);
                cmd.ExecuteNonQuery();
                connect.Close();

                chargerDataArrivage();
                clearChamps();
            }
        }

        private void btnSupprArrivage_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un arrivage à supprimer !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult reponse = MessageBox.Show("Voullez vous vraiment supprimer cette enregistrement ?", "" +
                    "Gestion de droit d'arrivage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (reponse == DialogResult.Yes)
                {
                    //collection des informations
                    int indexRow = dataGridView1.SelectedCells[0].RowIndex;
                    DataGridViewRow row = dataGridView1.Rows[indexRow];
                    int numArriv = Convert.ToInt32(row.Cells["num_arrivage"].Value);
                    DateTime ancienDate = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    var marchandise = Convert.ToString(row.Cells["ref_marchandise"].Value);

                    string query1 = "DELETE FROM contenir WHERE date_arrivage='" + ancienDate.ToString("yyyy/MM/dd HH:mm") + "' " +
                        "AND ref_marchandise='" + marchandise + "'";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query1);
                    connectionDb.fermerConnection();

                    //suppression de tout arrivage correspondant à 'ancienDate'
                    string server = "localhost";
                    string user = "root";
                    string database = "droitarrivagedb";
                    string pwd = "";

                    string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                    MySqlConnection connect = new MySqlConnection(con);
                    connect.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT COUNT(date_arrivage) AS reste FROM contenir " +
                        "WHERE date_arrivage='" + ancienDate.ToString("yyyy/MM/dd HH:mm") + "'", connect);
                    MySqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    int result = reader.GetInt32("reste");
                    connect.Close();

                    if (result == 0)
                    {
                        connect.Open();
                        MySqlCommand cm = new MySqlCommand("DELETE FROM arrivage WHERE date_arrivage='" + ancienDate.ToString("yyyy/MM/dd HH:mm") + "'", connect);
                        cm.ExecuteNonQuery();
                        connect.Close();
                    }
                    chargerDataArrivage();
                    clearChamps();
                }
            }
        }

        private void btnQuitance_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //recuperer les données
                int numArrivage = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DateTime dateArriv = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                var pointDep = Convert.ToString(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                var matricule = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                var marchandise = Convert.ToString(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                Double qte = Convert.ToDouble(dataGridView1.CurrentRow.Cells[5].Value.ToString());
                string server = "localhost";
                string user = "root";
                string database = "droitarrivagedb";
                string pwd = "";
                string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();
                MySqlCommand comm = new MySqlCommand("SELECT (contenir.qte*droit.tarif) AS montantAPayer FROM contenir " +
                    "LEFT JOIN marchandise ON (contenir.ref_marchandise=marchandise.ref_marchandise) " +
                    "LEFT JOIN droit ON (marchandise.ref_droit=droit.ref_droit) WHERE contenir.ref_marchandise='" + marchandise + "' " +
                    "AND contenir.date_arrivage='" + dateArriv.ToString("yyyy/MM/dd HH:mm") + "' ", connect);
                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                int montantApayer = reader.GetInt32("montantAPayer");
                connect.Close();
                
                using (SaveFileDialog savefiledialog = new SaveFileDialog())
                {
                    savefiledialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    savefiledialog.FileName = "Quittance numéro " + numArrivage + "_" + marchandise + ".pdf";
                    if (savefiledialog.ShowDialog() == DialogResult.OK)
                    {
                        //Cree le fichier PDF
                        QuestPDF.Settings.License = QuestPDF.Infrastructure.LicenseType.Community;
                        QuestPDF.Fluent.Document.Create(pdf =>
                        {
                            pdf.Page(page =>
                            {
                                page.Size(600, 500);
                                page.Margin(10);
                                page.Header().Text("Commune Urbaine de Fianarantsoa \n ").Bold().FontSize(35).AlignCenter();
                                page.Content().Column(colonne =>
                                {
                                    colonne.Spacing(20);
                                    colonne.Item().Text("Quittance numéro : " + numArrivage + "_" + marchandise + " ").AlignCenter();
                                    colonne.Item().Image(Placeholders.Image(500, 50));
                                    colonne.Item().Row(ligne1 =>
                                    {
                                        ligne1.Spacing(20);
                                        ligne1.RelativeItem().Column(colonne1 =>
                                        {
                                            colonne1.Item().Text("Date de l'arrivage : \n\n");
                                            colonne1.Item().Text("Matricule du véhicule : \n\n");
                                            colonne1.Item().Text("Point de départ : \n\n");
                                            colonne1.Item().Text("Référence de la marchandise : \n\n");
                                            colonne1.Item().Text("Quantité de la marchandise : \n\n");
                                            colonne1.Item().Text("Montant à payer (Droit) : \n\n");
                                        });
                                        ligne1.RelativeItem().Column(colonne2 =>
                                        {
                                            colonne2.Item().Text("  " + dateArriv + "  \n\n");
                                            colonne2.Item().Text("  " + matricule + "  \n\n");
                                            colonne2.Item().Text("  " + pointDep + "  \n\n");
                                            colonne2.Item().Text("  " + marchandise + "  \n\n");
                                            colonne2.Item().Text("  " + qte + "Kg \n\n");
                                            colonne2.Item().Text("  "+montantApayer+"Ar ("+montantEnLettre(montantApayer)+") \n\n");
                                        });
                                    });
                                });
                            });
                        }).GeneratePdf(savefiledialog.FileName);
                        MessageBox.Show("Elaboration de quittance avec succès !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private static string montantEnLettre(int montant)
        {
            if (montant == 0)
            {
                return "zéro Ariary";
            }

            string[] units = {
                "", "un", "deux", "trois", "quatre", "cinq", "six", "sept", "huit", "neuf", "dix",
                "onze", "douze", "treize", "quatorze", "quinze", "seize", "dix-sept", "dix-huit", "dix-neuf"
            };

            string[] tens = {
                "", "", "vingt", "trente", "quarante", "cinquante", "soixante", "soixante-dix", "quatre-vingt", "quatre-vingt-dix"
            };

            StringBuilder words = new StringBuilder();

            // Traitement des millions
            if ((montant / 1000000) > 0)
            {
                int millions = montant / 1000000;
                if (millions > 1 && millions < 20)
                {
                    words.Append(units[millions]);
                }
                if (millions >= 20 && millions < 100)
                {
                    words.Append(tens[millions / 10]); if (millions % 10 > 0) { words.Append("-" + units[millions % 10]); }
                }
                if (millions >= 100)
                {
                    int centaine = millions / 100;
                    if (centaine > 1)
                    {
                        words.Append(units[centaine]);
                    }
                    words.Append(" cent ");
                    if (millions % 100 < 20)
                    {
                        words.Append(units[millions % 100]);
                    }
                    if (millions % 100 >= 20)
                    {
                        words.Append(tens[(millions % 100) / 10]); if ((millions % 100) % 10 > 0) { words.Append("-" + units[(millions % 100) % 10]); }
                    }
                }
                words.Append(" million ");
                montant %= 1000000;
                if (montant > 0) { words.Append(" "); }

            }

            // Traitement des milliers
            if ((montant / 1000) > 0)
            {
                int milliers = montant / 1000;
                if (milliers > 1 && milliers < 20)
                {
                    words.Append(units[milliers]);
                }
                if (milliers >= 20 && milliers < 100)
                {
                    words.Append(tens[milliers / 10]); if (milliers % 10 > 0) { words.Append("-" + units[milliers % 10]); }
                }
                if (milliers >= 100)
                {
                    int centaine = milliers / 100;
                    if (centaine > 1)
                    {
                        words.Append(units[centaine]);
                    }
                    words.Append(" cent ");
                    if (milliers % 100 < 20)
                    {
                        words.Append(units[milliers % 100]);
                    }
                    if (milliers % 100 >= 20)
                    {
                        words.Append(tens[(milliers % 100) / 10]); if ((milliers % 100) % 10 > 0) { words.Append("-" + units[(milliers % 100) % 10]); }
                    }
                }
                words.Append(" mille ");
                montant %= 1000;
                if (montant > 0) { words.Append(" "); }

            }

            // Traitement des centaines
            if ((montant / 100) > 0)
            {
                int centaines = montant / 100;
                if (centaines > 1)
                {
                    words.Append(units[centaines]);
                }
                words.Append(" cent ");
                montant %= 100;
                if (montant > 0) { words.Append(" "); }

            }

            // Traitement des dizaines et unités
            if (montant > 0)
            {
                if (montant < 20)
                {
                    words.Append(units[montant]);
                }
                else
                {
                    int dizaine = montant / 10;
                    int unite = montant % 10;

                    words.Append(tens[dizaine]);
                    if (unite > 0)
                    {
                        words.Append("-" + units[unite]);
                    }
                }
            }

            words.Append(" Ariary");
            return words.ToString().Trim();
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                //chargement des données "arrivage"
                chargerDataArrivage();
                textBoxRecherche.PlaceholderText = "yyyy-mm-dd";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT arrivage.*, contenir.ref_marchandise, contenir.qte FROM arrivage,contenir " +
                    "WHERE (arrivage.date_arrivage = contenir.date_arrivage) " +
                    "AND Date(arrivage.date_arrivage) LIKE '%" + textBoxRecherche.Text + "%'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();

                dataGridView1.DataSource = table;
            }
        }

        private void listBoxMarchandise_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Voulez vous retirer cet élément ?", "Gestion de droit d'arrivage", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
            {

                if (listBoxMarchandise.SelectedIndex != -1 || listBoxQte.SelectedIndex != -1)
                {
                    //connectionDb.creerConnection();
                    string server = "localhost";
                    string user = "root";
                    string database = "droitarrivagedb";
                    string pwd = "";

                    string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                    MySqlConnection connect = new MySqlConnection(con);
                    connect.Open();
                    MySqlCommand comm = new MySqlCommand("SELECT date_arrivage FROM contenir ORDER BY date_arrivage DESC LIMIT 1", connect);
                    MySqlDataReader reader = comm.ExecuteReader();
                    reader.Read();
                    DateTime date = reader.GetDateTime("date_arrivage");
                    connect.Close();

                    //Supprime l'élément de la base de données
                    connect.Open();
                    string query = "DELETE FROM contenir WHERE contenir.date_arrivage='" + date.ToString("yyyy/MM/dd HH:mm:ss") + "' AND contenir.ref_marchandise='" + listBoxMarchandise.SelectedItem + "' ";
                    MySqlCommand cmd = new MySqlCommand(query, connect);
                    cmd.ExecuteNonQuery();

                    //connectionDb.fermerConnection();
                    connect.Close();

                    //retire l'élément sélectionné
                    int index = listBoxMarchandise.SelectedIndex;
                    listBoxMarchandise.Items.RemoveAt(index);
                    listBoxQte.Items.RemoveAt(index);

                }

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void champPointDepart_TextChanged(object sender, EventArgs e)
        {
            if (champPointDepart.Text.Length > 50)
            {
                errorProvider1.SetError(champPointDepart, "La valeur saisie dépasse la taille maximale autorisée de 50 caractères");
                champPointDepart.Text = champPointDepart.Text.Substring(0, 50);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxMatricule_Leave(object sender, EventArgs e)
        {
            if (comboBoxMatricule.Text.Length > 15)
            {
                errorProvider1.SetError(comboBoxMatricule, "La valeur saisie dépasse la taille maximale autorisée de 15 caractères");
                comboBoxMatricule.Text = comboBoxMatricule.Text.Substring(0, 15);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void comboBoxMarchandise_Leave(object sender, EventArgs e)
        {
            if (comboBoxMarchandise.Text.Length > 5)
            {
                errorProvider1.SetError(comboBoxMarchandise, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                comboBoxMarchandise.Text = comboBoxMarchandise.Text.Substring(0, 5);
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void champQte_TextChanged(object sender, EventArgs e)
        {
            if (champQte.Text.Length > 5)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champQte, "La valeur saisie dépasse la taille maximale autorisée de 5 caractères");
                champQte.Text = champQte.Text.Substring(0, 5);
            }
            else if (!int.TryParse(champQte.Text, out _) && !double.TryParse(champQte.Text, out _))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champQte, "Valeur invalide. La valeur saisie doit être un nombre");
            }
            else
            {
                errorProvider1.Clear();
            }
        }


    }
}
