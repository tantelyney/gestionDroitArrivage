using MySql.Data.MySqlClient;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDroitArrivage
{
    public partial class UCpayement : UserControl
    {
        public UCpayement()
        {
            InitializeComponent();
        }

        private void textBoxRecherche_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserControlPayem_Load(object sender, EventArgs e)
        {
            //chargement des données pour la 'comboBoxMatricule'
            string query = "SELECT matricule FROM vehicule";
            connectionDb.creerConnection();
            DataTable table = connectionDb.recuperData(query);
            connectionDb.fermerConnection();
            comboBoxMatricule.DataSource = table;
            comboBoxMatricule.ValueMember = "matricule";

            chargerDataPayement();
            clearChamp();
        }

        private void chargerDataPayement()
        {
            string query1 = "SELECT * FROM payement";
            connectionDb.creerConnection();
            DataTable table1 = connectionDb.recuperData(query1);
            connectionDb.fermerConnection();
            dataGridView1.DataSource = table1;

            string query2 = "SELECT arrivage.matricule, SUM(contenir.qte*droit.tarif) AS total_a_payer, (SELECT SUM(payement.montant)" +
                " FROM payement WHERE payement.matricule=arrivage.matricule) AS total_payement," +
                " (SUM(contenir.qte*droit.tarif)-(SELECT SUM(payement.montant) FROM payement " +
                "WHERE payement.matricule=arrivage.matricule)) AS reste_a_payer FROM arrivage " +
                "LEFT JOIN contenir ON (arrivage.date_arrivage=contenir.date_arrivage) " +
                "LEFT JOIN marchandise ON (contenir.ref_marchandise=marchandise.ref_marchandise) " +
                "LEFT JOIN droit ON (marchandise.ref_droit=droit.ref_droit) " +
                "LEFT JOIN payement ON (DATE(arrivage.date_arrivage)=DATE(payement.date_arrivage)) GROUP BY arrivage.matricule";
            connectionDb.creerConnection();
            DataTable table2 = connectionDb.recuperData(query2);
            connectionDb.fermerConnection();
            dataGridView2.DataSource = table2;
        }

        private void clearChamp()
        {
            datePayement.Value = DateTime.Now;
            dateArrivage.Value = DateTime.Now;
            champMontant.Clear();
            comboBoxMatricule.Text = "";
            dataGridView1.ClearSelection();
            dataGridView2.ClearSelection();
        }

        private void textBoxRecherche_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxRecherche.Text == "")
            {
                chargerDataPayement();
                textBoxRecherche.PlaceholderText = "numéro/date de payement";
                dataGridView1.ClearSelection();
            }
            else
            {
                string query = "SELECT * FROM payement WHERE num_payement LIKE '%" + textBoxRecherche.Text + "%' " +
                    "OR date_payement LIKE '" + textBoxRecherche.Text + "'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView1.DataSource = table;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int numPayement = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            datePayement.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            champMontant.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxMatricule.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateArrivage.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void textBoxMatricule_KeyUp(object sender, KeyEventArgs e)
        {
            if (textBoxMatricule.Text == "")
            {
                chargerDataPayement();
                textBoxMatricule.PlaceholderText = "matricule véhicule";
                dataGridView2.ClearSelection();
            }
            else
            {
                string query = "SELECT arrivage.matricule, SUM(contenir.qte*droit.tarif) AS total_a_payer, (SELECT SUM(payement.montant) " +
                    "FROM payement WHERE payement.matricule=arrivage.matricule) AS total_payement, " +
                    "(SUM(contenir.qte*droit.tarif)-(SELECT SUM(payement.montant) FROM payement " +
                    "WHERE payement.matricule=arrivage.matricule)) AS reste_a_payer FROM arrivage " +
                    "LEFT JOIN contenir ON (arrivage.date_arrivage=contenir.date_arrivage) " +
                    "LEFT JOIN marchandise ON (contenir.ref_marchandise=marchandise.ref_marchandise) " +
                    "LEFT JOIN droit ON (marchandise.ref_droit=droit.ref_droit) " +
                    "LEFT JOIN payement ON (DATE(arrivage.date_arrivage)=DATE(payement.date_arrivage)) " +
                    "WHERE arrivage.matricule LIKE '%" + textBoxMatricule.Text + "%'";
                connectionDb.creerConnection();
                DataTable table = connectionDb.recuperData(query);
                connectionDb.fermerConnection();
                dataGridView2.DataSource = table;
            }
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (champMontant.Text == "" || comboBoxMatricule.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(champMontant.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ montant doit être un entier !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champMontant.Clear();
                champMontant.Focus();
            }
            else
            {
                DateTime datePayem = datePayement.Value;
                DateTime dateArriv = dateArrivage.Value;
                string query = "INSERT INTO payement(date_payement, montant, matricule, date_arrivage) " +
                    "VALUES('" + datePayem.ToString("yyyy/MM/dd") + "', '" + champMontant.Text + "', '" + comboBoxMatricule.Text + "'," +
                    " '" + dateArriv.ToString("yyyy/MM/dd") + "') ";
                connectionDb.creerConnection();
                connectionDb.inserer(query);
                connectionDb.fermerConnection();
                chargerDataPayement();
                clearChamp();
            }
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clearChamp();
        }

        private void btnModif_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement à modifier !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (champMontant.Text == "" || comboBoxMatricule.Text == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(champMontant.Text, out _))
            {
                MessageBox.Show("Valeur invalide. La valeur du champ montant doit être un entier !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                champMontant.Clear();
                champMontant.Focus();
            }
            else
            {
                int num_payement = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DateTime datePayem = datePayement.Value;
                DateTime dateArriv = dateArrivage.Value;
                string query = "UPDATE payement SET date_payement='" + datePayem.ToString("yyyy/MM/dd") + "', montant='" + champMontant.Text + "'," +
                    " matricule='" + comboBoxMatricule.Text + "', date_arrivage='" + dateArriv.ToString("yyyy/MM/dd") + "' " +
                    "WHERE num_payement='" + num_payement + "' ";
                connectionDb.creerConnection();
                connectionDb.modifier(query);
                connectionDb.fermerConnection();
                chargerDataPayement();
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
                    int num_payement = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());

                    string query = "DELETE FROM payement WHERE num_payement='" + num_payement + "' ";
                    connectionDb.creerConnection();
                    connectionDb.supprimer(query);
                    connectionDb.fermerConnection();
                    chargerDataPayement();
                    clearChamp();
                }

            }
        }

        private void btnRecu_Click(object sender, EventArgs e)
        {
            bool selection = dataGridView1.CurrentCell.Selected;
            if (selection == false)
            {
                MessageBox.Show("Veuillez sélectionner un enregistrement !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //recuperer les données
                int numPayem = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                DateTime datePayem = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                int montant = Convert.ToInt32(dataGridView1.CurrentRow.Cells[2].Value.ToString());
                var matricule = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value.ToString());
                DateTime dateArriv = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                string server = "localhost";
                string user = "root";
                string database = "droitarrivagedb";
                string pwd = "";
                string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
                MySqlConnection connect = new MySqlConnection(con);
                connect.Open();
                MySqlCommand comm = new MySqlCommand("SELECT (SUM(contenir.qte*droit.tarif)-SUM(payement.montant)) AS reste_a_payer " +
                    "FROM arrivage LEFT JOIN contenir ON (arrivage.date_arrivage=contenir.date_arrivage) " +
                    "LEFT JOIN marchandise ON (contenir.ref_marchandise=marchandise.ref_marchandise) " +
                    "LEFT JOIN droit ON (marchandise.ref_droit=droit.ref_droit) " +
                    "LEFT JOIN payement ON (DATE(arrivage.date_arrivage)=DATE(payement.date_arrivage)) " +
                    "WHERE arrivage.matricule='" + matricule + "' ", connect);
                MySqlDataReader reader = comm.ExecuteReader();
                reader.Read();
                int resteApayer = reader.GetInt32("reste_a_payer");
                connect.Close();

                using (SaveFileDialog savefiledialog = new SaveFileDialog())
                {
                    savefiledialog.Filter = "PDF Files (*.pdf)|*.pdf";
                    savefiledialog.FileName = "Reçu numéro " + numPayem + ".pdf";
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
                                    colonne.Item().Text("Reçu numéro : " + numPayem + " ").AlignCenter();
                                    colonne.Item().Image(Placeholders.Image(500, 50));
                                    colonne.Item().Row(ligne1 =>
                                    {
                                        ligne1.Spacing(20);
                                        ligne1.RelativeItem().Column(colonne1 =>
                                        {
                                            colonne1.Item().Text("Date de payement : \n\n");
                                            colonne1.Item().Text("Matricule du véhicule : \n\n");
                                            colonne1.Item().Text("Date de l'arrivage : \n\n");
                                            colonne1.Item().Text("Montant du payement : \n\n");
                                            colonne1.Item().Text("Reste à payer : \n\n");
                                        });
                                        ligne1.RelativeItem().Column(colonne2 =>
                                        {
                                            colonne2.Item().Text("  " + datePayem + "  \n\n");
                                            colonne2.Item().Text("  " + matricule + "  \n\n");
                                            colonne2.Item().Text("  " + dateArriv + "  \n\n");
                                            colonne2.Item().Text("  " + montant + " Ar (" + montantEnLettre(montant) + ")\n\n");
                                            colonne2.Item().Text("  " + resteApayer + " Ar ("+montantEnLettre(resteApayer)+")\n\n");
                                        });
                                    });
                                });
                            });
                        }).GeneratePdf(savefiledialog.FileName);
                        MessageBox.Show("Elaboration de reçu avec succès !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                if (millions > 1 && millions < 20) { 
                    words.Append(units[millions]);
                }
                if (millions >= 20 && millions < 100)
                {
                    words.Append(tens[millions / 10]); if (millions % 10 > 0) { words.Append("-"+units[millions % 10]); }
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
                        words.Append(tens[(millions % 100) / 10]); 
                        if ((millions % 100) % 10 > 0) { words.Append("-" + units[(millions % 100) % 10]); }
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
                if (milliers > 1 && milliers < 20) { 
                    words.Append(units[milliers]);
                }
                if (milliers >= 20 && milliers < 100) { 
                    words.Append(tens[milliers/10]); if (milliers%10 > 0) { words.Append("-"+units[milliers%10]); }
                }
                if (milliers >= 100) { 
                    int centaine = milliers / 100;
                    if (centaine > 1) { words.Append(units[centaine]); 
                    }
                    words.Append(" cent ");
                    if (milliers%100 < 20) { words.Append(units[milliers%100]); 
                    }
                    if (milliers%100 >= 20) { 
                        words.Append(tens[(milliers%100)/10]);
                        if ((milliers%100)%10 > 0) { words.Append("-"+units[(milliers%100)%10]); } 
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
                if (centaines > 1) { 
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
                        words.Append("-"+units[unite]);
                    }
                }
            }
            words.Append(" Ariary");
            return words.ToString().Trim();
        }

        private void champMontant_TextChanged(object sender, EventArgs e)
        {
            if (champMontant.Text.Length > 8)
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champMontant, "La valeur saisie dépasse la taille maximale autorisée de 8 caractères");
                champMontant.Text = champMontant.Text.Substring(0, 8);
            }
            else if (!int.TryParse(champMontant.Text, out _))
            {
                errorProvider1.Clear();
                errorProvider1.SetError(champMontant, "Valeur invalide. La valeur saisie doit être un entier");
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
    }
}
