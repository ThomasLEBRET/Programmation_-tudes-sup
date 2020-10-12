using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace test {
    public partial class Form1 :Form {
        public Form1() {
            InitializeComponent();
            CenterToScreen ();
            btnCopy.Enabled = false;
        }

        private void btQuitter_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void btVerify_Click(object sender, EventArgs e) {
            string insee, key, code;
            int keyNbr;
            long inseeNbr, codeNbr, result, testInsee; //Permet de stocker de longues valeurs
            insee = tbInsee.Text;
            if (insee != "" && long.TryParse(insee, out testInsee) == true){
                inseeNbr = Convert.ToInt64(insee); //On convertie la chaine en Int64 qui équivaut au type long
            }
            if(insee.Length != 15) {
                MessageBox.Show("Erreur : Votre numéro INSEE ne possède pas 15 numéros !");
            }
            else {
                code = insee.Substring(0, 13);
                key = insee.Substring(13, 2);
                codeNbr = Convert.ToInt64(code);
                keyNbr = Convert.ToInt16(key);
                inseeNbr = Convert.ToInt64(insee);
                result = 97 - (codeNbr % 97);
                if(result != keyNbr) {
                    lbMessage.Text = "Votre numéro comporte\n15 chiffres mais n'est\n pas valide !";
                    btnCopy.Enabled = false;
                }
                else {
                    lbMessage.Text = "Votre numéro est valide";
                    btnCopy.Enabled = true;
                }
            }
        }

        private void lbInsee_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void lbMessage_Click(object sender, EventArgs e) {

        }

        private void btnCopy_Click(object sender, EventArgs e) {
            Clipboard.SetText(tbInsee.Text);
        }
    }
}
