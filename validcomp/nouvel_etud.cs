using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace validcomp
{
    public partial class nouvel_etud : Form
    {
        public nouvel_etud()
        {
            InitializeComponent();
        }

        private void nouvel_etud_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void enregistrer_Click(object sender, EventArgs e)
        {



            String nom = txt_nom.Text;
            String prenom = txt_prenom.Text;
            String referentiel = txt_referentiel.Text;
           


            txt_nom.Text = "";
            txt_prenom.Text = "";
            txt_referentiel.Text = "";
           

            Etudiant et = new Etudiant(nom, prenom, referentiel);
            string etudiantFile = et.Savestud(nom, prenom, referentiel);




           

        }

        private void button4_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var ligne = File.OpenRead(openFileDialog1.FileName);
            string Dataread;
            using (StreamReader sr = new StreamReader(ligne))
            {
                Dataread = sr.ReadToEnd();
            }
            Etudiant etudiant = JsonConvert.DeserializeObject<Etudiant>(Dataread);



            txt_nom.Text = etudiant.Nom;
            txt_prenom.Text = etudiant.Prenom;
            txt_referentiel.Text = etudiant.Referentiel;
        }

        private void txt_nom_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Competence Competence = new Competence();
            Competence.Show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
