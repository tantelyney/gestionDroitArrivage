using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionDroitArrivage
{
    class connectionDb
    {
        static MySqlConnection conn;

        public static void creerConnection() {
            string server = "localhost";
            string user = "root";
            string database = "droitarrivagedb";
            string pwd = "";

            string con = "Server=" + server + "; User=" + user + "; Database=" + database + "; Pwd=" + pwd + " ";
            conn = new MySqlConnection(con);
            conn.Open();
        
        }

        public static void fermerConnection() { conn.Close(); }

        public static void inserer(string query) 
        {
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if ( a > 0)
            {
                MessageBox.Show("Ajout avec succès !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de l'enregistrement, veuillez réessayer !", "Erreur - Gestion de droit d'arrivage",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void modifier(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Modification avec succès !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de la modification !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void supprimer(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, conn);
            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Suppression avec succès !", "Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Echec de la suppression !", "Erreur - Gestion de droit d'arrivage", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public static DataTable recuperData(string query)
        {
            DataTable tab = new DataTable();
            
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            tab.Load(reader);

            return tab;
        }


    }
}
