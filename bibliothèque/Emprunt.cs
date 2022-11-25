using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bibliothèque
{
    class Emprunt
    {
        public String nom;
        public String cin;
        public String delai;
        public String typeOuvr;
        public String numO;
        public String dateE;

        public string Nom { get => nom; set => nom = value; }
        public string Cin { get => cin; set => cin = value; }
        public string Delai { get => delai; set => delai = value; }
        public string TypeOuvr { get => typeOuvr; set => typeOuvr = value; }
        public string NumO { get => numO; set => numO = value; }
        public string DateE { get => dateE; set => dateE = value; }

        public Emprunt(string nom, String cin, String delai, String type,string numO,string dateE) 
        {
            this.nom = nom;
            this.cin = cin;
            this.delai = delai;
            this.typeOuvr = type;
        }
    }
}
