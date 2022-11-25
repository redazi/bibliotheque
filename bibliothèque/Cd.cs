using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothèque
{
    class Cd : Ouvrage
    {
      
        public Cd(string titre, string auteur, string date, string n) : base(titre, auteur,date,n) {
          
        }


        public override void afficher()
        {
            Console.Out.Write("Le CD ");
            base.afficher();
        }
    }
}
