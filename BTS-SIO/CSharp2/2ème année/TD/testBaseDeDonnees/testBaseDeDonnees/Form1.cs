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
            MySqlConnection con = Datas.createConnexion("localhost", "root", "", "gatci");

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            string reqQuery = "SELECT * FROM  TYPE_ANIM";
            cmd.CommandText = reqQuery;
            MySqlDataReader rdr = cmd.ExecuteReader();

            string resultat = "";
            while(rdr.Read())
                resultat += "Code Type Animation : " + rdr["CODETYPEANIM"] + " Nom Type Animation : " + rdr["NOMTYPEANIM"] + "\n";

            Datas.closeConnexion(con);
            MessageBox.Show(resultat);
        }
    }
}
