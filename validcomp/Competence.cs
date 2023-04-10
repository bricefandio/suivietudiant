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
    public partial class Competence : Form
    {
        public Competence()
        {
            InitializeComponent();

            openFileDialog2.ShowDialog();
            var ligne = File.OpenRead(openFileDialog2.FileName);
            string Dataread;
            using (StreamReader sr = new StreamReader(ligne))
            {
                Dataread = sr.ReadToEnd();
            }
            Etudiant etudiant = JsonConvert.DeserializeObject<Etudiant>(Dataread);



            enom.Text = etudiant.Nom;
            eprenom.Text = etudiant.Prenom;
            ereferent.Text = etudiant.Referentiel;


        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ereferent_Click(object sender, EventArgs e)
        {

        }

        private void Competence_Load(object sender, EventArgs e)
        {

        }
    }
}
