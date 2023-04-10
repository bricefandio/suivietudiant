using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace validcomp
{
    internal class Etudiant
    {
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Referentiel { get; set; }



        public Etudiant (string nom, string prenom, string referentiel)
        {
            Nom = nom;
            Prenom = prenom;
            Referentiel = referentiel;

        }
        public  string Savestud(string nom, string prenom, string referentiel)
        {
            Etudiant etudiant = new Etudiant(nom, prenom, referentiel);
            string etudiants = JsonConvert.SerializeObject(etudiant, Newtonsoft.Json.Formatting.Indented);
            string chemin = Path.Combine("C:\\Users\\Pharex\\source\\repos\\validcomp\\etudiant", "etudiant_"+nom+".json");

            File.WriteAllText(chemin,etudiants);
            MessageBox.Show("etudiant enregistrer avec succes");
            return chemin;
            

        }



    }
}
