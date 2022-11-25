using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothèque
{
    class Livre:Ouvrage
    {
       
       
        public String editeur;

        public string Editeur { get => editeur; set => editeur = value; }

        public Livre(string titre, string auteur,string dateE,string n, string editeur) : base(titre, auteur,dateE,n)
        {
        
            this.editeur = editeur;
        }



       

        public override void afficher()
        {
            Console.Out.Write("Le livre ");
            base.afficher();
            Console.Out.Write(" editer par " + this.editeur);

        }
    }
}
