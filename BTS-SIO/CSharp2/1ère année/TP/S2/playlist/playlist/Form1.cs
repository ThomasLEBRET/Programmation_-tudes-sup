using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; //Lecture et écriture dans les fichiers
using System.Runtime.Serialization.Formatters.Binary; //Serialisation
using System.Xml.Serialization; //Serialisation xml

namespace playlist
{
    public partial class Form1 : Form
    {
        Playlist maPlaylist;
        public Form1()
        {
            InitializeComponent();
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btEnregistrer_Click(object sender, EventArgs e)
        {
            string monTitre = tbTitre.Text; //récupère info
            string monInterprete = tbInterprète.Text;
            int maDuree = Convert.ToInt16(nudDurée.Text);
            Chanson maChanson = new Chanson(); //Créé une Chanson
            maChanson.SetTitre(monTitre);
            maChanson.SetInterprete(monInterprete);
            maChanson.SetDuree(maDuree);
            MesOutils.EffacerZonesDeTexte(this);
            maPlaylist.AjouterChanson(maChanson); //Ajoute dans l'ArrayList
        }

        private void btVerifier_Click(object sender, EventArgs e)
        {
            maPlaylist.VerifierPlaylist(lbPlaylist);
            maPlaylist.DureeTotalPlayListe(label5);
            maPlaylist.NombreChansons(label7);
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void btSupprimeChanson_Click(object sender, EventArgs e)
        {
            int numChanson = Convert.ToInt16(nudEnleveChanson.Text);
            maPlaylist.SupprimerChanson(numChanson);
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maPlaylist = new Playlist();
            MesOutils.EffacerZonesDeTexte(this);
        }

        private void btEnregisterSerialisation_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/S2/playlist/playlist/playlist.dat", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(stream, maPlaylist);
            stream.Close();
        }

        private void btCharger_Click(object sender, EventArgs e)
        {
            Stream stream = File.Open("C:/Users/thleb/Documents/GitHub/CSharp_BTS-SIO/S2/playlist/playlist/playlist.dat", FileMode.Open);
            BinaryFormatter bf = new BinaryFormatter();
            maPlaylist = (Playlist)bf.Deserialize(stream);
            stream.Close();
        }
    }
}
