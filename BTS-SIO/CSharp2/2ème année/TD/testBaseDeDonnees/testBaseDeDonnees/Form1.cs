using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace testBaseDeDonnees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btExec_Click(object sender, EventArgs e)
        {
            //host
            string cs = @"server=localhost;user=root;password=;database=gatci";
            //nouvel objet de type MysqlConnection
            MySqlConnection con = new MySqlConnection(cs);
            //permet de créer des commandes et exécuter des requêtes 
            MySqlCommand cmd = null;
            //permet de lire des données issues d'un résultat de MySqlCommand
            MySqlDataReader rdr = null;
            //Requête SQL au format string
            string reqQuery = "";

            con.Open();
            cmd = con.CreateCommand();
            reqQuery = "SELECT * FROM  TYPE_ANIM";
            cmd.CommandText = reqQuery;
            rdr = cmd.ExecuteReader();

            string resultat = "";
            while(rdr.Read())
                resultat += "Code Type Animation : " + rdr["CODETYPEANIM"] + " Nom Type Animation : " + rdr["NOMTYPEANIM"] + "\n";

            con.Close();
            MessageBox.Show(resultat);
        }
    }
}
