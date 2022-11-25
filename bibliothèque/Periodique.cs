using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothèque
{
    class Periodique : Ouvrage
    {

        private string periodicite;
        private string numero;

        public Periodique(string titre, string periodicite, string num, string date, string n) : base(titre,date,n)
        {
          
            this.periodicite = periodicite;
            this.numero = num;
        }


        public string Numero { get => numero; set => numero = value; }
        public string Periodicite { get => periodicite; set => periodicite = value; }

        public override void afficher()
        {
            Console.Out.Write("Periodique ");
            base.afficher();
            Console.Out.Write(" chaque " + this.periodicite + " jours");
        }
    }
}
