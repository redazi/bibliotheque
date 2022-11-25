using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothèque
{
    class Ouvrage
    {

        public String auteur;
        public String titre;
        private string cote;
        private string dateEmprunt;

        public string Auteur { get => auteur; set => auteur = value; }
        public string Titre { get => titre; set => titre = value; }
        public string DateEmprunt { get => dateEmprunt; set => dateEmprunt = value; }
        public string Cote { get => cote; set => cote = value; }

        public Ouvrage(string titre, string auteur,string date,string n)
        {
            this.dateEmprunt = date;
            this.Auteur = auteur;
            this.Titre = titre;
            this.Cote = n;
        }

        public Ouvrage(string titre, string cote, string dateEmprunt)
        {
            this.titre = titre;
            this.cote = cote;
            this.dateEmprunt = dateEmprunt;
        }

        public virtual void afficher()
        {
            Console.Out.Write(this.Titre + " de " + this.Auteur);
        }
    }
}
